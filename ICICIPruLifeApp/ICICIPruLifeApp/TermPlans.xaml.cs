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
    public partial class TermPlans : PhoneApplicationPage
    {
        public TermPlans()
        {
            InitializeComponent();
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