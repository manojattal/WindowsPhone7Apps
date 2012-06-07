using System;
using System.ComponentModel;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace FinIndexApp
{
    public class ViewModelFinIndex : INotifyPropertyChanged
    {
        #region Constructor
        public ViewModelFinIndex()
        {
            sensexIndex = new Index();
            nseIndex = new Index();
            mcxGoldIndex = new Index();
            mcxSilverIndex = new Index();
        }
        #endregion

        #region Public Member Functions
        public Index SensexIndex
        {
            get
            {
                return sensexIndex;
            }
            set
            {
                sensexIndex = value;
                NotifyPropertyChanged("SensexIndex");
            }
        }
        public Index NSEIndex
        {
            get
            {
                return nseIndex;
            }
            set
            {
                nseIndex = value;
                NotifyPropertyChanged("NSEIndex");
            }
        }
        public Index MCXGoldIndex
        {
            get
            {
                return mcxGoldIndex;
            }
            set
            {
                mcxGoldIndex = value;
                NotifyPropertyChanged("MCXGoldIndex");
            }
        }
        public Index MCXSilverIndex
        {
            get
            {
                return mcxSilverIndex;
            }
            set
            {
                mcxSilverIndex = value;
                NotifyPropertyChanged("MCXSilverIndex");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        /// <summary>
        /// First call for getting stock index values.
        /// </summary>
        public void GetStockMarketData()
        {
            WebClient client = new WebClient();
            client.Headers["user-agent"] = "Only a test!";
            client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);
            client.DownloadStringAsync(new Uri("http://www.moneycontrol.com/sensex_nifty/current_tick.php"));
        }
        /// <summary>
        /// Deals with setting Sensex and NSE values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
                return;
            StringBuilder data = new StringBuilder((string)e.Result);
            data = data.Replace('{', ' ');
            data = data.Replace('[', ' ');
            data = data.Replace('}', ' ');
            data = data.Replace(']', ' ');
            data = data.Replace(':', ',');
            string[] CleanData = data.ToString().Split(',');
            SensexIndex.IndicatorValue = Double.Parse(CleanData[1].Substring(1, CleanData[1].Length - 2));
            SensexIndex.ChangeValue = Double.Parse(CleanData[3].Substring(1, CleanData[3].Length - 2));
            NSEIndex.IndicatorValue = Double.Parse(CleanData[7].Substring(1, CleanData[7].Length - 2));
            NSEIndex.ChangeValue = Double.Parse(CleanData[9].Substring(1, CleanData[9].Length - 2));
        }        
        /// <summary>
        /// First function call to get list of expiry dates from commodity market.
        /// </summary>
        public void GetCommodityMarketData()
        {
            WebClient client = new WebClient();
            client.Headers["user-agent"] = "Only a test!";
            client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_CommodityExpiryDateDownloadStringCompleted);
            client.DownloadStringAsync(new Uri("http://www.angelcommodities.com/AJAX/ExpiryDate.aspx?Exchange=MCX&Symbol=GOLD"));
            WebClient clientForSilver = new WebClient();
            clientForSilver.Headers["user-agent"] = "Only a test!";
            clientForSilver.DownloadStringCompleted += new DownloadStringCompletedEventHandler(clientForSilver_DownloadStringCompleted);
            clientForSilver.DownloadStringAsync(new Uri("http://www.angelcommodities.com/AJAX/ExpiryDate.aspx?Exchange=MCX&Symbol=SILVER"));
        }
        /// <summary>
        /// Deals with fetching recent expiry date for a Gold contract.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void clientForSilver_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                if (!m_ErrorMessageShownToUser)
                {
                    m_ErrorMessageShownToUser = true;
                    MessageBox.Show("An error occurred while getting data. Please check your Internet connection and try again later.");
                }                
                return;
            }
            var result = e.Result.ToString();
            var futureDate = e.Result.Substring(0, e.Result.IndexOf('#'));
            futureDate = futureDate.Replace(" ", "%20");
            WebClient clientForSilver = new WebClient();
            clientForSilver.Headers["user-agent"] = "Only a test!";
            clientForSilver.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_CommoditySilverValueDownloadStringCompleted);
            clientForSilver.DownloadStringAsync(new Uri("http://www.angelcommodities.com/markets/commodities-Detail-Get-Quote/MCX/SILVER/" + futureDate + ".aspx"));
        }
        /// <summary>
        /// Deals with fetching recent expiry date for a Gold contract.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void client_CommodityExpiryDateDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                if (!m_ErrorMessageShownToUser)
                {
                    m_ErrorMessageShownToUser = true;
                    MessageBox.Show("An error occurred while getting data. Please check your Internet connection and try again later.");
                }                
                return;
            }
            var futureDate = e.Result.Substring(0, e.Result.IndexOf('#'));
            futureDate = futureDate.Replace(" ", "%20");
            WebClient client = new WebClient();
            client.Headers["user-agent"] = "Only a test!";
            client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_CommodityValueDownloadStringCompleted);
            client.DownloadStringAsync(new Uri("http://www.angelcommodities.com/markets/commodities-Detail-Get-Quote/MCX/GOLD/" + futureDate + ".aspx"));
        }
        /// <summary>
        /// Deals with fetching Silver value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void client_CommoditySilverValueDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                if (!m_ErrorMessageShownToUser)
                {
                    m_ErrorMessageShownToUser = true;
                    MessageBox.Show("An error occurred while getting data. Please check your Internet connection and try again later.");
                }                
                return;
            }
            var result = e.Result.ToString();
            var currentPriceLabelIndex = result.IndexOf("Current Price(Rs.)");
            mcxSilverIndex.IndicatorValue = Double.Parse(result.Substring(currentPriceLabelIndex + 27, 8));
            var changePriceLableIndex = result.IndexOf("Change(Rs.)");
            double changeValue;
            if (Double.TryParse(result.Substring(changePriceLableIndex + 20, 3), out changeValue))
                mcxSilverIndex.ChangeValue = changeValue;
            else
                mcxSilverIndex.ChangeValue = Double.Parse(result.Substring(changePriceLableIndex + 20, 2));
        }
        /// <summary>
        /// Deals with fetching Gold value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void client_CommodityValueDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                if (!m_ErrorMessageShownToUser)
                {
                    m_ErrorMessageShownToUser = true;
                    MessageBox.Show("An error occurred while getting data. Please check your Internet connection and try again later.");
                }                
                return;
            }
            var result = e.Result.ToString();
            var currentPriceLabelIndex = result.IndexOf("Current Price(Rs.)");
            mcxGoldIndex.IndicatorValue = Double.Parse(result.Substring(currentPriceLabelIndex + 27, 8));
            var changePriceLableIndex = result.IndexOf("Change(Rs.)");
            double changeValue;
            if (Double.TryParse(result.Substring(changePriceLableIndex + 20, 3), out changeValue))
                mcxGoldIndex.ChangeValue = changeValue;
            else
                mcxGoldIndex.ChangeValue = Double.Parse(result.Substring(changePriceLableIndex + 20, 2));
        }        
        #endregion

        #region Private Member Variables
        private Index sensexIndex;
        private Index nseIndex;
        private Index mcxGoldIndex;
        private Index mcxSilverIndex;
        private bool m_ErrorMessageShownToUser;
        #endregion
    }

    public class Index : INotifyPropertyChanged
    {
        #region Public Member Functions
        public double IndicatorValue
        {
            get
            {
                return m_dIndicatorValue;
            }
            set
            {
                m_dIndicatorValue = value;
                NotifyPropertyChanged("IndicatorValue");
            }
        }
        public double ChangeValue
        {
            get
            {
                return m_dChangeValue;
            }
            set
            {
                m_dChangeValue = value;
                if (m_dChangeValue < 0)
                    m_backgroundColor = "#FFFF0000";

                else
                    m_backgroundColor = "#FF008000";
                NotifyPropertyChanged("ChangeValue");
                NotifyPropertyChanged("BackgroundColor");
            }
        }
        public double PercentageChangeValue
        {
            get
            {
                return m_dPercentageChangeValue;
            }
            set
            {
                m_dPercentageChangeValue = value;
                NotifyPropertyChanged("PercentageChangeValue");
            }
        }
        public String BackgroundColor
        {
            get
            {                
                return m_backgroundColor == null ? "#FF000000" : m_backgroundColor;
            }
        }
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
        private double m_dIndicatorValue;
        private double m_dChangeValue;
        private double m_dPercentageChangeValue;
        private string m_backgroundColor;
        #endregion
    }

    public class ColorConverter : IValueConverter
    {
        #region Public Member Functions
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string val = value.ToString();
            val = val.Replace("#", "");
            byte a = System.Convert.ToByte("ff", 16);
            byte pos = 0;
            if (val.Length == 8)
            {
                a = System.Convert.ToByte(val.Substring(pos, 2), 16);
                pos = 2;
            }
            byte r = System.Convert.ToByte(val.Substring(pos, 2), 16);
            pos += 2;

            byte g = System.Convert.ToByte(val.Substring(pos, 2), 16);
            pos += 2;

            byte b = System.Convert.ToByte(val.Substring(pos, 2), 16);
            Color col = Color.FromArgb(a, r, g, b);
            return new SolidColorBrush(col);
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            SolidColorBrush val = value as SolidColorBrush;
            return "#" + val.Color.A.ToString() + val.Color.R.ToString() + val.Color.G.ToString() + val.Color.B.ToString();
        }
        #endregion
    }
}
    
    