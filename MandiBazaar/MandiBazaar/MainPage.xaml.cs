using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace MandiBazaar
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            m_viewmodel = new ViewModelMandi();
            m_viewmodel.RefreshUIAction += CreateUI;
            m_viewmodel.LoadData();            
        }

        private void CreateUI()
        {
            if (m_viewmodel.CommodityTypeList.Count == 0)
                return;

            var nCalculatedCount = m_viewmodel.CommodityTypeList.Count / 2;
            var nCheck = m_viewmodel.CommodityTypeList.Count % 2;

            for (int i = 0; i < (nCalculatedCount + nCheck); i++)
            {
               ContentPanel.RowDefinitions.Add(new RowDefinition());
            }
            int nColumnCounter = 0;
            int nRowCounter = 0;
            foreach (var commodityType in m_viewmodel.CommodityTypeList)
            {
                Button button = new Button();
                button.Click += new RoutedEventHandler(button_Click);
                button.Content = commodityType.TypeName;
                ContentPanel.Children.Add(button);
                Grid.SetColumn(button, nColumnCounter);
                Grid.SetRow(button, nRowCounter);

                if (nRowCounter % 2 == 0)
                    button.Background = new SolidColorBrush(Colors.Green);
                else
                    button.Background = new SolidColorBrush(Colors.Orange);

                if (nColumnCounter == 1)
                {
                    nRowCounter = nRowCounter + 1;
                    nColumnCounter = 0;                    
                }
                else                
                    nColumnCounter += 1;                    
               
            }

            (Application.Current as App).SharedMandiInfo = m_viewmodel;
            txtDataUpdateTime.Text = m_viewmodel.UpdatedDate + " " + m_viewmodel.UpdatedTime;
            txtUpdatingData.Visibility = Visibility.Collapsed;
        }

        void button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/SubTypeDetails.xaml?commodityType=" + ((Button)sender).Content.ToString(), UriKind.Relative));
        }

        private ViewModelMandi m_viewmodel;
    }
}