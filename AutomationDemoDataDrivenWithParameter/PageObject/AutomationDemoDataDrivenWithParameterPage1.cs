using AutomationDemoDataDrivenWithParameter.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationDemoDataDrivenWithParameter.PageObject
{
    class AutomationDemoDataDrivenWithParameterPage1
    {
        public AutomationDemoDataDrivenWithParameterPage1()
        {
            driver = AutomationDemoDataDrivenWithParameterHooks1.driver;
        }
        IWebDriver driver;


        IWebElement FirstName => driver.FindElement(By.XPath("(//input[@type='text'])[1] "));

        IWebElement LastName => driver.FindElement(By.XPath(" (//input[@type='text'])[2]"));

        IWebElement Address => driver.FindElement(By.XPath(" //*[@id='basicBootstrapForm']/div[2]/div/textarea"));

        IWebElement EmailAddress => driver.FindElement(By.XPath(" //input[@type='email']"));

        IWebElement GenderFemale => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[5]/div/label[2]"));

        IWebElement HobbiesCricket => driver.FindElement(By.XPath(" //*[@id='basicBootstrapForm'']/div[6]/div/div[1]/label"));

        IWebElement Password => driver.FindElement(By.XPath("(//input[@type='password'])[1] "));

        IWebElement ConfirmedPassword => driver.FindElement(By.XPath("//input[@id='secondpassword'] "));

        IWebElement ClickOnSubmitButton => driver.FindElement(By.XPath("//button[@id='submitbtn'] "));

        public void EnterFirstName(string firstname)
        {
            FirstName.SendKeys(firstname);
        }
        public void EnterLastName(string lastname)
        {
            LastName.SendKeys(lastname);
        }

        public void EnterAddress(string address)
        {
            Address.SendKeys(address);
        }
        public void EnterEmailAddress(String emailaddress)
        {
            EmailAddress.SendKeys(emailaddress);
        }
        public void EnterGenderFemale(string female)

        {
            GenderFemale.SendKeys(female);
        }
        public void EnterHobbiesCricket(string cricket)
        {
            HobbiesCricket.SendKeys(cricket);
        }
        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }
        public void EnterConfirmedPassword(string confirmedpassword)
        {
            ConfirmedPassword.SendKeys(confirmedpassword);
        }
        public void ClickSubmitButton()
        {
            ClickOnSubmitButton.Click();
        }
            public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
             
        
    
    
    
    
    
    
    }

}
