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
    public partial class SubTypeDetails : PhoneApplicationPage
    {
        public SubTypeDetails()
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

                int nMaxCount = commodityType.CommoditySubTypeList.Count;
                nMaxCount = nMaxCount > 16 ? 16 : nMaxCount;
                var nCalculatedCount = nMaxCount / 2;
                var nCheck = nMaxCount % 2;

                ContentPanel.RowDefinitions.Clear();
                for (int i = 0; i < (nCalculatedCount + nCheck); i++)
                {
                    ContentPanel.RowDefinitions.Add(new RowDefinition());
                }

                int nColumnCounter = 0;
                int nRowCounter = 0;
                ContentPanel.Children.Clear();
                foreach (var commoditySubType in commodityType.CommoditySubTypeList)
                {
                    Button button = new Button();
                    button.MinHeight = 70;
                    button.MaxHeight = 140;
                    button.DataContext = commoditySubType;
                    button.Click += new RoutedEventHandler(button_Click);
                    button.Content = commoditySubType.SubTypeName;
                    ContentPanel.Children.Add(button);
                    Grid.SetColumn(button, nColumnCounter);
                    Grid.SetRow(button, nRowCounter);

                    if (nRowCounter % 2 == 0)
                        button.Background = new SolidColorBrush(Colors.Green);
                    else
                        button.Background = new SolidColorBrush(Colors.Orange);

                    if (nColumnCounter == 1)
                    {
                        nRowCounter = nRowCounter + 1;
                        nColumnCounter = 0;
                    }
                    else
                        nColumnCounter += 1;
                    if (nRowCounter == 8)
                        break;
                }
            }
            txtDataUpdateTime.Text = m_viewmodel.UpdatedDate + " " + m_viewmodel.UpdatedTime;
            base.OnNavigatedTo(e);
        }

        void button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/CommodityList.xaml?commoditySubType=" + ((Button)sender).Content.ToString() + "&commodityType=" + ((ViewModelCommoditySubType)((Button)sender).DataContext).ParentType.TypeName, UriKind.Relative));
        }

        private ViewModelMandi m_viewmodel;
    }
}