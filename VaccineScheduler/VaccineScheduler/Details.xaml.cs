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

namespace VaccineScheduler
{
    public partial class Details : PhoneApplicationPage
    {
        public Details()
        {
            InitializeComponent();
        }
      
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            IDictionary<string, string> parameters = this.NavigationContext.QueryString;
            if (parameters.ContainsKey("vaccine"))
            {
                desc = parameters["vaccine"];
                title = parameters["title"];
            }
            
            base.OnNavigatedTo(e);
            //PageTitle.Text = title;
            txtDetails.Text = desc;
        }
        string desc;
        string title;
    }
}