using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using Microsoft.Phone.Controls;

namespace PinCodeIndia
{
    public partial class MainPage : PhoneApplicationPage
    {
        #region Constructor
        public MainPage()
        {
            InitializeComponent();            
        }
        #endregion

        #region Public Properties
        public ObservableCollection<PinCodeViewModel> PinCodeList
        {
            get
            {
                return m_lstPinCode;                
            }
            set
            {
                m_lstPinCode = value;
            }

        }
        private void Button_Go_Click(object sender, RoutedEventArgs e)
        {
            long lPinCodeNo = 0;
            if (txtPinCode.Text.Length == 0)
            {
                MessageBox.Show("Please enter 6 numeric digits");
                return;
            }
            if (!long.TryParse(txtPinCode.Text, out lPinCodeNo))
            {
                MessageBox.Show("Please enter 6 numeric digits");
                return;
            }
            GetPinCodeDetails(lPinCodeNo);
        }
        private void GetPinCodeDetails(long lPinCodeNo)
        {
            WebClient client = new WebClient();
            client.Headers["user-agent"] = "Only a test!";
            client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);
            client.DownloadStringAsync(new Uri("http://www.eximguru.com/traderesources/pincode.aspx?PINCode=" + lPinCodeNo.ToString()));
        }
        private void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Error occurred while processing request.");
                return;
            }
            var result = e.Result.ToString();        
            result = result.Replace("\t","");
            result = result.Replace("\r", "");
            result = result.Replace("\n", "");

            int splitIndex1 = result.LastIndexOf("basicTable");
            if (splitIndex1 == -1)
            {
                MessageBox.Show("No details found for given pincode.");
                return;
            }
            var splittedString1 = result.Substring(splitIndex1);
            var splitIndex2 = splittedString1.IndexOf("slistFooter");
            var splittedString2 = splittedString1.Substring(0, splitIndex2 - 12);
            splittedString2 = splittedString2.Substring(1045);
            LoadData(splittedString2);
        }
        private void LoadData(string result)
        {
            m_lstPinCode = new ObservableCollection<PinCodeViewModel>();
            while (result.Length > 0)
            {                
                PinCodeViewModel pinCodeViewModel = new PinCodeViewModel();
                var index = result.IndexOf("width:25%");
                if (index == -1)
                    break;
                result = result.Substring(index + 12);
                var stopIndex = result.IndexOf("</td>");                
                pinCodeViewModel.City = result.Substring(0, stopIndex);
                result = result.Substring(stopIndex + 5);
                index = result.IndexOf("width:25%");
                result = result.Substring(index + 12);
                stopIndex = result.IndexOf("</td>");
                pinCodeViewModel.State = result.Substring(0, stopIndex);
                result = result.Substring(stopIndex + 5);
                index = result.IndexOf("width:30%");
                result = result.Substring(index + 12);
                stopIndex = result.IndexOf("</td>");
                pinCodeViewModel.Area = result.Substring(0, stopIndex);
                result = result.Substring(stopIndex + 5);
                m_lstPinCode.Add(pinCodeViewModel);
            }

            lbPinCode.ItemsSource = PinCodeList;
        }
        #endregion

        #region Private Member Variables
        private ObservableCollection<PinCodeViewModel> m_lstPinCode;
        #endregion
    }
}