using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace MSTest.PageObject
{
   public class Objects
    {
        #region WebElements
        private By SignInButton = By.LinkText("Sign in");
        private By EmailAddress = By.Id("email_create");
        private By CreateAccountButton = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Email address'])[1]/following::span[1]");
        #endregion
        #region Actions
        public void EnterEmailAdress(string text)
        {
            IWebDriver driver = new ChromeDriver()
                
        }
        #endregion
    }
}
