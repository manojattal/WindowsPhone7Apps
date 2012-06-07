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
    public partial class InsurancePlans : PhoneApplicationPage
    {
        public InsurancePlans()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var tagValue = ((Button)sender).Tag.ToString();
            switch (tagValue)
            {
                case "term":
                    NavigationService.Navigate(new Uri("/TermPlans.xaml", UriKind.Relative));
                    break;
                case "wealthulip":
                    NavigationService.Navigate(new Uri("/WealthPlans.xaml", UriKind.Relative));
                    break;
                case "child":
                    NavigationService.Navigate(new Uri("/ChildPlans.xaml", UriKind.Relative));
                    break;
                case "health":
                    NavigationService.Navigate(new Uri("/HealthPlans.xaml", UriKind.Relative));
                    break;
                case "retirement":
                    NavigationService.Navigate(new Uri("/HealthPlans.xaml", UriKind.Relative));
                    break;
                case "wealthtraditional":
                    NavigationService.Navigate(new Uri("/HealthPlans.xaml", UriKind.Relative));
                    break;
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