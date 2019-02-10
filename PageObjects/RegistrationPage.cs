using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Training_1.PageObjects
{
    class RegistrationPage
    {

        public RegistrationPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

         [FindsBy(How= How.CssSelector,Using ="#login.form > div.alert.alert =success")]
         private IWebElement SuccessMessage { get; set; }
        
        [FindsBy(How = How.LinkText, Using = "Register" )]
        private IWebElement register { get; set; }

        [FindsBy(How = How.Id, Using = "first-name")]
        private IWebElement firstName { get; set; }

        [FindsBy(How = How.Id, Using = "last-name")]
        private IWebElement lastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "mobile")]
        private IWebElement mobileNo { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password { get; set; }

        internal void EnterFirstName()
        {
            throw new NotImplementedException();
        }

        [FindsBy(How = How.Id, Using = "confirm_password")]
        private IWebElement confirmPassword { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddress { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#signup-form > div.buttons-holder.text-center > button")]
        private IWebElement signUp { get; set; }

        public bool successMessageIsDisplayed()
        {
            try
            {
                return successMessageIsDisplayed;          
            }

            catch(Exception ex)

            { 
            return false;
        }

        public void ClickSignUp()
        {
            signUp.Click();
        }
   
        public void EnterConfirmPassword(string confirmPasswordText)
        {
            confirmPassword.SendKeys(confirmPasswordText);
        }

        public void EnterPassword(string passwordText)
        {
            password.SendKeys(passwordText);
        }

        public void EnterMobileNo(string mobile)
        {
            mobileNo.SendKeys(mobile);
        }

      
        public void EnterLastName(string lastname)
        {
            lastName.SendKeys(lastname);
        }

        public void ClickSignup()
        {

            signUp.Click();
        }
            
        public void ClickOnRegister()
        {
            register.Click();
        }

        public void EnterFirstName()
        {
            firstName.SendKeys("Nneamaka");
        }

        public void EnterEmailAddress(string myEmail)
        {
            emailAddress.SendKeys(myEmail);
        }
    }

    internal class Hooks
    {
        public static IWebDriver Driver { get; internal set; }
    }
}
