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
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            m_storageSettings = IsolatedStorageSettings.ApplicationSettings;            
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);            
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (m_storageSettings.TryGetValue<Baby>("babyDetails", out m_babyDetails))
            {
                if (m_babyDetails == null)
                    return;
                if (!PhoneApplicationService.Current.State.ContainsKey("DoNotGoBack"))
                {
                    NavigationService.Navigate(new Uri("/Test.xaml", UriKind.Relative));
                }                
            }            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            m_storageSettings["babyDetails"] = new Baby() { BirthDate = (DateTime)dtBabyBirth.Value };
            NavigationService.Navigate(new Uri("/Test.xaml", UriKind.Relative));            
        }
       
        IsolatedStorageSettings m_storageSettings;
        Baby m_babyDetails;
    }
}