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
using System.IO;
using System.Collections.ObjectModel;

namespace MandiBazaar
{
    public class ViewModelMandi
    {
        public string UpdatedDate { get; set; }
        public string UpdatedTime { get; set; }
        public Action RefreshUIAction;
        public void LoadData()
        {
            //Read market reported date and time
            // if row has #C9BAFE background color than it is a commodityType
            // when td in a row has brown font color then it is a commodity sub type
            WebClient client = new WebClient();
            client.Headers["user-agent"] = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)";
            client.Headers["Accept-Language"] = "en-IN";
            client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);
            client.DownloadStringAsync(new Uri("http://agmarknet.nic.in/rep1Newx1_today.asp"));
        }
        public ObservableCollection<ViewModelCommodityType> CommodityTypeList { get; set; }

        private void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (!e.Result.Contains("All India Level Price Range"))
                return;
            CommodityTypeList = new ObservableCollection<ViewModelCommodityType>();
            ViewModelCommodityType currentCommodityType = null;
            ViewModelCommoditySubType currentCommoditySubType = null;
            ViewModelCommodity currentCommodity = null;
            var result = e.Result;
            // find date
            var nBrownColorIndex = result.IndexOf("#A52A2A");
            // skip first one. It is arrivals.
            result = result.Substring(nBrownColorIndex + 7);
            nBrownColorIndex = result.IndexOf("#A52A2A");
            result = result.Substring(nBrownColorIndex);
            int nDateStart = result.IndexOf(">");
            result = result.Substring(nDateStart + 1);
            int nDateEnd = result.IndexOf("</font>");
            this.UpdatedDate = result.Substring(0, nDateEnd);
            var nTimeStartIndex = result.IndexOf("(");
            var nTimeEndIndex = result.IndexOf(")");
            string strTime = result.Substring(nTimeStartIndex + 1, nTimeEndIndex - nTimeStartIndex - 1);
            strTime = strTime.Replace("&nbsp;", "");
            strTime = strTime.Replace("till", "");
            this.UpdatedTime = strTime;
            result = result.Substring(nTimeEndIndex + 1);
            int nMinIndex = result.IndexOf("Min");
            result = result.Substring(nMinIndex);
            int nRowEndIndex = 0;
            int nRowStartIndex = 0;
            while (nRowEndIndex >= 0)
            {
                nRowStartIndex = result.IndexOf("<a href=\"http://agmarknet.nic.in/");
                //if(nRowStartIndex == -1)
                //   nRowStartIndex = result.IndexOf("<tr >");
                result = result.Substring(nRowStartIndex);
                nRowEndIndex = result.IndexOf("</tr>");
                var row = result.Substring(0, nRowEndIndex);
                if (row.Contains("#C9BAFE"))
                {
                    // commodity type
                    int nStartIndex = row.IndexOf("<b>");
                    int nEndIndex = row.IndexOf("</b>");
                    //if(currentCommodityType != null)                    
                    currentCommodityType = new ViewModelCommodityType(row.Substring(nStartIndex + 3, nEndIndex - nStartIndex - 3));
                    CommodityTypeList.Add(currentCommodityType);
                }
                else if (row.Contains("color=\"brown\""))
                {
                    // sub commodity type
                    int nStartIndex = row.IndexOf("<strong>");
                    int nEndIndex = row.IndexOf("</strong>");
                    //if (currentCommoditySubType != null)                      
                    currentCommoditySubType = new ViewModelCommoditySubType(row.Substring(nStartIndex + 8, nEndIndex - nStartIndex - 8),currentCommodityType);
                      currentCommodityType.CommoditySubTypeList.Add(currentCommoditySubType);
                    row = row.Substring(nEndIndex + 9);
                    nStartIndex = row.IndexOf("<strong>");
                    if (nStartIndex > 0)
                    {
                        nEndIndex = row.IndexOf("</strong>");
                        currentCommoditySubType.MSP = row.Substring(nStartIndex + 8, nEndIndex - nStartIndex - 8);
                    }
                }
                else
                {
                    // commodity
                    int nNameStartIndex = row.IndexOf("#000080");
                    row = row.Substring(nNameStartIndex + 9);
                    // need to flush first #80
                    nNameStartIndex = row.IndexOf("#000080");
                    row = row.Substring(nNameStartIndex + 9);
                    int nNameEndIndex = row.IndexOf("</font>");                    
                    string commdityName = row.Substring(0, nNameEndIndex);

                    row = row.Substring(nNameEndIndex);
                    int nMarketNameStartIndex = row.IndexOf("title");
                    row = row.Substring(nMarketNameStartIndex + 7);
                    int nMarketNameEndIndex = row.IndexOf(">");
                    string strMaxMarketName = row.Substring(0, nMarketNameEndIndex - 2);

                    int nMarketPriceStartIndex = row.IndexOf("<right>");
                    int nMarketPriceEndIndex = row.IndexOf("</right>");
                    string strMaxMarketPrice = row.Substring(nMarketPriceStartIndex + 7, (nMarketPriceEndIndex - nMarketPriceStartIndex) - 7);
                    strMaxMarketPrice = strMaxMarketPrice.Trim();

                    row = row.Substring(nMarketPriceEndIndex);
                    nMarketNameStartIndex = row.IndexOf("title");
                    row = row.Substring(nMarketNameStartIndex + 7);
                    nMarketNameEndIndex = row.IndexOf(">");
                    string strMinMarketName = row.Substring(0, nMarketNameEndIndex - 2);

                    nMarketPriceStartIndex = row.IndexOf("<right>");
                    nMarketPriceEndIndex = row.IndexOf("</right>");
                    string strMinMarketPrice = row.Substring(nMarketPriceStartIndex + 7, (nMarketPriceEndIndex - nMarketPriceStartIndex) - 7);
                    strMinMarketPrice = strMinMarketPrice.Trim();                        

                    currentCommodity = new ViewModelCommodity(commdityName, strMaxMarketPrice, strMinMarketPrice, currentCommoditySubType, strMaxMarketName, strMinMarketName);
                    currentCommoditySubType.CommodityList.Add(currentCommodity);
                }
                result = result.Substring(nRowEndIndex + 5);
                nRowEndIndex = result.IndexOf("</tr>");
            }
            RefreshUIAction();      
        }
    }
    public class ViewModelCommodityType
    {
        public ViewModelCommodityType(string typeName)
        {
            TypeName = typeName;
            CommoditySubTypeList = new ObservableCollection<ViewModelCommoditySubType>();
        }
        public string TypeName { get; set; }
        public ObservableCollection<ViewModelCommoditySubType> CommoditySubTypeList { get; set; }        
    }
    public class ViewModelCommoditySubType
    {
        public ViewModelCommoditySubType(string subTypeName, ViewModelCommodityType parentType)
        {
            SubTypeName = subTypeName;
            ParentType = parentType;
            CommodityList = new ObservableCollection<ViewModelCommodity>();
        }
        public string SubTypeName { get; set; }
        public ObservableCollection<ViewModelCommodity> CommodityList { get; set; }
        public string MSP { get; set; }
        public ViewModelCommodityType ParentType { get; set; }
    }
    public class ViewModelCommodity
    {
        public ViewModelCommodity(string strCommodityName, string strMax, string strMin, ViewModelCommoditySubType parentSubType, string strMaxPriceMarketName = "", string strMinPriceMarketName = "")
        {
            CommodityName = strCommodityName;
            Max = strMax;
            Min = strMin;
            ParentTSubype = parentSubType;
            MaxPriceMarketName = strMaxPriceMarketName;
            MinPriceMarketName = strMinPriceMarketName;
        }
        public string CommodityName { get; set; }
        public string Max { get; set; }
        public string Min { get; set; }
        public string MaxPriceMarketName { get; set; }
        public string MinPriceMarketName { get; set; }
        public ViewModelCommoditySubType ParentTSubype { get; set; }
    }
    
}
