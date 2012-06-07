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

namespace WorldHolidays2012
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            m_viewmodel = new ViewModelHoliday();
            this.DataContext = m_viewmodel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lstCountries.SelectedItem == null)
                return;
            descText.Visibility = Visibility.Collapsed;
            m_viewmodel.LoadHolidaysForSelectedCountry(((Country)lstCountries.SelectedItem).CountryName);
            lbHolidays.ItemsSource = null;
            lbHolidays.ItemsSource = m_viewmodel.HolidaysList;
        }
        
        private ViewModelHoliday m_viewmodel;

        private void lbHolidays_Loaded(object sender, RoutedEventArgs e)
        {
            var ItemRef = sender as Grid;      // get the reference to the control
            SolidColorBrush brush1 = new SolidColorBrush(Colors.Gray);      //base colour
            SolidColorBrush brush2 = new SolidColorBrush(Colors.Orange);  //alternate colour

            if (_useAlternate)
                ItemRef.Background = brush1;
            else
                ItemRef.Background = brush2;

            _useAlternate = !_useAlternate;

        }

        private bool _useAlternate;
    }
}