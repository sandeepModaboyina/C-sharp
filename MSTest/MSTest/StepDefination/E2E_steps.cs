using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MSTest.StepDefination
{
    [Binding]
    public sealed class E2E_steps
    {
        [Given(@"The user is on the Homepage")]
        public void GivenTheUserIsOnTheHomepage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"click on signin button")]
        public void GivenClickOnSigninButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"user create a new account")]
        public void GivenUserCreateANewAccount()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Login sucessfully")]
        public void ThenLoginSucessfully()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"adds the most expensive dress and add it to the cart")]
        public void WhenAddsTheMostExpensiveDressAndAddItToTheCart()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Log out")]
        public void WhenLogOut()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Login again")]
        public void WhenLoginAgain()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"ensuring the dress is not in the cart")]
        public void ThenEnsuringTheDressIsNotInTheCart()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
