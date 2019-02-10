using System;
using FluentAssertions;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Training_1.PageObjects;
using Training_1.Utilities;
using Hooks = Training_1.Utilities.Hooks;

namespace Training_1
{
    [Binding]
    public class RegistrationsSteps
    {
        RegistrationPage registration;

        public RegistrationsSteps()
           
       {
        registration = new RegistrationPage();

    
        }
        [Given(@"I navigate to the giftrete")]
        public void GivenINavigateToTheGiftrete()
        {
            Hooks.Driver.Navigate().GoToUrl("http://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
        }

        private void Hook()
        {
            throw new NotImplementedException();
        }

        [When(@"click on the register link")]
        public void WhenClickOnTheRegisterLink()
        {
           registration.ClickOnRegister();
        }
        
        [When(@"I enter firstname")]
        public void WhenIEnterFirstname()
        {
            registration.EnterFirstName();
        }
        
        [When(@"I enter last name")]
        public void WhenIEnterLastName()
        {
            registration.EnterLastName("onwujuba");
        }

        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            registration.EnterEmailAddress(email);
        }

        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            registration.EnterMobileNo("07444444444");
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            registration.EnterPassword("MyVerySecurePassword");
        }
        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            registration.EnterConfirmPassword("MyVerySecurePassword");
        }
        
        [When(@"I click on signup")]
        public void WhenIClickOnSignup()
        {
           registration.ClickSignup();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {

            Thread.Sleep(10000);

            //NUnit Assertion
            //Assert.Contains("", "");
           
            Assert.Equals(registration.successMessageIsDisplayed(), true);
            Assert.IsTrue(registration.successMessageIsDisplayed(), "Error Message : Registration failed");

            registration.successMessageIsDisplayed().Should().BeTrue("Error Message : Registration failed");

            registration.successMessageIsDisplayed().Should().Be(true);








        }
    }
}
