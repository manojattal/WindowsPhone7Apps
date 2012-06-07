using System.Collections.ObjectModel;
using System.ComponentModel;
using System;

namespace IndianCalendar2012App
{
    public class ViewModelMonth : INotifyPropertyChanged
    {
        #region  Constructor
        public ViewModelMonth(int nMonthID)
        {
            LoadViewModel(nMonthID);
        }
        #endregion

        #region Public Member Functions
        public string MonthName 
        {
            get
            {
                return m_strMonthName;
            }
            set
            {
                m_strMonthName = value;
                this.NotifyPropertyChanged("MonthName");
            }
        }
        public int MonthID { get; set; }
        public string HinduMonthName
        {
            get
            {
                return m_strHinduMonthName;
            }
            set
            {
                m_strHinduMonthName = value;
                this.NotifyPropertyChanged("HinduMonthName");
            }
        }        
        public bool IsBackEnabled 
        {
            get
            {
                return m_bIsBackEnabled;
            }
            set
            {
                m_bIsBackEnabled = value;
                this.NotifyPropertyChanged("IsBackEnabled");
            }
        }
        public bool IsForwardEnabled 
        {
            get
            {
                return m_bIsForwardEnabled;
            }
            set
            {
                m_bIsForwardEnabled = value;
                this.NotifyPropertyChanged("IsForwardEnabled");
            }
        }
        public ObservableCollection<ViewModelDate> DateColl { get; set; }
        public void LoadViewModel(int nMonthID)
        {
            MonthID = nMonthID;
            switch (MonthID)
            {
                case 1:
                    MonthName = "January 2012";                    
                    HinduMonthName = "Paush / Magh 1933";
                    IsBackEnabled = false;
                    IsForwardEnabled = true;
                    m_nMaxMonthDate = 31;
                    m_nInitialRowPosition = -1;
                    m_nInitialTithiValue = 7;
                    m_nInitialPaksha = PakshaEnum.Shukla;
                    break;

                case 2:
                    MonthName = "February 2012";
                    HinduMonthName = "Magh / Falgun 1933";
                    IsBackEnabled = true;
                    IsForwardEnabled = true;
                    m_nMaxMonthDate = 29;
                    m_nInitialTithiValue = 8;
                    m_nInitialRowPosition = 2;
                    m_nInitialPaksha = PakshaEnum.Shukla;
                    break;

                case 3:
                    MonthName = "March 2012";
                    HinduMonthName = "Falgun 1933 / Chaitra 1934";
                    IsBackEnabled = true;
                    IsForwardEnabled = true;
                    m_nMaxMonthDate = 31;
                    m_nInitialTithiValue = 7;
                    m_nInitialRowPosition = 3;
                    m_nInitialPaksha = PakshaEnum.Shukla;
                    break;

                case 4:
                    MonthName = "April 2012";
                    HinduMonthName = "Chaitra / Vaishakh 1934";
                    IsBackEnabled = true;
                    IsForwardEnabled = true;
                    m_nMaxMonthDate = 30;
                    m_nInitialTithiValue = 8;
                    m_nInitialRowPosition = -1;
                    m_nInitialPaksha = PakshaEnum.Shukla;
                    break;

                case 5:
                    MonthName = "May 2012";
                    HinduMonthName = "Vaishakh / Jaishtha 1934";
                    IsBackEnabled = true;
                    IsForwardEnabled = true;
                    m_nMaxMonthDate = 31;
                    m_nInitialTithiValue = 9;
                    m_nInitialRowPosition = 1;
                    m_nInitialPaksha = PakshaEnum.Shukla;
                    break;

                case 6:
                    MonthName = "June 2012";
                    HinduMonthName = "Jaishtha / Aashadh 1934";
                    IsBackEnabled = true;
                    IsForwardEnabled = true;
                    m_nMaxMonthDate = 30;
                    m_nInitialTithiValue = 10;
                    m_nInitialRowPosition = 4;
                    m_nInitialPaksha = PakshaEnum.Shukla;
                    break;

                case 7:
                    MonthName = "July 2012";
                    HinduMonthName = "Aashadh / Shravan 1934";
                    IsBackEnabled = true;
                    IsForwardEnabled = true;
                    m_nMaxMonthDate = 31;
                    m_nInitialTithiValue = 11;
                    m_nInitialRowPosition = -1;
                    m_nInitialPaksha = PakshaEnum.Shukla;
                    break;

                case 8:
                    MonthName = "August 2012";
                    HinduMonthName = "Shravan / A. Bhadra 1934";
                    IsBackEnabled = true;
                    IsForwardEnabled = true;
                    m_nMaxMonthDate = 31;
                    m_nInitialTithiValue = 13;
                    m_nInitialRowPosition = 2;
                    m_nInitialPaksha = PakshaEnum.Shukla;
                    break;

                case 9:
                    MonthName = "September 2012";
                    HinduMonthName = "A. Bhadra / Ni. Bhadra 1934";
                    IsBackEnabled = true;
                    IsForwardEnabled = true;
                    m_nMaxMonthDate = 30;
                    m_nInitialTithiValue = 0;                    
                    m_nInitialRowPosition = 5;
                    m_nInitialPaksha = PakshaEnum.Krushna;
                    break;

                case 10:
                    MonthName = "October 2012";
                    HinduMonthName = "Ni. Bhadra / Aashwin 1934";
                    IsBackEnabled = true;
                    IsForwardEnabled = true;
                    m_nMaxMonthDate = 31;
                    m_nInitialTithiValue = 0;
                    m_nInitialRowPosition = 0;
                    m_nInitialPaksha = PakshaEnum.Krushna;
                    break;

                case 11:
                    MonthName = "November 2012";
                    HinduMonthName = "Aashwin / Kartik 1934";
                    IsBackEnabled = true;
                    IsForwardEnabled = true;
                    m_nMaxMonthDate = 30;
                    m_nInitialTithiValue = 2;
                    m_nInitialRowPosition = 3;
                    m_nInitialPaksha = PakshaEnum.Krushna;
                    break;

                case 12:
                    MonthName = "December 2012";
                    HinduMonthName = "Kartik / Marghashirsha 1934";
                    IsBackEnabled = true;
                    IsForwardEnabled = false;
                    m_nMaxMonthDate = 31;
                    m_nInitialTithiValue = 2;
                    m_nInitialRowPosition = 5;
                    m_nInitialPaksha = PakshaEnum.Krushna;
                    break;
            }
            LoadMonthViewModelDetails();
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

        #region Private Member Functions
        private void LoadMonthViewModelDetails()
        {
            DateColl = new ObservableCollection<ViewModelDate>();
            int nTithiValue = m_nInitialTithiValue;
            int nRowPosition = m_nInitialRowPosition;
            int nColumnPosition = 1;
            PakshaEnum pakshaValue = m_nInitialPaksha;
            string strTithiMonth = string.Empty;
            string strTithiString = string.Empty;
            bool bSkipTithiReset = false;
            for (int i = 1; i <= m_nMaxMonthDate; i++)
            {
                bool bSpecialTithiHandling = false;
                string strDesc = string.Empty;
                if (nRowPosition + 1 > 6)
                {
                    nRowPosition = -1;
                    if (nColumnPosition + 1 == 6)
                        nColumnPosition = 0;
                    nColumnPosition += 1;
                }

                nRowPosition = nRowPosition + 1;
                if (nTithiValue + 1 == 16 && !bSkipTithiReset)
                {
                    nTithiValue = 0;
                    if (m_nInitialPaksha == PakshaEnum.Krushna)
                        m_nInitialPaksha = PakshaEnum.Shukla;
                    else
                        m_nInitialPaksha = PakshaEnum.Krushna;
                    if (MonthID == 9 && i == 17)
                    {
                        nTithiValue = nTithiValue + 2;
                        strTithiString = nTithiValue.ToString();
                        bSpecialTithiHandling = true;
                    }
                    else if (MonthID == 12 && i == 14)
                    {
                        strTithiString = "1 / 2";
                        bSpecialTithiHandling = true;
                        nTithiValue = 2;
                    }

                }
                else
                {
                    if (MonthID == 1 && i == 5)
                        bSpecialTithiHandling = true;
                    else if (MonthID == 1 && i == 14)
                    {
                        strTithiString = "5 / 6";
                        bSpecialTithiHandling = true;
                        nTithiValue = 6;
                    }
                    else if (MonthID == 2 && i == 16)
                    {
                        strTithiString = "9 / 10";
                        bSpecialTithiHandling = true;
                        nTithiValue = 10;
                    }
                    else if (MonthID == 2 && i == 25)
                        bSpecialTithiHandling = true;
                    else if (MonthID == 3 && i == 10)
                    {
                        strTithiString = "2 / 3";
                        bSpecialTithiHandling = true;
                        nTithiValue = 3;
                    }
                    else if (MonthID == 3 && i == 28)
                        bSpecialTithiHandling = true;
                    else if (MonthID == 3 && i == 31)
                        bSpecialTithiHandling = true;
                    else if (MonthID == 4 && i == 5)
                    {
                        strTithiString = "13 / 14";
                        bSpecialTithiHandling = true;
                        nTithiValue = 14;
                    }
                    else if (MonthID == 4 && i == 11)
                    {
                        strTithiString = "5 / 6";
                        bSpecialTithiHandling = true;
                        nTithiValue = 6;
                    }
                    else if (MonthID == 4 && i == 18)
                        bSpecialTithiHandling = true;
                    else if (MonthID == 5 && i == 22)
                        bSpecialTithiHandling = true;
                    else if (MonthID == 6 && i == 1)
                    {
                        strTithiString = "11 / 12";
                        bSpecialTithiHandling = true;
                        nTithiValue = 12;
                    }
                    else if (MonthID == 6 && i == 7)
                    {
                        strTithiString = "3 / 4";
                        bSpecialTithiHandling = true;
                        nTithiValue = 4;
                    }
                    else if (MonthID == 6 && i == 13)
                        bSpecialTithiHandling = true;
                    else if (MonthID == 7 && i == 2)
                    {
                        strTithiString = "13 / 14";
                        bSpecialTithiHandling = true;
                        nTithiValue = 14;
                    }
                    else if (MonthID == 7 && i == 18)
                        bSkipTithiReset = true;
                    else if (MonthID == 7 && i == 19)
                    {
                        bSkipTithiReset = false;
                        bSpecialTithiHandling = true;
                    }
                    else if (MonthID == 7 && i == 24)
                    {
                        strTithiString = "5 / 6";
                        bSpecialTithiHandling = true;
                        nTithiValue = 6;
                    }
                    else if (MonthID == 8 && i == 5)
                    {
                        nTithiValue = nTithiValue + 2;
                        strTithiString = nTithiValue.ToString();
                        bSpecialTithiHandling = true;
                    }
                    else if (MonthID == 8 && i == 7)
                        bSpecialTithiHandling = true;
                    else if (MonthID == 8 && i == 20)
                        bSpecialTithiHandling = true;
                    else if (MonthID == 8 && i == 24)
                    {
                        strTithiString = "7 / 8";
                        bSpecialTithiHandling = true;
                        nTithiValue = 8;
                    }
                    else if (MonthID == 9 && i == 9)
                        bSpecialTithiHandling = true;
                    else if (MonthID == 10 && i == 18)
                    {
                        strTithiString = "3 / 4";
                        bSpecialTithiHandling = true;
                        nTithiValue = 4;
                    }
                    else if (MonthID == 11 && i == 2)
                        bSpecialTithiHandling = true;
                    else if (MonthID == 12 && i == 4)
                        bSpecialTithiHandling = true;
                    else if (MonthID == 12 && i == 8)
                    {
                        strTithiString = "9 / 10";
                        bSpecialTithiHandling = true;
                        nTithiValue = 10;
                    }
                    else if (MonthID == 12 && i == 25)
                        bSpecialTithiHandling = true;
                }
                if (bSpecialTithiHandling == false)
                {
                    nTithiValue = nTithiValue + 1;
                    strTithiString = nTithiValue.ToString();
                }
                if (MonthID == 1 && i == 26)
                    strDesc = "Ganrajya Din, Ganesh Jaynti";
                //else if (MonthID == 1 && i == 11)
                //    strDesc = "Guru Govindsinh Jayanti";
                //else if (MonthID == 1 && i == 12)
                //    strDesc = "Swami Vivekanand Jaynati";
                else if (MonthID == 1 && i == 15)
                    strDesc = "Makarsankranti";
                else if (MonthID == 1 && i == 23)
                    strDesc = "Somavati Amavasya" + Environment.NewLine + "Netaji Subhash Jayanti";
                else if (MonthID == 1 && i == 30)
                    strDesc = "Mahatma Gandhi Punyatithi";
                else if (MonthID == 1 && i == 5)
                    strDesc = "Putrada Ekadashi";
                else if (MonthID == 1 && i == 6)
                    strDesc = "Pradosh";
                else if (MonthID == 1 && i == 9)
                    strDesc = "Paush Shakambhari Pornima";
                else if (MonthID == 1 && i == 12)
                    strDesc = "Sankashta Chaturthi";
                else if (MonthID == 1 && i == 14)
                    strDesc = "Bhogi";
                else if (MonthID == 1 && i == 16)
                    strDesc = "Kalashtami";
                else if (MonthID == 1 && i == 19)
                    strDesc = "Shatatila Ekadashi";
                else if (MonthID == 1 && i == 20)
                    strDesc = "Pradosh";
                else if (MonthID == 1 && i == 22)
                    strDesc = "Darsha Amavasya";
                else if (MonthID == 1 && i == 25)
                    strDesc = "Muslim Rabilal Samarambh";
                else if (MonthID == 1 && i == 30)
                    strDesc = "Hutatma Din";
                else if (MonthID == 1 && i == 31)
                    strDesc = "Durgashtami";
                else if (MonthID == 2 && i == 3)
                    strDesc = "Jaya Ekadashi";
                else if (MonthID == 2 && i == 4)
                    strDesc = "Bhima Dwadashi";
                else if (MonthID == 2 && i == 5)
                    strDesc = "Ed A Milad";
                else if (MonthID == 2 && i == 7)
                    strDesc = "Magh Pornima";
                else if (MonthID == 2 && i == 8)
                    strDesc = "Guru Pratipada";
                else if (MonthID == 2 && i == 10)
                    strDesc = "Sankashta Chaturthi";
                else if (MonthID == 2 && i == 16)
                    strDesc = "Ramdas Navami";
                else if (MonthID == 2 && i == 17)
                    strDesc = "Vijaya Smart Ekadashi";
                else if (MonthID == 2 && i == 18)
                    strDesc = "Bhagawat Ekadashi";
                else if (MonthID == 2 && i == 19)
                    strDesc = "Shivaji Maharaj Jayanti(By Date)";
                else if (MonthID == 2 && i == 20)
                    strDesc = "Mahashivaratri";
                else if (MonthID == 2 && i == 24)
                    strDesc = "Jagatik Mudrak Din";
                else if (MonthID == 2 && i == 21)
                    strDesc = "Maagh Amavasya";
                else if (MonthID == 2 && i == 28)
                    strDesc = "Rashtriya Vinyan Din";
                else if (MonthID == 3 && i == 1)
                    strDesc = "Durgashtami";
                else if (MonthID == 3 && i == 4)
                    strDesc = "Aamalaki Ekadashi";
                else if (MonthID == 3 && i == 6)
                    strDesc = "BhimPradosh";
                else if (MonthID == 3 && i == 7)
                    strDesc = "Holi";
                else if (MonthID == 3 && i == 8)
                    strDesc = "Dhulivandan";
                else if (MonthID == 3 && i == 10)
                    strDesc = "Shivaji Maharaj Jayanti(By Tithi)";
                else if (MonthID == 3 && i == 11)
                    strDesc = "Sankashta Chaturthi";
                else if (MonthID == 3 && i == 12)
                    strDesc = "Rang Panchami";
                else if (MonthID == 3 && i == 13)
                    strDesc = "Shri Eknath Shashthi";
                else if (MonthID == 3 && i == 15)
                    strDesc = "Jagatik Grahak Din";
                else if (MonthID == 3 && i == 18)
                    strDesc = "Papamochani Ekadashi";
                else if (MonthID == 3 && i == 19)
                    strDesc = "Sompradosh";
                else if (MonthID == 3 && i == 22)
                    strDesc = "Falgun Amavasya";
                else if (MonthID == 3 && i == 23)
                    strDesc = "Gudhipadawa";
                else if (MonthID == 3 && i == 25)
                    strDesc = "Gauri Trutiya";
                else if (MonthID == 4 && i == 1)
                    strDesc = "Ramnavami";
                else if (MonthID == 4 && i == 3)
                    strDesc = "Kamada Ekadashi";
                else if (MonthID == 4 && i == 4)
                    strDesc = "Pradosh";
                else if (MonthID == 4 && i == 5)
                    strDesc = "Mahavir Jayanti";
                else if (MonthID == 4 && i == 6)
                    strDesc = "Hanuman Jayanti";// + Environment.NewLine + "Good Friday";
                else if (MonthID == 4 && i == 7)
                    strDesc = "Jagatik Aarogya Din";
                else if (MonthID == 4 && i == 8)
                    strDesc = "Easter Day";
                else if (MonthID == 4 && i == 9)
                    strDesc = "Sankashta Chaturthi";
                else if (MonthID == 4 && i == 14)
                    strDesc = "Dr. Ambedkar Jayanti";
                else if (MonthID == 4 && i == 17)
                    strDesc = "Bhagwat Ekadashi";
                else if (MonthID == 4 && i == 18)
                    strDesc = "Pradosh";
                else if (MonthID == 4 && i == 21)
                    strDesc = "Chaitra Amavasya";
                else if (MonthID == 4 && i == 24)
                    strDesc = "Akshaya Trutiya";
                else if (MonthID == 5 && i == 1)
                    strDesc = "Kamagar Din";// + Environment.NewLine + "Maharashtra Din";
                else if (MonthID == 5 && i == 2)
                    strDesc = "Mohini Ekadashi";
                else if (MonthID == 5 && i == 3)
                    strDesc = "Pradosh";
                else if (MonthID == 5 && i == 6)
                    strDesc = "Buddha Pornima";
                else if (MonthID == 5 && i == 9)
                    strDesc = "Sankashta Chaturthi";
                else if (MonthID == 5 && i == 16)
                    strDesc = "Apara Ekadashi";
                else if (MonthID == 5 && i == 20)
                    strDesc = /* "Vaishakh Amavasya" + Environment.NewLine +*/ "Shanaishwar Jayanti";
                else if (MonthID == 5 && i == 28)
                    strDesc = "Savarkar Jayanti";
                else if (MonthID == 6 && i == 1)
                    strDesc = "Bhagavat Ekadashi";// + Environment.NewLine + "Sambhaji Maharaj Jayanti";
                else if (MonthID == 6 && i == 4)
                    strDesc = "Vat Pornima";
                else if (MonthID == 6 && i == 5)
                    strDesc = "Jagatik Paryavaran Din";
                else if (MonthID == 6 && i == 7)
                    strDesc = "Sankashta Chaturthi";
                else if (MonthID == 6 && i == 15)
                    strDesc = "Yogini Ekadashi";
                else if (MonthID == 6 && i == 19)
                    strDesc = "Jaishtha Amavasya";
                else if (MonthID == 6 && i == 21)
                    strDesc = "Gurupushyamrut";
                else if (MonthID == 6 && i == 30)
                    strDesc = "Aashadhi Ekadashi";
                else if (MonthID == 7 && i == 1)
                    strDesc = "Pradosh";
                else if (MonthID == 7 && i == 3)
                    strDesc = "Guru Pornima";
                else if (MonthID == 7 && i == 6)
                    strDesc = "Sankashta Chaturthi";
                else if (MonthID == 7 && i == 11)
                    strDesc = "Vishwa Jansankhya Din";
                else if (MonthID == 7 && i == 13)
                    strDesc = "Sant Eknath Maraj Punyatithi";
                else if (MonthID == 7 && i == 14)
                    strDesc = "Kamika Ekadashi";
                else if (MonthID == 7 && i == 19)
                    strDesc = /*"Aashadh Amavasya" + Environment.NewLine +*/ "Gurupushyamrut Yog";
                else if (MonthID == 7 && i == 23)
                    strDesc = "Nagpanchami";
                else if (MonthID == 7 && i == 29)
                    strDesc = "Putrada Ekadashi";
                else if (MonthID == 8 && i == 1)
                    strDesc = "Narali Pornima";
                else if (MonthID == 8 && i == 2)
                    strDesc = /*"Shravan Pornima" + Environment.NewLine +*/ "Rakshabandhan";
                else if (MonthID == 8 && i == 5)
                    strDesc = "Sankashta Chaturthi";
                else if (MonthID == 8 && i == 9)
                    strDesc = "Shrikrishna Jayanti";
                else if (MonthID == 8 && i == 10)
                    strDesc = "Gopal Kala";
                else if (MonthID == 8 && i == 13)
                    strDesc = "Ajaa Ekadashi";
                else if (MonthID == 8 && i == 15)
                    strDesc = "Swantatrya Din";
                else if (MonthID == 8 && i == 16)
                    strDesc = "Gurupushyamrut Yog";
                else if (MonthID == 8 && i == 17)
                    strDesc = /*"Shravan Amavasya" + Environment.NewLine +*/ "Pola";
                else if (MonthID == 8 && i == 18)
                    strDesc = "Pateti";
                else if (MonthID == 8 && i == 20)
                    strDesc = "Ramjan Eid";
                else if (MonthID == 8 && i == 27)
                    strDesc = "Kamala Ekadashi";
                else if (MonthID == 8 && i == 31)
                    strDesc = "A. Bhadra Pornima";
                else if (MonthID == 9 && i == 4)
                    strDesc = "Angarak Sankashta Chaturthi";
                else if (MonthID == 9 && i == 5)
                    strDesc = "Shikshaka Din";
                else if (MonthID == 9 && i == 12)
                    strDesc = "Kamala Ekadashi";
                else if (MonthID == 9 && i == 13)
                    strDesc = "Pradosh";
                else if (MonthID == 9 && i == 18)
                    strDesc = "HariTalika Trutiya";
                else if (MonthID == 9 && i == 19)
                    strDesc = "Ganesha Chaturthi";
                else if (MonthID == 9 && i == 20)
                    strDesc = "Rushi Panchami";
                else if (MonthID == 9 && i == 21)
                    strDesc = "Jaishtha Gauri Aavahan";
                else if (MonthID == 9 && i == 22)
                    strDesc = "Jaishtha Gauri Pujan";
                else if (MonthID == 9 && i == 23)
                    strDesc = "Jaishtha Gauri Visarjan";
                else if (MonthID == 9 && i == 26)
                    strDesc = "Parivartini Ekadashi";
                else if (MonthID == 9 && i == 27)
                    strDesc = "Pradosh";
                else if (MonthID == 9 && i == 29)
                    strDesc = "Anant Chaturdashi";
                else if (MonthID == 10 && i == 2)
                    strDesc = "Mahatma Gandhi Jayanti";
                else if (MonthID == 10 && i == 3)
                    strDesc = "Sankashta Chaturthi";
                else if (MonthID == 10 && i == 11)
                    strDesc = "Indira Ekadashi";
                else if (MonthID == 10 && i == 13)
                    strDesc = "Shanipradosh";
                else if (MonthID == 10 && i == 15)
                    strDesc = "Sarvapitri Amavasya";
                else if (MonthID == 10 && i == 16)
                    strDesc = "Ghatsthapana";
                else if (MonthID == 10 && i == 24)
                    strDesc = "Dasara";
                else if (MonthID == 10 && i == 25)
                    strDesc = "Pashankusha Ekadashi";
                else if (MonthID == 10 && i == 26)
                    strDesc = "Bakari Eid";
                else if (MonthID == 10 && i == 29)
                    strDesc = "Kojagiri Pornima";
                else if (MonthID == 11 && i == 2)
                    strDesc = "Sankashta Chaturthi";
                else if (MonthID == 11 && i == 10)
                    strDesc = /*"Rama Ekadashi" + Environment.NewLine + */"Basubaras";
                else if (MonthID == 11 && i == 11)
                    strDesc = "Dhan Trayodashi";
                else if (MonthID == 11 && i == 13)
                    strDesc = /*"Narak Chaturdashi" + Environment.NewLine +*/ "LakshmiPujan";
                else if (MonthID == 11 && i == 14)
                    strDesc = "Deepavali Padava";
                else if (MonthID == 11 && i == 15)
                    strDesc = "Bhaubeej";
                else if (MonthID == 11 && i == 24)
                    strDesc = "Prabodhini Ekadashi";
                else if (MonthID == 11 && i == 25)
                    strDesc = "Moharam";
                else if (MonthID == 11 && i == 28)
                    strDesc = /*"Kartik Pornima" + Environment.NewLine +*/ "Gurunanak Jayanti";
                else if (MonthID == 12 && i == 2)
                    strDesc = "Sankashta Chaturthi";
                else if (MonthID == 12 && i == 6)
                    strDesc = "Dr. Ambedkar Punyatithi";
                else if (MonthID == 12 && i == 10)
                    strDesc = "Bhagwat Ekadashi";
                else if (MonthID == 12 && i == 13)
                    strDesc = "Kartik Amavasya";
                else if (MonthID == 12 && i == 24)
                    strDesc = "Bhagwat Ekadashi";// + Environment.NewLine + "Bharatiya Grahak Din";
                else if (MonthID == 12 && i == 25)
                    strDesc = "Christmas";
                else if (MonthID == 12 && i == 27)
                    strDesc = "Shri Datta Jayanti";
                else if (MonthID == 12 && i == 28)
                    strDesc = "Margashirsh Pornima";
                if (MonthID == 1 && i <= 23)
                    strTithiMonth = "Paush";
                else if ((MonthID == 1 && i > 23) || (MonthID == 2 && i <= 21))
                    strTithiMonth = "Magh";
                else if (MonthID == 2 && i > 21 || (MonthID == 3 && i <= 22))
                    strTithiMonth = "Falgun";
                else if (MonthID == 3 && i > 22 || (MonthID == 4 && i <= 21))
                    strTithiMonth = "Chaitra";
                else if (MonthID == 4 && i > 21 || (MonthID == 5 && i <= 20))
                    strTithiMonth = "Vaishakh";
                else if (MonthID == 5 && i > 20 || (MonthID == 6 && i <= 19))
                    strTithiMonth = "Jaishtha";
                else if (MonthID == 6 && i > 19 || (MonthID == 7 && i <= 19))
                    strTithiMonth = "Aashadh";
                else if (MonthID == 7 && i > 19 || (MonthID == 8 && i <= 17))
                    strTithiMonth = "Shravan";
                else if (MonthID == 8 && i > 17 || (MonthID == 9 && i <= 16))
                    strTithiMonth = "A. Bhadra";
                else if (MonthID == 9 && i > 16 || (MonthID == 10 && i <= 15))
                    strTithiMonth = "N. Bhadra";
                else if (MonthID == 10 && i > 15 || (MonthID == 11 && i <= 13))
                    strTithiMonth = "Aashwin";
                else if (MonthID == 11 && i > 13 || (MonthID == 12 && i <= 13))
                    strTithiMonth = "Kartik";
                else if (MonthID == 12 && i > 13)
                    strTithiMonth = "Marga";
                var date = new ViewModelDate() { Date = i, ColumnPosition = nColumnPosition, RowPosition = nRowPosition, Tithi = strTithiString, Paksha = m_nInitialPaksha, DayDescription = strDesc, HindiMonth = strTithiMonth };
                if ((MonthID == 1 && i == 5) || (MonthID == 1 && i == 19) || (MonthID == 2 && i == 3) || (MonthID == 2 && i == 18) || (MonthID == 3 && i == 4) ||
                    (MonthID == 3 && i == 18) || (MonthID == 4 && i == 3) || (MonthID == 4 && i == 17) || (MonthID == 5 && i == 2) || (MonthID == 5 && i == 16) ||
                    (MonthID == 6 && i == 1) || (MonthID == 6 && i == 15) || (MonthID == 6 && i == 30) || (MonthID == 7 && i == 14) || (MonthID == 7 && i == 29) ||
                    (MonthID == 8 && i == 13) || (MonthID == 8 && i == 27) || (MonthID == 9 && i == 26) || (MonthID == 9 && i == 12) || (MonthID == 10 && i == 11) ||
                    (MonthID == 10 && i == 25) || (MonthID == 11 && i == 10) || (MonthID == 11 && i == 24) || (MonthID == 12 && i == 10) || (MonthID == 12 && i == 24))
                    date.IsEkadashi = true;
                else if ((MonthID == 1 && i == 9) || (MonthID == 2 && i == 7) || (MonthID == 3 && i == 7) || (MonthID == 4 && i == 6) || (MonthID == 5 && i == 6) ||
                    (MonthID == 6 && i == 4) || (MonthID == 7 && i == 3) || (MonthID == 8 && i == 2) || (MonthID == 9 && i == 30) || (MonthID == 10 && i == 29) ||
                    (MonthID == 11 && i == 28) || (MonthID == 12 && i == 28))
                    date.IsPornima = true;
                else if ((MonthID == 1 && i == 12) || (MonthID == 2 && i == 10) || (MonthID == 3 && i == 11) || (MonthID == 4 && i == 9) || (MonthID == 5 && i == 9) ||
                    (MonthID == 6 && i == 7) || (MonthID == 7 && i == 6) || (MonthID == 8 && i == 5) || (MonthID == 9 && i == 4) || (MonthID == 10 && i == 3) ||
                    (MonthID == 11 && i == 2) || (MonthID == 12 && i == 2))
                    date.IsSankashtaChaturthi = true;
                else if ((MonthID == 1 && i == 23) || (MonthID == 2 && i == 21) || (MonthID == 3 && i == 22) || (MonthID == 4 && i == 21) || (MonthID == 5 && i == 20) ||
                    (MonthID == 6 && i == 19) || (MonthID == 7 && i == 19) || (MonthID == 8 && i == 17) || (MonthID == 9 && i == 16) || (MonthID == 10 && i == 15) ||
                    (MonthID == 11 && i == 13) || (MonthID == 12 && i == 13))
                    date.IsAmavasya = true;
                if ((MonthID == 1 && i == 26) || (MonthID == 2 && i == 20) || (MonthID == 3 && i == 8) || (MonthID == 3 && i == 10) || (MonthID == 3 && i == 23) ||
                    (MonthID == 4 && i == 6) || (MonthID == 4 && i == 14) || (MonthID == 5 && i == 1) /*|| (MonthID == 5 && i == 29)*/ || (MonthID == 8 && i == 15) ||
                    (MonthID == 8 && i == 18) || (MonthID == 8 && i == 20) || (MonthID == 9 && i == 19) || (MonthID == 10 && i == 2) || (MonthID == 10 && i == 24) ||
                    (MonthID == 10 && i == 26) || (MonthID == 11 && i == 13) || (MonthID == 11 && i == 14) || (MonthID == 11 && i == 28) || (MonthID == 12 && i == 25))
                    date.IsHoliday = true;
                DateColl.Add(date);
                if (MonthID == 5 && i == 5)
                    nTithiValue = 15;
                else if (MonthID == 8 && i == 20)
                    nTithiValue = 3;
                else if (MonthID == 11 && i == 13)
                    nTithiValue = 15;
            }
        }
        #endregion

        #region Private Member Variables
        private int m_nMaxMonthDate;
        private int m_nInitialRowPosition;
        private string m_strMonthName;
        private string m_strHinduMonthName;
        //private string m_strExactMonthForDate;
        private bool m_bIsBackEnabled;
        private bool m_bIsForwardEnabled;
        private int m_nInitialTithiValue;
        private PakshaEnum m_nInitialPaksha;
        #endregion
    }

    public class ViewModelDate
    {
        public int Date { get; set; }
        public int ColumnPosition { get; set; }
        public int RowPosition { get; set; }
        public string Tithi { get; set; }
        public PakshaEnum Paksha { get; set; }
        public string DayDescription { get; set; }
        public string HindiMonth { get; set; }
        public bool IsEkadashi { get; set; }
        public bool IsSankashtaChaturthi { get; set; }
        public bool IsAmavasya { get; set; }
        public bool IsPornima { get; set; }
        public bool IsHoliday { get; set; }
    }

    public enum PakshaEnum
    {
        Shukla,
        Krushna
    }
}
