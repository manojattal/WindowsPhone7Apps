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

namespace MandiBazaar
{
    public partial class CommodityList : PhoneApplicationPage
    {
        public CommodityList()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            IDictionary<string, string> parameters = this.NavigationContext.QueryString;
            if (parameters.ContainsKey("commodityType"))
            {
                m_viewmodel = (Application.Current as App).SharedMandiInfo;
                var commodityType = m_viewmodel.CommodityTypeList.First(comotype => comotype.TypeName == parameters["commodityType"]);
                var commoditySubType = commodityType.CommoditySubTypeList.First(comoSubType => comoSubType.SubTypeName == parameters["commoditySubType"]);
                lstCommodity.ItemsSource = commoditySubType.CommodityList;
            }
            txtDataUpdateTime.Text = m_viewmodel.UpdatedDate + " " + m_viewmodel.UpdatedTime;
        }

        private ViewModelMandi m_viewmodel;
    }
}