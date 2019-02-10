using System;
using TechTalk.SpecFlow;

namespace Training_1.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I navigate to giftrete website")]
        public void GivenINavigateToGiftreteWebsite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I go to loginpage")]
        public void WhenIGoToLoginpage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter email address")]
        public void WhenIEnterEmailAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on secure signin")]
        public void WhenIClickOnSecureSignin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should login")]
        public void ThenIShouldLogin()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
