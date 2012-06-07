using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Phone.Controls;

namespace IndianCalendar2012App
{
    public partial class MonthControl : PhoneApplicationPage
    {
        #region Constructor
        public MonthControl(ViewModelMonth month)
        {
            InitializeComponent();
            m_viewmodel = month;
            this.DataContext = m_viewmodel;
            RenderUI();
        }
        #endregion

        #region Private Member Functions
        private void BackImage_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {
            if (m_viewmodel.IsBackEnabled)
            {
                m_viewmodel.LoadViewModel(m_viewmodel.MonthID - 1);
                RenderUI();
            }            
        }
        private void NextImage_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {
            if (m_viewmodel.IsForwardEnabled)
            {
                m_viewmodel.LoadViewModel(m_viewmodel.MonthID + 1);
                RenderUI();
            }            
        }
        private void RenderUI()
        {
            ContentPanel.Children.Clear();            
            for(int i = 0; i <= 6; i++)
            {
                var tb = new TextBlock() { HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center };
                int nRowPosition = 0;
                switch(i)
                {
                    case 0:
                        tb.Text = "Sun";
                        nRowPosition = 0;
                        break;
                    case 1:
                        tb.Text = "Mon";
                        nRowPosition = 1;
                        break;
                    case 2:
                        tb.Text = "Tue";
                        nRowPosition = 2;
                        break;
                    case 3:
                        tb.Text = "Wed";
                        nRowPosition = 3;
                        break;
                    case 4:
                        tb.Text = "Thu";
                        nRowPosition = 4;
                        break;
                    case 5:
                        tb.Text = "Fri";
                        nRowPosition = 5;
                        break;
                    case 6:
                        tb.Text = "Sat";
                        nRowPosition = 6;
                        break;        
                }
                Grid.SetRow(tb, nRowPosition);
                Grid.SetColumn(tb, 0);
                ContentPanel.Children.Add(tb);
            }
            
            foreach (ViewModelDate date in m_viewmodel.DateColl)
            {
                var layoutGrid = new Grid();
                layoutGrid.RowDefinitions.Add(new RowDefinition());
                layoutGrid.RowDefinitions.Add(new RowDefinition());
                layoutGrid.RowDefinitions.Add(new RowDefinition());                                
                string sTithi = date.HindiMonth + " " + (date.Paksha == PakshaEnum.Krushna ? "K. " + date.Tithi : "S. " + date.Tithi);
                var tbTithi = new TextBlock() { Text = sTithi, HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Center, Foreground = new SolidColorBrush(Colors.DarkGray), FontSize = 12};                                
                //topBarGrid.Children.Add(tbTithi);
                //if(date.IsEkadashi)
                //    topBarGrid.Background = new SolidColorBrush(Colors.Orange);
                var tbDate = new TextBlock() { Text = date.Date.ToString(), HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center, FontSize = 28 };
                //tbDate.Tap += new EventHandler<GestureEventArgs>(tbDate_Tap);
                var tbDayDescription = new TextBlock() { Text = date.DayDescription, HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Center, TextWrapping = TextWrapping.Wrap, FontSize = 10 };
                if (date.RowPosition == 0)
                    //tbDate.Foreground = new SolidColorBrush(Colors.Red);
                    layoutGrid.Background = new SolidColorBrush(Colors.Red);
                if (date.IsHoliday)
                    layoutGrid.Background = new SolidColorBrush(Colors.Red);
                if (date.IsEkadashi)
                    layoutGrid.Background = new SolidColorBrush(Colors.Orange);
                if (date.IsSankashtaChaturthi)
                    layoutGrid.Background = new SolidColorBrush(Colors.Brown);
                if (date.IsPornima)
                    layoutGrid.Background = new SolidColorBrush(Colors.Blue);
                if (date.IsAmavasya)
                    layoutGrid.Background = new SolidColorBrush(Colors.Purple);                
                tbDate.DataContext = date;
                tbTithi.VerticalAlignment = VerticalAlignment.Top;
                tbDate.VerticalAlignment = VerticalAlignment.Top;
                tbDayDescription.VerticalAlignment = VerticalAlignment.Bottom;                
                layoutGrid.Children.Add(tbTithi);
                layoutGrid.Children.Add(tbDate);
                layoutGrid.Children.Add(tbDayDescription);
                Grid.SetRow(tbDate, 1);
                Grid.SetRow(tbDayDescription, 2);
                if (m_viewmodel.MonthID == DateTime.Today.Month && date.Date == DateTime.Today.Day)
                {
                    Border border = new Border();
                    border.BorderThickness = new Thickness(7);
                    border.BorderBrush = new SolidColorBrush(Colors.Green);
                    border.Child = layoutGrid;
                    AddInContentPanel(border, date);
                }
                else
                {
                    AddInContentPanel(layoutGrid, date);
                }                
            }
        }

        private void tbDate_Tap(object sender, GestureEventArgs e)
        {
            var serv = ((PhoneApplicationPage)((Grid)(((Grid)this.Parent)).Parent).Parent).NavigationService;
            serv.Navigate(new Uri("/DateDetails.xaml?date=" + (ViewModelDate)((TextBlock)sender).DataContext, UriKind.Relative));            
        }
        private void AddInContentPanel(FrameworkElement element, ViewModelDate date)
        {
            Grid.SetRow(element, date.RowPosition);
            Grid.SetColumn(element, date.ColumnPosition);
            ContentPanel.Children.Add(element);
        }
        #endregion

        #region Private Member Variables
        private ViewModelMonth m_viewmodel;
        #endregion
    }
}