using System;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace VaccineScheduler
{
    public class ViewModelVaccine
    {
        public string VaccineName { get; set; }
        public string VaccineFullName { get; set; }
        public string VaccineDescription { get; set; }
        public Color Color { get; set; }
        public string DoseDetail { get; set; }
        public string VaccineMonth { get; set; }
        public string VaccineSchedule { get; set; }
        public VaccineType Type { get; set; }
    }

    public enum VaccineType
    {
        Optional,
        NonOptional
    }

    public class Baby
    {
        public string BabyName { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class ViewModelScheduler
    {
        public ViewModelScheduler()
        {
            VaccineList = new ObservableCollection<ViewModelVaccine>();
        }
        public void LoadSchedule(Baby babyDetails)
        {
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "BCG", VaccineFullName = "Tuberculosis vaccine", Color = Colors.Blue, VaccineSchedule = "At Birth", VaccineMonth = GetMonthString(babyDetails.BirthDate.Month) + " " + babyDetails.BirthDate.Year, Type = VaccineType.NonOptional });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "OPV", VaccineFullName = "Oral Polio Vaccine", Color = Colors.Brown, VaccineSchedule = "At Birth", VaccineMonth = GetMonthString(babyDetails.BirthDate.Month) + " " + babyDetails.BirthDate.Year, Type = VaccineType.NonOptional, DoseDetail = "1st dose" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Hepatitis B", Color = Colors.Cyan, VaccineSchedule = "At Birth", VaccineMonth = GetMonthString(babyDetails.BirthDate.Month) + " " + babyDetails.BirthDate.Year, Type = VaccineType.NonOptional, DoseDetail = "1st dose" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "DTP", Color = Colors.DarkGray, VaccineSchedule = "6 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(45).Month) + " " + babyDetails.BirthDate.AddDays(45).Year, Type = VaccineType.NonOptional, DoseDetail = "1st dose", VaccineDescription = "DTP (also referred to as DPT) protects against diphtheria, tetanus, pertussis (whooping cough)." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "HIB",  VaccineFullName = "Hemophilus influenzae type b", Color = Colors.Gray, VaccineSchedule = "6 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(45).Month) + " " + babyDetails.BirthDate.AddDays(45).Year, Type = VaccineType.NonOptional, DoseDetail = "1st dose" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "OPV", VaccineFullName = "Oral Polio Vaccine", Color = Colors.Brown, VaccineSchedule = "6 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(45).Month) + " " + babyDetails.BirthDate.AddDays(45).Year, Type = VaccineType.NonOptional, DoseDetail = "2nd dose"});
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Hepatitis B", Color = Colors.Cyan, VaccineSchedule = "6 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(45).Month) + " " + babyDetails.BirthDate.AddDays(45).Year, Type = VaccineType.NonOptional, DoseDetail = "2nd dose" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "IPV", VaccineFullName = "Injectable polio vaccine", Color = Colors.Green, VaccineSchedule = "6 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(45).Month) + " " + babyDetails.BirthDate.AddDays(45).Year, Type = VaccineType.Optional, DoseDetail = "1st dose", VaccineDescription = "The IPV is advised at 2 months of age, in two doses, with an interval of 2 months. A booster is advised at 18 months. (It gives nasal and throat immunity against the virus besides gut immunity. It is given in addition to the oral polio vaccine (OPV) and is not a substitute i.e. both can be given on the same day)." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Pneumococcal", Color = Colors.Purple, VaccineSchedule = "6 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(45).Month) + " " + babyDetails.BirthDate.AddDays(45).Year, Type = VaccineType.Optional, DoseDetail = "1st dose", VaccineDescription = "This is to prevent pneumonia and meningitis (brain fever). It is quite a costly vaccine and is given as an injection in three doses with a gap of 6 to 8 weeks starting from the second month of life." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Rotavirus ", Color = Colors.Magenta, VaccineSchedule = "6 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(45).Month) + " " + babyDetails.BirthDate.AddDays(45).Year, Type = VaccineType.Optional, DoseDetail = "1st dose", VaccineDescription = "This vaccine helps protect against rotavirus - the leading cause of diarrhoea. The WHO recommends this vaccine because the rotavirus is a major cause of dehydration in babies." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "DTP", Color = Colors.DarkGray, VaccineSchedule = "10 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(75).Month) + " " + babyDetails.BirthDate.AddDays(75).Year, Type = VaccineType.NonOptional, DoseDetail = "2nd dose", VaccineDescription = "DTP (also referred to as DPT) protects against diphtheria, tetanus, pertussis (whooping cough)." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "HIB", VaccineFullName = "Hemophilus influenzae type b", Color = Colors.Gray, VaccineSchedule = "10 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(75).Month) + " " + babyDetails.BirthDate.AddDays(75).Year, Type = VaccineType.NonOptional, DoseDetail = "2nd dose" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "OPV", VaccineFullName = "Oral Polio Vaccine", Color = Colors.Brown, VaccineSchedule = "10 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(75).Month) + " " + babyDetails.BirthDate.AddDays(75).Year, Type = VaccineType.NonOptional, DoseDetail = "3rd dose" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Rotavirus ", Color = Colors.Magenta, VaccineSchedule = "10 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(75).Month) + " " + babyDetails.BirthDate.AddDays(75).Year, Type = VaccineType.Optional, DoseDetail = "2nd dose", VaccineDescription = "This vaccine helps protect against rotavirus - the leading cause of diarrhoea. The WHO recommends this vaccine because the rotavirus is a major cause of dehydration in babies." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "DTP", Color = Colors.DarkGray, VaccineSchedule = "14 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(105).Month) + " " + babyDetails.BirthDate.AddDays(105).Year, Type = VaccineType.NonOptional, DoseDetail = "3rd dose", VaccineDescription = "DTP (also referred to as DPT) protects against diphtheria, tetanus, pertussis (whooping cough)." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "OPV", VaccineFullName = "Oral Polio Vaccine", Color = Colors.Brown, VaccineSchedule = "14 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(105).Month) + " " + babyDetails.BirthDate.AddDays(105).Year, Type = VaccineType.NonOptional, DoseDetail = "4th dose" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "HIB", VaccineFullName = "Hemophilus influenzae type b", Color = Colors.Gray, VaccineSchedule = "14 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(105).Month) + " " + babyDetails.BirthDate.AddDays(105).Year, Type = VaccineType.NonOptional, DoseDetail = "3rd dose" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Hepatitis B", Color = Colors.Cyan, VaccineSchedule = "14 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(105).Month) + " " + babyDetails.BirthDate.AddDays(105).Year, Type = VaccineType.NonOptional, DoseDetail = "3rd dose" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Pneumococcal", Color = Colors.Purple, VaccineSchedule = "14 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(105).Month) + " " + babyDetails.BirthDate.AddDays(105).Year, Type = VaccineType.Optional, DoseDetail = "2nd dose", VaccineDescription = "This is to prevent pneumonia and meningitis (brain fever). It is quite a costly vaccine and is given as an injection in three doses with a gap of 6 to 8 weeks starting from the second month of life." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Rotavirus ", Color = Colors.Magenta, VaccineSchedule = "14 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(105).Month) + " " + babyDetails.BirthDate.AddDays(105).Year, Type = VaccineType.Optional, DoseDetail = "3rd dose", VaccineDescription = "This vaccine helps protect against rotavirus - the leading cause of diarrhoea. The WHO recommends this vaccine because the rotavirus is a major cause of dehydration in babies." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "IPV", VaccineFullName = "Injectable polio vaccine", Color = Colors.Green, VaccineSchedule = "16 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(120).Month) + " " + babyDetails.BirthDate.AddDays(120).Year, Type = VaccineType.Optional, DoseDetail = "2nd dose", VaccineDescription = "The IPV is advised at 2 months of age, in two doses, with an interval of 2 months. A booster is advised at 18 months. (It gives nasal and throat immunity against the virus besides gut immunity. It is given in addition to the oral polio vaccine (OPV) and is not a substitute i.e. both can be given on the same day)." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Pneumococcal", Color = Colors.Purple, VaccineSchedule = "20 - 22 weeks", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddDays(150).Month) + " " + babyDetails.BirthDate.AddDays(150).Year, Type = VaccineType.Optional, DoseDetail = "3rd dose", VaccineDescription = "This is to prevent pneumonia and meningitis (brain fever). It is quite a costly vaccine and is given as an injection in three doses with a gap of 6 to 8 weeks starting from the second month of life." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Influenza vaccine", Color = Colors.Orange, VaccineSchedule = "6 months", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddMonths(6).Month) + " " + babyDetails.BirthDate.AddMonths(6).Year, Type = VaccineType.Optional, DoseDetail = "1st dose", VaccineDescription = "This prevents common flu to a large extent. It is administered as an injection anytime after 6 months age. First timers are given 2 shots with a gap of 4 to 6 weeks. After the priming doses, one shot is given every year between October and December. This vaccine is unique, as it is specially manufactured for that particular year only, depending on the flu virus prevalent" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Influenza vaccine", Color = Colors.Orange, VaccineSchedule = "7-8 months", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddMonths(7).Month) + " " + babyDetails.BirthDate.AddMonths(7).Year, Type = VaccineType.Optional, DoseDetail = "2nd dose", VaccineDescription = "This prevents common flu to a large extent. It is administered as an injection anytime after 6 months age. First timers are given 2 shots with a gap of 4 to 6 weeks. After the priming doses, one shot is given every year between October and December. This vaccine is unique, as it is specially manufactured for that particular year only, depending on the flu virus prevalent" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Measles", Color = Colors.Purple, VaccineSchedule = "9-12 months", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddMonths(9).Month) + " " + babyDetails.BirthDate.AddMonths(9).Year, Type = VaccineType.NonOptional});
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "OPV", VaccineFullName = "Oral Polio Vaccine", Color = Colors.Brown, VaccineSchedule = "9-12 months", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddMonths(9).Month) + " " + babyDetails.BirthDate.AddMonths(9).Year, Type = VaccineType.NonOptional, DoseDetail = "5th dose" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Chickenpox", Color = Colors.Green, VaccineSchedule = "12-18 months", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddMonths(12).Month) + " " + babyDetails.BirthDate.AddMonths(12).Year, Type = VaccineType.Optional, VaccineDescription = "The chickenpox vaccine protects from the chickenpox virus. It is a lifelong protection." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "MMR ", Color = Colors.Red, VaccineSchedule = "15-18 months", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddMonths(15).Month) + " " + babyDetails.BirthDate.AddMonths(15).Year, Type = VaccineType.NonOptional, VaccineDescription = "protect against measles, mumps and rubella (German measles)" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "HIB", VaccineFullName = "Hemophilus influenzae type b", Color = Colors.Gray, VaccineSchedule = "15 months", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddMonths(15).Month) + " " + babyDetails.BirthDate.AddMonths(15).Year, Type = VaccineType.NonOptional, DoseDetail = "booster" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "DTP", Color = Colors.DarkGray, VaccineSchedule = "15-18 months", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddMonths(15).Month) + " " + babyDetails.BirthDate.AddMonths(15).Year, Type = VaccineType.NonOptional, DoseDetail = "1st booster", VaccineDescription = "DTP (also referred to as DPT) protects against diphtheria, tetanus, pertussis (whooping cough)." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "OPV", VaccineFullName = "Oral Polio Vaccine", Color = Colors.Brown, VaccineSchedule = "18-24 months", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddMonths(18).Month) + " " + babyDetails.BirthDate.AddMonths(18).Year, Type = VaccineType.NonOptional, DoseDetail = "1st booster" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "IPV", VaccineFullName = "Injectable polio vaccine", Color = Colors.Green, VaccineSchedule = "18-24 months", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddMonths(18).Month) + " " + babyDetails.BirthDate.AddMonths(18).Year, Type = VaccineType.Optional, DoseDetail = "booster  dose", VaccineDescription = "The IPV is advised at 2 months of age, in two doses, with an interval of 2 months. A booster is advised at 18 months. (It gives nasal and throat immunity against the virus besides gut immunity. It is given in addition to the oral polio vaccine (OPV) and is not a substitute i.e. both can be given on the same day)." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Hepatitis A", Color = Colors.Red, VaccineSchedule = "2 years", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddYears(2).Month) + " " + babyDetails.BirthDate.AddYears(2).Year, Type = VaccineType.Optional, DoseDetail = "1st dose", VaccineDescription = "Hepatitis A vaccine is given in 2 doses (preferably at 2 years age, with a gap of minimum 6 months). The second dose is known as Hepatitis A-booster. These two doses confer long term immunity." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Meningococcal", Color = Colors.Blue, VaccineSchedule = "2 years", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddYears(2).Month) + " " + babyDetails.BirthDate.AddYears(2).Year, Type = VaccineType.Optional, VaccineDescription = "This again prevents meningitis (brain fever). It is given from 2 years age as an injection and is valid for 2 years. It is available in two varieties, one protecting against all 4 strains and the other against 2 strains." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Typhoid", Color = Colors.LightGray, VaccineSchedule = "2 years", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddYears(2).Month) + " " + babyDetails.BirthDate.AddYears(2).Year, Type = VaccineType.Optional, VaccineDescription = "The typhoid vaccine will protect your baby against typhoid. Typhoid is a bacterial disease which spreads through contaminated food and water. Your baby will need a dose of this vaccine every three years." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Hepatitis A", Color = Colors.Red, VaccineSchedule = "2 years, 6 months", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddMonths(30).Month) + " " + babyDetails.BirthDate.AddMonths(30).Year, Type = VaccineType.Optional, DoseDetail = "2nd dose", VaccineDescription = "Hepatitis A vaccine is given in 2 doses (preferably at 2 years age, with a gap of minimum 6 months). The second dose is known as Hepatitis A-booster. These two doses confer long term immunity." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "DTP", Color = Colors.DarkGray, VaccineSchedule = "4-5 years", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddYears(4).Month) + " " + babyDetails.BirthDate.AddYears(4).Year, Type = VaccineType.NonOptional, DoseDetail = "2nd booster", VaccineDescription = "DTP (also referred to as DPT) protects against diphtheria, tetanus, pertussis (whooping cough)." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "OPV", VaccineFullName = "Oral Polio Vaccine", Color = Colors.Brown, VaccineSchedule = "4-5 years", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddYears(4).Month) + " " + babyDetails.BirthDate.AddYears(4).Year, Type = VaccineType.NonOptional, DoseDetail = "booster dose" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Hepatitis A", Color = Colors.Red, VaccineSchedule = "4-5 years", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddYears(4).Month) + " " + babyDetails.BirthDate.AddYears(4).Year, Type = VaccineType.Optional, VaccineDescription = "recommended if not given earlier" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Typhoid", Color = Colors.LightGray , VaccineSchedule = "4-5 years", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddYears(4).Month) + " " + babyDetails.BirthDate.AddYears(4).Year, Type = VaccineType.Optional, VaccineDescription = "The typhoid vaccine will protect your baby against typhoid. Typhoid is a bacterial disease which spreads through contaminated food and water. Your baby will need a dose of this vaccine every three years." });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "MMR ", Color = Colors.Red, VaccineSchedule = "4-5 years", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddYears(4).Month) + " " + babyDetails.BirthDate.AddYears(4).Year, Type = VaccineType.NonOptional, VaccineDescription = "protect against measles, mumps and rubella (German measles)" });
            VaccineList.Add(new ViewModelVaccine() { VaccineName = "Chickenpox", Color = Colors.Green, VaccineSchedule = "4-5 years", VaccineMonth = GetMonthString(babyDetails.BirthDate.AddYears(4).Month) + " " + babyDetails.BirthDate.AddYears(4).Year, Type = VaccineType.Optional, VaccineDescription = "The chickenpox vaccine protects from the chickenpox virus. It is a lifelong protection." });

        }

        public ObservableCollection<ViewModelVaccine> VaccineList { get; set; }

        private string  GetMonthString(int nMonthId)
        {
            switch(nMonthId)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
            }
            return string.Empty;
        }       

    }
}
