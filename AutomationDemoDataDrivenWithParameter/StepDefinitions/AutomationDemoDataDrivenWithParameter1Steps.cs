using AutomationDemoDataDrivenWithParameter.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AutomationDemoDataDrivenWithParameter.StepDefinitions
{
    [Binding]
    public class AutomationDemoDataDrivenWithParameter1Steps
    {
        AutomationDemoDataDrivenWithParameterPage1 AutomationDemoDataDrivenWithParameterPage1;
        public AutomationDemoDataDrivenWithParameter1Steps()
        {
            AutomationDemoDataDrivenWithParameterPage1 = new AutomationDemoDataDrivenWithParameterPage1();
        }





        [Given(@"I navigate to the website ""(.*)""")]
        public void GivenINavigateToTheWebsite(string url)
        {
            AutomationDemoDataDrivenWithParameterPage1.NavigateToWebsite(url);
        }
        
        [Given(@"I enter my first name ""(.*)""")]
        public void GivenIEnterMyFirstName(string firstname)
        {
            AutomationDemoDataDrivenWithParameterPage1.EnterFirstName(firstname);
        }
        
        [Given(@"I enter last name ""(.*)""")]
        public void GivenIEnterLastName(string lastname)
        {
            AutomationDemoDataDrivenWithParameterPage1.EnterLastName(lastname);
        }
        
        [Given(@"I enter my address ""(.*)""")]
        public void GivenIEnterMyAddress(string address)
        {
            AutomationDemoDataDrivenWithParameterPage1.EnterAddress(address);
        }
        
        [Given(@"I enter my Email address ""(.*)""")]
        public void GivenIEnterMyEmailAddress(string emailaddress)
        {
            AutomationDemoDataDrivenWithParameterPage1.EnterEmailAddress(emailaddress);
        }
        
        [Given(@"I enter my Gender ""(.*)""")]
        public void GivenIEnterMyGender(string female)
        {
            Thread.Sleep(5000);
            AutomationDemoDataDrivenWithParameterPage1.EnterGenderFemale(female);
        }
        
        [Given(@"I enter of Hobbies ""(.*)""")]
        public void GivenIEnterOfHobbies(string cricket)
        {
            AutomationDemoDataDrivenWithParameterPage1.EnterHobbiesCricket(cricket);
        }
        
        [Given(@"I enter my password ""(.*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            AutomationDemoDataDrivenWithParameterPage1.EnterPassword(password);
        }
        
        [Given(@"I enter confirmed password ""(.*)""")]
        public void GivenIEnterConfirmedPassword(string confirmedpassword)
        {
            AutomationDemoDataDrivenWithParameterPage1.EnterConfirmedPassword(confirmedpassword);
        }
        
        [When(@"I click on the submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
            AutomationDemoDataDrivenWithParameterPage1.ClickSubmitButton();
        }
    }
}
