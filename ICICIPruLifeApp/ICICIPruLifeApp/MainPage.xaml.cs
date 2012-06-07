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

namespace ICICIPruLifeApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var tagValue = ((Button)sender).Tag.ToString();
            switch (tagValue)
            {
                case "basics":
                    NavigationService.Navigate(new Uri("/InsuranceBasics.xaml", UriKind.Relative));
                    break;
                case "plans":
                    NavigationService.Navigate(new Uri("/InsurancePlans.xaml", UriKind.Relative));
                    break;
                case "sms":
                    App.SendSms();
                    break;
                case "email":
                    App.SendEmail();
                    break;

            }                       
        }
    }
}