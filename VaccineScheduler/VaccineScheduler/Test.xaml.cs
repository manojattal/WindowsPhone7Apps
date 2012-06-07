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
using System.IO.IsolatedStorage;
using Microsoft.Phone.Shell;

namespace VaccineScheduler
{
    public partial class Test : PhoneApplicationPage
    {
        public Test()
        {
            InitializeComponent();
            m_storageSettings = IsolatedStorageSettings.ApplicationSettings;
            LoadScheduleDetails();
            this.BackKeyPress += new EventHandler<System.ComponentModel.CancelEventArgs>(Test_BackKeyPress);
        }

        void Test_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            PhoneApplicationService.Current.State["DoNotGoBack"] = true;
        }

        private void LoadScheduleDetails()
        {
            //BabyDetails.Visibility = Visibility.Collapsed;
            if (m_storageSettings.TryGetValue<Baby>("babyDetails", out m_babyDetails))
            {
                if (m_babyDetails == null)
                    return;

                //txtMessage.Text = m_babyDetails.BabyName + "'s Recommended Vaccine Schedule:";
                ViewModelScheduler scheduler = new ViewModelScheduler();
                scheduler.LoadSchedule(m_babyDetails);
                string currentMonthName = string.Empty;
                Grid unitGrid = null;
                int nCurrentResultGridTracker = -1;
                int nUnitGridRowTracker = 0;
                foreach (var vaccine in scheduler.VaccineList)
                {
                    if (vaccine.VaccineMonth != currentMonthName)
                    {
                        switch (nCurrentResultGridTracker)
                        {
                            case -1:
                                unitGrid = grid1;
                                schedule1.Text = vaccine.VaccineSchedule;
                                item1.Header = vaccine.VaccineMonth;
                                break;
                            case 0:
                                unitGrid = grid2;
                                schedule2.Text = vaccine.VaccineSchedule;
                                item2.Header = vaccine.VaccineMonth;
                                break;
                            case 1:
                                unitGrid = grid3;
                                schedule3.Text = vaccine.VaccineSchedule;
                                item3.Header = vaccine.VaccineMonth;
                                break;
                            case 2:
                                unitGrid = grid4;
                                schedule4.Text = vaccine.VaccineSchedule;
                                item4.Header = vaccine.VaccineMonth;
                                break;
                            case 3:
                                unitGrid = grid5;
                                schedule5.Text = vaccine.VaccineSchedule;
                                item5.Header = vaccine.VaccineMonth;
                                break;
                            case 4:
                                unitGrid = grid6;
                                schedule6.Text = vaccine.VaccineSchedule;
                                item6.Header = vaccine.VaccineMonth;
                                break;
                            case 5:
                                unitGrid = grid7;
                                schedule7.Text = vaccine.VaccineSchedule;
                                item7.Header = vaccine.VaccineMonth;
                                break;
                            case 6:
                                unitGrid = grid8;
                                schedule8.Text = vaccine.VaccineSchedule;
                                item8.Header = vaccine.VaccineMonth;
                                break;
                            case 7:
                                unitGrid = grid9;
                                schedule9.Text = vaccine.VaccineSchedule;
                                item9.Header = vaccine.VaccineMonth;
                                break;
                            case 8:
                                unitGrid = grid10;
                                schedule10.Text = vaccine.VaccineSchedule;
                                item10.Header = vaccine.VaccineMonth;
                                break;
                            case 9:
                                unitGrid = grid11;
                                schedule11.Text = vaccine.VaccineSchedule;
                                item11.Header = vaccine.VaccineMonth;
                                break;
                            case 10:
                                unitGrid = grid12;
                                schedule12.Text = vaccine.VaccineSchedule;
                                item12.Header = vaccine.VaccineMonth;
                                break;
                            case 11:
                                unitGrid = grid13;
                                schedule13.Text = vaccine.VaccineSchedule;
                                item13.Header = vaccine.VaccineMonth;
                                break;
                            case 12:
                                unitGrid = grid14;
                                schedule14.Text = vaccine.VaccineSchedule;
                                item14.Header = vaccine.VaccineMonth;
                                break;
                        }
                        nUnitGridRowTracker = 0;
                        nCurrentResultGridTracker++;                        
                        currentMonthName = vaccine.VaccineMonth;
                        AddRecordInResultGrid(vaccine, unitGrid, nUnitGridRowTracker);
                        nUnitGridRowTracker++;
                    }
                    else
                    {
                        AddRecordInResultGrid(vaccine, unitGrid, nUnitGridRowTracker);
                        nUnitGridRowTracker++;                        
                    }
                }
            }

        }
        private void AddRecordInResultGrid(ViewModelVaccine vaccine, Grid unitGrid, int nUnitGridRowTracker)
        {
            unitGrid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });          
            var border = new Border() { Background = new SolidColorBrush(vaccine.Color) };            
            var textBlock = new TextBlock() { Text = vaccine.VaccineName + " " + vaccine.DoseDetail, FontSize= 26, TextWrapping = TextWrapping.Wrap, DataContext = vaccine };
            textBlock.Tap += new EventHandler<System.Windows.Input.GestureEventArgs>(textBlock_Tap);
            border.Child = textBlock;
            unitGrid.Children.Add(border);
            Grid.SetRow(border, nUnitGridRowTracker);            
        }

        void textBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {            
            var viewmodel = (ViewModelVaccine)((TextBlock)sender).DataContext;
            if (string.IsNullOrEmpty(viewmodel.VaccineDescription))
                return;
            var strTitle = viewmodel.VaccineFullName == string.Empty ? viewmodel.VaccineName : viewmodel.VaccineFullName;
            NavigationService.Navigate(new Uri("/Details.xaml?vaccine=" + viewmodel.VaccineDescription + "&title=" + strTitle, UriKind.Relative));
        }
        IsolatedStorageSettings m_storageSettings;
        Baby m_babyDetails;
    }
}