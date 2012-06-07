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
using Microsoft.Phone.Shell;
using System.ComponentModel;

namespace ICICIPruLifeApp
{
    public partial class Details : PhoneApplicationPage
    {
        public Details()
        {
            InitializeComponent();            
        }        
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            PhoneApplicationService appService = PhoneApplicationService.Current;

            if(appService.State.ContainsKey("viewModelDetails"))            
                this.DataContext = (ViewModelDetails)appService.State["viewModelDetails"];

            base.OnNavigatedTo(e);            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var tagValue = ((Button)sender).Tag.ToString();
            switch (tagValue)
            {
                case "back":
                    NavigationService.GoBack();
                    break;
                case "home":
                    NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                    break;
                case "advisor":
                    App.SendSms();
                    break;
            }            
        }        
    }
}