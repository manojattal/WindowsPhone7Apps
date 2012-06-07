using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

namespace WeatherIndiaApp
{
    public class CityWeather : INotifyPropertyChanged
    {
        #region Public Member Functions
        public string CityName { get; set; }
        public string CityId { get; set; }
        public BitmapImage ConditionImage
        {
            get
            {
                return m_conditionImage;
            }
        }
        public string Temperature { get; set; }
        public Double Hunmidity { get; set; }
        public string Condition
        {
            get
            {
                return m_condition;
            }
            set
            {
                m_condition = value;
                m_conditionImage = new BitmapImage();
                StreamResourceInfo streamInfo = null;
                switch (m_condition)
                {
                    case "Clear":
                        if (!When.ToLower().Contains("tonight"))
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "ClearDay.png", UriKind.Relative));
                        else
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "ClearNight.png", UriKind.Relative));
                        break;
                    case "Cloudy":
                        if (!When.Contains("Night"))
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "PartlycloudyDay.png", UriKind.Relative));
                        else
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "PartlyClodyNight.png", UriKind.Relative));
                        break;
                    case "Haze":
                        if (!When.Contains("Night"))
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "Hazy.png", UriKind.Relative));
                        else
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "Hazy.png", UriKind.Relative));
                        break;

                    case "MostlyCloudy":
                        if (!When.Contains("Night"))
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "PartlycloudyDay.png", UriKind.Relative));
                        else
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "PartlyClodyNight.png", UriKind.Relative));
                        break;
                    case "PartlyCloudy":
                        if (!When.Contains("Night"))
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "PartlycloudyDay.png", UriKind.Relative));
                        else
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "PartlyClodyNight.png", UriKind.Relative));
                        break;
                    case "Rain":
                        if (!When.Contains("Night"))
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "Hazy.png", UriKind.Relative));
                        else
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "Hazy.png", UriKind.Relative));
                        break;
                    case "ScatteredClouds":
                        if (!When.Contains("Night"))
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "Hazy.png", UriKind.Relative));
                        else
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "Hazy.png", UriKind.Relative));
                        break;
                    case "Smoke":
                        if (!When.Contains("Night"))
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "Hazy.png", UriKind.Relative));
                        else
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "Hazy.png", UriKind.Relative));
                        break;
                    case "Thunderstorm":
                        if (!When.Contains("Night"))
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "Hazy.png", UriKind.Relative));
                        else
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "Hazy.png", UriKind.Relative));
                        break;
                    default:
                        if (!When.Contains("Night"))
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "PartlycloudyDay.png", UriKind.Relative));
                        else
                            streamInfo = Application.GetResourceStream(new Uri("WeatherIndiaApp;Component/Images/" + "PartlyClodyNight.png", UriKind.Relative));
                        break;
                }
                m_conditionImage.SetSource(streamInfo.Stream);
                NotifyPropertyChanged("Condition");
            }
        }
        public string SunRiseTime { get; set; }
        public string SunSetTime { get; set; }
        public string When { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region Private Member Variables
        private BitmapImage m_conditionImage;
        private string m_condition;
        #endregion
    }
}