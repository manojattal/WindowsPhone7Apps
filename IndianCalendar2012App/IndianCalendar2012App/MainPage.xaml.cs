using System;
using Microsoft.Phone.Controls;

namespace IndianCalendar2012App
{
    public partial class MainPage : PhoneApplicationPage
    {
        #region Constructor
        public MainPage()
        {
            InitializeComponent();            
            ViewModelMonth month = new ViewModelMonth(DateTime.Today.Month);
            MonthControl control = new MonthControl(month);
            ContentPanel.Children.Add(control);
        }
        #endregion
    }
}