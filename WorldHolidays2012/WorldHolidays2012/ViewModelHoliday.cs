using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WorldHolidays2012
{
    public class ViewModelHoliday : INotifyPropertyChanged
    {
        public ViewModelHoliday()
        {
            LoadCountries();
            m_lstholidays = new List<Holiday>();
        }
        public string SelectedCountry
        {
            get
            {
                return m_selectedCountry;
            }
            set
            {
                if (m_selectedCountry == value)
                    return;
                m_selectedCountry = value;
                ///LoadHolidaysForSelectedCountry();
            }
        }
        private void LoadCountries()
        {
            m_countriesList = new List<Country>();
            m_countriesList.Add(new Country() { CountryName = "Australia" });
            m_countriesList.Add(new Country() { CountryName = "Botswana" });
            m_countriesList.Add(new Country() { CountryName = "Greece"});
            m_countriesList.Add(new Country() { CountryName = "India"});
            m_countriesList.Add(new Country() { CountryName = "Indonesia"});
            m_countriesList.Add(new Country() { CountryName = "Kenya"});
            m_countriesList.Add(new Country() { CountryName = "Malaysia"});
            m_countriesList.Add(new Country() { CountryName = "Malta"});
            m_countriesList.Add(new Country() { CountryName = "Mauritius"});
            m_countriesList.Add(new Country() { CountryName = "Nepal"});
            m_countriesList.Add(new Country() { CountryName = "Saudi Arabia"});
            m_countriesList.Add(new Country() { CountryName = "Singapore"});
            m_countriesList.Add(new Country() { CountryName = "South Africa"});
            m_countriesList.Add(new Country() { CountryName = "Tanzania"});
            m_countriesList.Add(new Country() { CountryName = "Uganda"});
            m_countriesList.Add(new Country() { CountryName = "United Kingdom"});
            m_countriesList.Add(new Country() { CountryName = "United States"});
            m_countriesList.Add(new Country() { CountryName = "Zimbabwe" });
        }
        public void LoadHolidaysForSelectedCountry(string countryName)
        {
            this.HolidaysList.Clear();
            switch (countryName)
            {
                case "Australia":
                    m_lstholidays.Add(new Holiday() { Description = "New Year's Day", HolidayDate = new DateTime(2012, 1, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Australia Day", HolidayDate = new DateTime(2012, 1, 26) });
                    m_lstholidays.Add(new Holiday() { Description = "Good Friday", HolidayDate = new DateTime(2012, 4, 6) });
                    m_lstholidays.Add(new Holiday() { Description = "Holy Saturday", HolidayDate = new DateTime(2012, 4, 7) });
                    m_lstholidays.Add(new Holiday() { Description = "Easter Monday", HolidayDate = new DateTime(2012, 4, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "Anzac Day", HolidayDate = new DateTime(2012, 4, 25) });
                    m_lstholidays.Add(new Holiday() { Description = "Queen's Birthday", HolidayDate = new DateTime(2012, 6, 11) });
                    m_lstholidays.Add(new Holiday() { Description = "Queen's Birthday(WA)", HolidayDate = new DateTime(2012, 10, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) });                    
                    m_lstholidays.Add(new Holiday() { Description = "Boxing Day", HolidayDate = new DateTime(2012, 12, 26) });                    
                    break;
                case "Botswana":
                    m_lstholidays.Add(new Holiday() { Description = "New Year's Day", HolidayDate = new DateTime(2012, 1, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Good Friday", HolidayDate = new DateTime(2012, 4, 6) });
                    m_lstholidays.Add(new Holiday() { Description = "Easter Sunday", HolidayDate = new DateTime(2012, 4, 8) });
                    m_lstholidays.Add(new Holiday() { Description = "Easter Monday", HolidayDate = new DateTime(2012, 4, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "May Labour Day", HolidayDate = new DateTime(2012, 5, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Ascension of Jesus", HolidayDate = new DateTime(2012, 5, 17) });
                    m_lstholidays.Add(new Holiday() { Description = "Sir Seretse Khama Day", HolidayDate = new DateTime(2012, 7, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "President's Day", HolidayDate = new DateTime(2012, 7, 18) });
                    m_lstholidays.Add(new Holiday() { Description = "Botswana Day", HolidayDate = new DateTime(2012, 9, 30) });
                    m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) });                    
                    m_lstholidays.Add(new Holiday() { Description = "Boxing Day", HolidayDate = new DateTime(2012, 12, 26) });                    
                    break;
                case "Greece":
                    m_lstholidays.Add(new Holiday() { Description = "New Year's Day", HolidayDate = new DateTime(2012, 1, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Epiphany Day", HolidayDate = new DateTime(2012, 1, 6) });
                    m_lstholidays.Add(new Holiday() { Description = "Ash Monday", HolidayDate = new DateTime(2012, 2, 27) });
                    m_lstholidays.Add(new Holiday() { Description = "Greek Independence Day", HolidayDate = new DateTime(2012, 3, 25) });
                    m_lstholidays.Add(new Holiday() { Description = "Great and Holy Friday", HolidayDate = new DateTime(2012, 4, 13) });
                    m_lstholidays.Add(new Holiday() { Description = "Easter Sunday", HolidayDate = new DateTime(2012, 4, 15) });
                    m_lstholidays.Add(new Holiday() { Description = "Bright Monday", HolidayDate = new DateTime(2012, 4, 16) });
                    m_lstholidays.Add(new Holiday() { Description = "Labour Day", HolidayDate = new DateTime(2012, 5, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Holy Spi`rit Monday", HolidayDate = new DateTime(2012, 6, 4) });
                    m_lstholidays.Add(new Holiday() { Description = "The Dormition of Holy Virgin", HolidayDate = new DateTime(2012, 8, 15) });
                    m_lstholidays.Add(new Holiday() { Description = "Greek National Day", HolidayDate = new DateTime(2012, 10, 28) });
                    m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) });                    
                    m_lstholidays.Add(new Holiday() { Description = "Boxing Day", HolidayDate = new DateTime(2012, 12, 26) });                    
                    break;
                case "India":
                    m_lstholidays.Add(new Holiday() { Description = "Makar Sankranti", HolidayDate = new DateTime(2012, 1, 14) });
                    m_lstholidays.Add(new Holiday() { Description = "Republic Day", HolidayDate = new DateTime(2012, 1, 26) });
                    m_lstholidays.Add(new Holiday() { Description = "Id-a-Milad*", HolidayDate = new DateTime(2012, 2, 5) });
                    m_lstholidays.Add(new Holiday() { Description = "Maha Shivratri", HolidayDate = new DateTime(2012, 2, 20) });
                    m_lstholidays.Add(new Holiday() { Description = "Holi", HolidayDate = new DateTime(2012, 3, 7) });
                    m_lstholidays.Add(new Holiday() { Description = "Dulhandi", HolidayDate = new DateTime(2012, 3, 8) });
                    m_lstholidays.Add(new Holiday() { Description = "Ram Navami", HolidayDate = new DateTime(2012, 4, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Good Friday", HolidayDate = new DateTime(2012, 4, 6) });
                    m_lstholidays.Add(new Holiday() { Description = "Labour Day", HolidayDate = new DateTime(2012, 5, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Raksha Bandhan", HolidayDate = new DateTime(2012, 5, 2) });
                    m_lstholidays.Add(new Holiday() { Description = "Krishna Janmashtami", HolidayDate = new DateTime(2012, 8, 10) });
                    m_lstholidays.Add(new Holiday() { Description = "Independence Day", HolidayDate = new DateTime(2012, 8, 15) });
                    m_lstholidays.Add(new Holiday() { Description = "Id-Ul-Fitr", HolidayDate = new DateTime(2012, 8, 20) });
                    m_lstholidays.Add(new Holiday() { Description = "Gandhi Jayanti", HolidayDate = new DateTime(2012, 10, 2) });
                    m_lstholidays.Add(new Holiday() { Description = "Dushera", HolidayDate = new DateTime(2012, 10, 24) });
                    m_lstholidays.Add(new Holiday() { Description = "Id-Ul-Zuha", HolidayDate = new DateTime(2012, 10, 27) });
                    m_lstholidays.Add(new Holiday() { Description = "Deepawali", HolidayDate = new DateTime(2012, 11, 13) });
                    m_lstholidays.Add(new Holiday() { Description = "Muharram*", HolidayDate = new DateTime(2012, 11, 25) });
                    m_lstholidays.Add(new Holiday() { Description = "Guru Nanak Birthday", HolidayDate = new DateTime(2012, 11, 28) });
                    m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) }); 
                    break;
                case "Indonesia":
                    m_lstholidays.Add(new Holiday() { Description = "New Year's Day", HolidayDate = new DateTime(2012, 1, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Chinese New Year", HolidayDate = new DateTime(2012, 1, 23) });
                    m_lstholidays.Add(new Holiday() { Description = "The Prophet's Birthday*", HolidayDate = new DateTime(2012, 2, 4) });
                    m_lstholidays.Add(new Holiday() { Description = "Good Friday", HolidayDate = new DateTime(2012, 4, 6) });
                    m_lstholidays.Add(new Holiday() { Description = "Easter Monday", HolidayDate = new DateTime(2012, 4, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "Vesak Day*", HolidayDate = new DateTime(2012, 5, 6) });
                    m_lstholidays.Add(new Holiday() { Description = "Ascension Day", HolidayDate = new DateTime(2012, 5, 17) });
                    m_lstholidays.Add(new Holiday() { Description = "The Prophet's Ascension*", HolidayDate = new DateTime(2012, 6, 16) });
                    m_lstholidays.Add(new Holiday() { Description = "Independence Day", HolidayDate = new DateTime(2012, 8, 17) });
                    m_lstholidays.Add(new Holiday() { Description = "Id Ul Fitr*", HolidayDate = new DateTime(2012, 8, 19) });
                    m_lstholidays.Add(new Holiday() { Description = "Id Ul Adha*", HolidayDate = new DateTime(2012, 10, 26) });
                    m_lstholidays.Add(new Holiday() { Description = "First Day of Muharram*", HolidayDate = new DateTime(2012, 11, 15) });
                    m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) });                     
                    break;
                case "Kenya":
                    m_lstholidays.Add(new Holiday() { Description = "New Year's Day", HolidayDate = new DateTime(2012, 1, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Good Friday", HolidayDate = new DateTime(2012, 4, 6) });                    
                    m_lstholidays.Add(new Holiday() { Description = "Easter Monday", HolidayDate = new DateTime(2012, 4, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "Labour Day", HolidayDate = new DateTime(2012, 5, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Madaraka Day", HolidayDate = new DateTime(2012, 6, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Eid ul-Fitr*", HolidayDate = new DateTime(2012, 8, 19) });
                    m_lstholidays.Add(new Holiday() { Description = "Moi Day", HolidayDate = new DateTime(2012, 10, 10) });
                    m_lstholidays.Add(new Holiday() { Description = "Kenyatta Day", HolidayDate = new DateTime(2012, 10, 20) });
                    m_lstholidays.Add(new Holiday() { Description = "Eid al-Adha*", HolidayDate = new DateTime(2012, 10, 26) });                    
                    m_lstholidays.Add(new Holiday() { Description = "Independence Day", HolidayDate = new DateTime(2012, 12, 12) });
                    m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) });                    
                    m_lstholidays.Add(new Holiday() { Description = "Boxing Day", HolidayDate = new DateTime(2012, 12, 26) });                    
                    break;
                case "Malaysia":
                    m_lstholidays.Add(new Holiday() { Description = "New Year's Day", HolidayDate = new DateTime(2012, 1, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Chinese New Year", HolidayDate = new DateTime(2012, 1, 23) });
                    m_lstholidays.Add(new Holiday() { Description = "Mawlid-al-Nabi*", HolidayDate = new DateTime(2012, 2, 4) });
                    m_lstholidays.Add(new Holiday() { Description = "Wesak Day", HolidayDate = new DateTime(2012, 4, 28) });
                    m_lstholidays.Add(new Holiday() { Description = "Labour Day", HolidayDate = new DateTime(2012, 5, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "King's Birthday", HolidayDate = new DateTime(2012, 6, 2) });
                    m_lstholidays.Add(new Holiday() { Description = "Hari Raya Puasa*", HolidayDate = new DateTime(2012, 8, 19) });
                    m_lstholidays.Add(new Holiday() { Description = "Meredeka Day", HolidayDate = new DateTime(2012, 8, 31) });
                    m_lstholidays.Add(new Holiday() { Description = "Hari Raya Qurban*", HolidayDate = new DateTime(2012, 10, 26) });
                    m_lstholidays.Add(new Holiday() { Description = "Deepawali", HolidayDate = new DateTime(2012, 11, 13) });
                    m_lstholidays.Add(new Holiday() { Description = "Awal Muharram*", HolidayDate = new DateTime(2012, 11, 15) });
                    m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) });                         
                    break;
                case "Malta":
                    m_lstholidays.Add(new Holiday() { Description = "New Year's Day", HolidayDate = new DateTime(2012, 1, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Saint Paul's Shipwreck", HolidayDate = new DateTime(2012, 2, 10) });
                    m_lstholidays.Add(new Holiday() { Description = "Saint Joseph's Day", HolidayDate = new DateTime(2012, 3, 19) });
                    m_lstholidays.Add(new Holiday() { Description = "Freedom Day", HolidayDate = new DateTime(2012, 3, 31) });
                    m_lstholidays.Add(new Holiday() { Description = "Good Friday", HolidayDate = new DateTime(2012, 4, 6) });
                    m_lstholidays.Add(new Holiday() { Description = "Easter Sunday", HolidayDate = new DateTime(2012, 4, 8) });
                    m_lstholidays.Add(new Holiday() { Description = "Easter Monday", HolidayDate = new DateTime(2012, 4, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "Labour Day", HolidayDate = new DateTime(2012, 5, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Malta National Holiday", HolidayDate = new DateTime(2012, 6, 7) });
                    m_lstholidays.Add(new Holiday() { Description = "Feast of Sts Peter and Paul", HolidayDate = new DateTime(2012, 6, 29) });
                    m_lstholidays.Add(new Holiday() { Description = "Assumption Day", HolidayDate = new DateTime(2012, 8, 15) });
                    m_lstholidays.Add(new Holiday() { Description = "Our Lady of Victories", HolidayDate = new DateTime(2012, 9, 8) });
                    m_lstholidays.Add(new Holiday() { Description = "Independence Day", HolidayDate = new DateTime(2012, 9, 21) });
                    m_lstholidays.Add(new Holiday() { Description = "All Saints Day", HolidayDate = new DateTime(2012, 11, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "All Souls Day", HolidayDate = new DateTime(2012, 11, 2) });
                    m_lstholidays.Add(new Holiday() { Description = "Imamaculate Conception", HolidayDate = new DateTime(2012, 12, 8) });
                    m_lstholidays.Add(new Holiday() { Description = "Republic Day Malta", HolidayDate = new DateTime(2012, 12, 13) });
                    m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) });                       
                    break;
                case "Mauritius":
                    m_lstholidays.Add(new Holiday() { Description = "New Year's Day", HolidayDate = new DateTime(2012, 1, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Thaipoosam Cavadee*", HolidayDate = new DateTime(2012, 1, 20) });
                    m_lstholidays.Add(new Holiday() { Description = "Chinese New Year", HolidayDate = new DateTime(2012, 1, 23) });
                    m_lstholidays.Add(new Holiday() { Description = "Abolition of Slavery Day", HolidayDate = new DateTime(2012, 2, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Maha Shivaratri", HolidayDate = new DateTime(2012, 2, 20) });
                    m_lstholidays.Add(new Holiday() { Description = "Independence Day", HolidayDate = new DateTime(2012, 3, 12) });
                    m_lstholidays.Add(new Holiday() { Description = "Ougadi", HolidayDate = new DateTime(2012, 3, 23) });
                    m_lstholidays.Add(new Holiday() { Description = "Labour Day", HolidayDate = new DateTime(2012, 5, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Eid ul-Fitr*", HolidayDate = new DateTime(2012, 8, 19) });
                    m_lstholidays.Add(new Holiday() { Description = "Ganesh Chaturthi", HolidayDate = new DateTime(2012, 9, 19) });
                    m_lstholidays.Add(new Holiday() { Description = "All Saints' Day", HolidayDate = new DateTime(2012, 11, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "First Labourer's Day", HolidayDate = new DateTime(2012, 11, 2) });
                    m_lstholidays.Add(new Holiday() { Description = "Diwali", HolidayDate = new DateTime(2012, 11, 13) });
                    m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) });                     
                    break;
                case "Nepal":
                    m_lstholidays.Add(new Holiday() { Description = "Vasant Panchami", HolidayDate = new DateTime(2012, 1, 28) });
                    m_lstholidays.Add(new Holiday() { Description = "Martyrs' Day", HolidayDate = new DateTime(2012, 1, 30) });
                    m_lstholidays.Add(new Holiday() { Description = "Rashtirya Prajatantra Divas", HolidayDate = new DateTime(2012, 2, 18) });
                    m_lstholidays.Add(new Holiday() { Description = "Shivaratri", HolidayDate = new DateTime(2012, 2, 20) });
                    m_lstholidays.Add(new Holiday() { Description = "Holi", HolidayDate = new DateTime(2012, 3, 8) });
                    m_lstholidays.Add(new Holiday() { Description = "Rama Navami", HolidayDate = new DateTime(2012, 4, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Navabarsha", HolidayDate = new DateTime(2012, 4, 14) });
                    m_lstholidays.Add(new Holiday() { Description = "Buddha Jayanti", HolidayDate = new DateTime(2012, 4, 28) });
                    m_lstholidays.Add(new Holiday() { Description = "Krishna Janmashtami", HolidayDate = new DateTime(2012, 8, 10) });
                    m_lstholidays.Add(new Holiday() { Description = "Fulpati Saptami", HolidayDate = new DateTime(2012, 10, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Ghatasthapana", HolidayDate = new DateTime(2012, 10, 16) });
                    m_lstholidays.Add(new Holiday() { Description = "Maha Navami", HolidayDate = new DateTime(2012, 10, 23) });
                    m_lstholidays.Add(new Holiday() { Description = "Vijaya Dashami", HolidayDate = new DateTime(2012, 10, 24) });
                    m_lstholidays.Add(new Holiday() { Description = "Constitution Day", HolidayDate = new DateTime(2012, 11, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "Lakshmi Puja", HolidayDate = new DateTime(2012, 11, 13) });
                    m_lstholidays.Add(new Holiday() { Description = "Govardhan Puja", HolidayDate = new DateTime(2012, 11, 14) });
                    break;
                case "Saudi Arabia":
                    m_lstholidays.Add(new Holiday() { Description = "Eid ul-Fitr*", HolidayDate = new DateTime(2012, 8, 19) });
                    m_lstholidays.Add(new Holiday() { Description = "Saudi National Day", HolidayDate = new DateTime(2012, 9, 23) });
                    m_lstholidays.Add(new Holiday() { Description = "Eid al-Adha*", HolidayDate = new DateTime(2012, 10, 26) });                    
                    break;
                case "Singapore":
                    m_lstholidays.Add(new Holiday() { Description = "New Year's Day", HolidayDate = new DateTime(2012, 1, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Chinese New Year", HolidayDate = new DateTime(2012, 1, 23) });                    
                    m_lstholidays.Add(new Holiday() { Description = "Good Friday", HolidayDate = new DateTime(2012, 4, 6) });
                    m_lstholidays.Add(new Holiday() { Description = "Holy Saturday", HolidayDate = new DateTime(2012, 4, 7) });
                    m_lstholidays.Add(new Holiday() { Description = "Easter Monday", HolidayDate = new DateTime(2012, 4, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "Labour Day", HolidayDate = new DateTime(2012, 5, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Vesak Day*", HolidayDate = new DateTime(2012, 5, 6) });
                    m_lstholidays.Add(new Holiday() { Description = "National Day", HolidayDate = new DateTime(2012, 8, 9) });          
                    m_lstholidays.Add(new Holiday() { Description = "Hari Raya Puasa", HolidayDate = new DateTime(2012, 8, 19) });
                    m_lstholidays.Add(new Holiday() { Description = "Hari Raya Haji*", HolidayDate = new DateTime(2012, 10, 26) });
                    m_lstholidays.Add(new Holiday() { Description = "Deepavali", HolidayDate = new DateTime(2012, 11, 13) });
                    m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) });    
                    break;
                case "South Afirca":
                    m_lstholidays.Add(new Holiday() { Description = "New Year's Day", HolidayDate = new DateTime(2012, 1, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Human Rights Day", HolidayDate = new DateTime(2012, 3, 21) });
                    m_lstholidays.Add(new Holiday() { Description = "Good Friday", HolidayDate = new DateTime(2012, 4, 6) });
                    m_lstholidays.Add(new Holiday() { Description = "Holy Saturday", HolidayDate = new DateTime(2012, 4, 7) });
                    m_lstholidays.Add(new Holiday() { Description = "Easter Monday", HolidayDate = new DateTime(2012, 4, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "Freedom Day", HolidayDate = new DateTime(2012, 4, 27) });
                    m_lstholidays.Add(new Holiday() { Description = "Workers Day", HolidayDate = new DateTime(2012, 5, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Youth Day", HolidayDate = new DateTime(2012, 6, 16) });
                    m_lstholidays.Add(new Holiday() { Description = "National Women's Day", HolidayDate = new DateTime(2012, 8, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "Heritage Day", HolidayDate = new DateTime(2012, 9, 24) });
                    m_lstholidays.Add(new Holiday() { Description = "Day of Reconcillation", HolidayDate = new DateTime(2012, 12, 16) });
                    m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) });    
                    m_lstholidays.Add(new Holiday() { Description = "Day of Goodwill", HolidayDate = new DateTime(2012, 12, 26) });                    
                    break;
                case "Tanzania":
                    m_lstholidays.Add(new Holiday() { Description = "New Year's Day", HolidayDate = new DateTime(2012, 1, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Zanzibar Revolution Day", HolidayDate = new DateTime(2012, 1, 12) });
                    m_lstholidays.Add(new Holiday() { Description = "Birth of the Prophet Day", HolidayDate = new DateTime(2012, 2, 4) });
                    m_lstholidays.Add(new Holiday() { Description = "Good Friday", HolidayDate = new DateTime(2012, 4, 6) });
                    m_lstholidays.Add(new Holiday() { Description = "Holy Saturday", HolidayDate = new DateTime(2012, 4, 7) });
                    m_lstholidays.Add(new Holiday() { Description = "Easter Sunday", HolidayDate = new DateTime(2012, 4, 8) });
                    m_lstholidays.Add(new Holiday() { Description = "Easter Monday", HolidayDate = new DateTime(2012, 4, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "Union Day", HolidayDate = new DateTime(2012, 4, 26) });
                    m_lstholidays.Add(new Holiday() { Description = "Worker's Day", HolidayDate = new DateTime(2012, 5, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Saba Saba", HolidayDate = new DateTime(2012, 7, 7) });
                    m_lstholidays.Add(new Holiday() { Description = "Nane Nane", HolidayDate = new DateTime(2012, 8, 8) });
                    m_lstholidays.Add(new Holiday() { Description = "Eid ul-Fitr", HolidayDate = new DateTime(2012, 8, 19) });
                    m_lstholidays.Add(new Holiday() { Description = "Nyerere Day", HolidayDate = new DateTime(2012, 10, 14) });
                    m_lstholidays.Add(new Holiday() { Description = "Eid al-Adha*", HolidayDate = new DateTime(2012, 10, 26) });
                    m_lstholidays.Add(new Holiday() { Description = "Independence Day", HolidayDate = new DateTime(2012, 12, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) });                    
                    m_lstholidays.Add(new Holiday() { Description = "Boxing Day", HolidayDate = new DateTime(2012, 12, 26) });                    
                    break;
                case "Uganda":
                    m_lstholidays.Add(new Holiday() { Description = "New Year's Day", HolidayDate = new DateTime(2012, 1, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Liberation Day", HolidayDate = new DateTime(2012, 1, 26) });
                    m_lstholidays.Add(new Holiday() { Description = "International Women's Day", HolidayDate = new DateTime(2012, 3, 8) });
                    m_lstholidays.Add(new Holiday() { Description = "Good Friday", HolidayDate = new DateTime(2012, 4, 6) });                    
                    m_lstholidays.Add(new Holiday() { Description = "Easter Monday", HolidayDate = new DateTime(2012, 4, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "Labour Day", HolidayDate = new DateTime(2012, 5, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Martyre' Day", HolidayDate = new DateTime(2012, 6, 3) });
                    m_lstholidays.Add(new Holiday() { Description = "National Heroes' Day", HolidayDate = new DateTime(2012, 6, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "Eid ul-Fitr", HolidayDate = new DateTime(2012, 8, 19) });
                    m_lstholidays.Add(new Holiday() { Description = "Independence Day", HolidayDate = new DateTime(2012, 10, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "Eid al-Adha*", HolidayDate = new DateTime(2012, 10, 26) });
                     m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) });                    
                    m_lstholidays.Add(new Holiday() { Description = "Boxing Day", HolidayDate = new DateTime(2012, 12, 26) });                    
                    break;
                case "United Kingdom":
                    m_lstholidays.Add(new Holiday() { Description = "New Year's Day", HolidayDate = new DateTime(2012, 1, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "2nd of January", HolidayDate = new DateTime(2012, 1, 2) });
                    m_lstholidays.Add(new Holiday() { Description = "Good Friday", HolidayDate = new DateTime(2012, 4, 6) });                    
                    m_lstholidays.Add(new Holiday() { Description = "Easter Sunday", HolidayDate = new DateTime(2012, 4, 8) });
                    m_lstholidays.Add(new Holiday() { Description = "Easter Monday", HolidayDate = new DateTime(2012, 4, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "May Day", HolidayDate = new DateTime(2012, 5, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Sping Bank Holiday", HolidayDate = new DateTime(2012, 6, 4) });
                    m_lstholidays.Add(new Holiday() { Description = "Summer Bank Holiday", HolidayDate = new DateTime(2012, 8, 27) });
                    m_lstholidays.Add(new Holiday() { Description = "Halloween", HolidayDate = new DateTime(2012, 10, 31) });
                    m_lstholidays.Add(new Holiday() { Description = "Guy Fawkes Day", HolidayDate = new DateTime(2012, 11, 5) });
                    m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) });                    
                    m_lstholidays.Add(new Holiday() { Description = "Boxing Day", HolidayDate = new DateTime(2012, 12, 26) });                       
                    break;
                case "United States":
                    m_lstholidays.Add(new Holiday() { Description = "New Year's Day", HolidayDate = new DateTime(2012, 1, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Martin Luther King's Birthday", HolidayDate = new DateTime(2012, 1, 16) });
                    m_lstholidays.Add(new Holiday() { Description = "President's Day", HolidayDate = new DateTime(2012, 2, 20) });
                    m_lstholidays.Add(new Holiday() { Description = "Easter Sunday", HolidayDate = new DateTime(2012, 4, 8) });
                    m_lstholidays.Add(new Holiday() { Description = "Memorial Day", HolidayDate = new DateTime(2012, 5, 28) });
                    m_lstholidays.Add(new Holiday() { Description = "Independence Day", HolidayDate = new DateTime(2012, 7, 4) });
                    m_lstholidays.Add(new Holiday() { Description = "Labour Day", HolidayDate = new DateTime(2012, 9, 3) });
                    m_lstholidays.Add(new Holiday() { Description = "Columbus Day", HolidayDate = new DateTime(2012, 10, 8) });
                    m_lstholidays.Add(new Holiday() { Description = "Halloween", HolidayDate = new DateTime(2012, 10, 31) });
                    m_lstholidays.Add(new Holiday() { Description = "Thanksgiving Day", HolidayDate = new DateTime(2012, 11, 22) });
                    m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) });
                    break;       
                case "Zimbabwe":
                    m_lstholidays.Add(new Holiday() { Description = "New Year's Day", HolidayDate = new DateTime(2012, 1, 1) });                    
                    m_lstholidays.Add(new Holiday() { Description = "Good Friday", HolidayDate = new DateTime(2012, 4, 6) });                                        
                    m_lstholidays.Add(new Holiday() { Description = "Easter Monday", HolidayDate = new DateTime(2012, 4, 9) });
                    m_lstholidays.Add(new Holiday() { Description = "Independence Day", HolidayDate = new DateTime(2012, 4, 18) });
                    m_lstholidays.Add(new Holiday() { Description = "Labour Day", HolidayDate = new DateTime(2012, 5, 1) });
                    m_lstholidays.Add(new Holiday() { Description = "Heroes' Day", HolidayDate = new DateTime(2012, 8, 8) });
                    m_lstholidays.Add(new Holiday() { Description = "Defence Forces Day", HolidayDate = new DateTime(2012, 8, 12) });
                    m_lstholidays.Add(new Holiday() { Description = "Unity Day", HolidayDate = new DateTime(2012, 12, 22) });
                    m_lstholidays.Add(new Holiday() { Description = "Christmas Day", HolidayDate = new DateTime(2012, 12, 25) });                    
                    m_lstholidays.Add(new Holiday() { Description = "Boxing Day", HolidayDate = new DateTime(2012, 12, 26) });     
                    break;                
            }
            NotifyPropertyChanged("HolidaysList");
        }
        public List<Country> CountriesList 
        {
            get
            {
                return m_countriesList;
            }
            set
            {
                m_countriesList = value;
                NotifyPropertyChanged("CountriesList");
            }
        }
        public List<Holiday> HolidaysList
        {
            get
            {
                return m_lstholidays;
            }
            set
            {
                m_lstholidays = value;
                NotifyPropertyChanged("HolidaysList");
            }
        }
        private List<Country> m_countriesList;
        private string m_selectedCountry;
        private List<Holiday> m_lstholidays;

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    public class Holiday : INotifyPropertyChanged
    {
        public string Description 
        {
            get
            {
                return m_desription;
            }
            set
            {
                m_desription = value;
                NotifyPropertyChanged("Description");
            }
        }
        public DateTime HolidayDate { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private string m_desription;
    }
    public class Country
    {
        public string CountryName { get; set; }
    }
    
    
}
