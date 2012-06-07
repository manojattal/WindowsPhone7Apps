using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ICICIPruLifeApp
{
    public class ViewModelDetails
    {
        public ViewModelDetails(string strHeading, string strDetails)
        {
            Heading = strHeading;
            Details = strDetails;
        }
        public string Heading { get; set; }
        public string Details { get; set; }
    }
}
