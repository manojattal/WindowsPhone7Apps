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
using System.ComponentModel;

namespace PinCodeIndia
{
    public class PinCodeViewModel : INotifyPropertyChanged
    {
        #region Constructor
        public PinCodeViewModel()
        {

        }
        #endregion

        #region Public Methods
        public long Pin 
        {
            get
            {
                return m_dPin;
            }
            set
            {
                m_dPin = value;
                NotifyPropertyChanged("Pin");
            }
        }
        public String Area
        {
            get
            {
                return m_strArea;
            }
            set
            {
                m_strArea = value;
                NotifyPropertyChanged("Area");
            }
        }
        public String City 
        {
            get
            {
                return m_strCity;
            }
            set
            {
                m_strCity = value;
                NotifyPropertyChanged("City");
            }
        }
        public String State
        {
            get
            {
                return m_strState;
            }
            set
            {
                m_strState = value;
                NotifyPropertyChanged("State");
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
        
        #region Private Memebr Variables
        private long m_dPin;
        private String m_strArea;
        private String m_strCity;
        private String m_strState;
        #endregion
    }
}
