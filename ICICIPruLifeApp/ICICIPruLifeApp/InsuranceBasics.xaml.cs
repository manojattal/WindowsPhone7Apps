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
using Microsoft.Phone.Shell;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ICICIPruLifeApp
{
    public partial class InsuranceBasics : PhoneApplicationPage
    {
        public InsuranceBasics()
        {
            InitializeComponent();            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var tagValue = ((Button)sender).Tag.ToString();
            string strHeading = string.Empty;
            string strDetails = string.Empty;
            switch (tagValue)
            {
                case "what":
                     strHeading = "What is life insurance?";
                     strDetails = "Life insurance ensures that your family will receive financial support in your absence. Put simply, life insurance provides your family with a sum of money should something happen to you. It protects your family from financial crises."
                                          + Environment.NewLine + Environment.NewLine + Environment.NewLine +
                                          "In addition to serving as a protective cover, life insurance acts as a flexible money-saving scheme, which empowers you to accumulate wealth-to buy a new car, get your children married and even retire comfortably. Life insurance also triples up as an ideal tax-saving scheme.";                    
                    break;
                case "why":
                    strHeading = "Why do I need life insurance?";
                    strDetails = "Who will take care of my family if tomorrow something unfortunate happens to me?” If this question bothers you, then Life Insurance is the answer."
                                  + Environment.NewLine + Environment.NewLine + Environment.NewLine +
                                  "Of course, under any circumstances, the loss of a loved one is a traumatic experience. But, if your family is also left without sufficient money to meet basic living needs or prepare for future goals, they will have to cope with a financial crisis at the same time. A Life Insurance plan ensures that your family is financially secure even if tomorrow you are no longer around to care for them";
                    break;
                case "how":
                    strHeading = "How much insurance do I need?";
                    strDetails = "Before buying an insurance policy, it is always important to find out the amount of life insurance cover you need. The following factors should be considered before buying a life insurance policy:"
                                 + Environment.NewLine +  Environment.NewLine + 
                                 "1. Your age and number of dependents"
                                 + Environment.NewLine +  
                                 "2. Your annual income and annual expenses"
                                 + Environment.NewLine + 
                                 "3. Your outstanding liabilities like home loan, car loan, etc."
                                 + Environment.NewLine +  
                                 "4. Your investments / savings"
                                 + Environment.NewLine + 
                                 "5. Your lifestyle expenses"
                                 + Environment.NewLine + 
                                 "6. Monies you would require in future"
                                 + Environment.NewLine + Environment.NewLine +
                                 "As a thumb rule, it is suggested that you should have an insurance cover of around 5 to 10 times of your annual income.";
                    break;
                case "benefits":
                    strHeading = "What are the tax benefits available?";
                    strDetails = "Life Insurance as a tax saving tool, offers savings under various sections of the income tax act. Some of the key tax benefits offered are as follows:"
                                  + Environment.NewLine + Environment.NewLine +
                                  "1. Our life insurance plans are eligible for tax deduction under Sec. 80C."
                                  + Environment.NewLine +
                                  "2. Our Pension plans are eligible for a tax deduction under Sec. 80CCC."
                                  + Environment.NewLine +
                                  "3. Our health insurance plans/riders are eligible for tax deduction under Sec. 80D."
                                  + Environment.NewLine +
                                  "4. The proceeds or withdrawals of our life insurance policies are exempt under Sec 10(10D), subject to norms prescribed in that section.";
                    break;
                case "back":
                    NavigationService.GoBack();
                    break;
                case "home":
                    NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                    break;
                case "advisor":
                    App.SendSms();
                    break;
            }
            m_viewmodelDetails = new ViewModelDetails(strHeading, strDetails);
            NavigationService.Navigate(new Uri("/Details.xaml?viewmodel=" + m_viewmodelDetails, UriKind.Relative));
            m_bIsNavigating = true;
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            m_bIsNavigating = false;    
        }
        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (!m_bIsNavigating)
                return;
            PhoneApplicationService appService = PhoneApplicationService.Current;
            appService.State["viewModelDetails"] = m_viewmodelDetails;
            base.OnNavigatedFrom(e);
        }
        private ViewModelDetails m_viewmodelDetails;
        private bool m_bIsNavigating;
    }
}