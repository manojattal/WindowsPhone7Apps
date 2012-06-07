using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;

namespace WeatherIndiaApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        #region Constructor
        public MainPage()
        {
            InitializeComponent();
            m_viewmodel = new DialogViewModel();
            this.DataContext = m_viewmodel;          
        }      
        #endregion

        #region Private Member Functions
        private void lstCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                m_viewmodel.LoadData(e.Result.ToString());            
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("There might be issue with your Internet connection or Data could not be loaded.");
            }            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lstCity.SelectedItem == null)
                return;

            // get weather for this city...
            //create request like http://www.wunderground.com/global/stations/43009.html

            WebClient client = new WebClient();
            client.Headers["user-agent"] = "Only a test!";
            client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);
            client.DownloadStringAsync(new Uri("http://www.wunderground.com/global/stations/" + ((CityWeather)lstCity.SelectedItem).CityId.ToString() + ".html"));
        }
        #endregion

        #region Private Member Variables
        private DialogViewModel m_viewmodel;
        #endregion
    }
}