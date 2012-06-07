using System;
using System.Windows.Threading;
using Microsoft.Phone.Controls;

namespace FinIndexApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        #region Constructor
        public MainPage()
        {
            InitializeComponent();
            finIndexViewModel = new ViewModelFinIndex();
            this.DataContext = finIndexViewModel;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        #endregion

        #region Private Member Functions
        private void timer_Tick(object sender, EventArgs e)
        {
            finIndexViewModel.GetStockMarketData();
            finIndexViewModel.GetCommodityMarketData();
        }
        #endregion

        #region Private Member Variables
        private ViewModelFinIndex finIndexViewModel;
        #endregion
    }
}