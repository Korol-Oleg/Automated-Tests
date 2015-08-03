using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using TwitterTest.Helper;

namespace TwitterTest.Pages
{
    public abstract class BasePage : Browser
    {
        protected BasePage()
        {
            PageFactory.InitElements(Driver(), this);
        }

        private readonly WebDriverWait _wait = new WebDriverWait(Driver(), TimeSpan.FromSeconds(25));



        public void WaitElementDisplayed(IWebElement element)
        {
            _wait.Until(dr => element.Displayed);
        }

        public void WaitElementEnabled(IWebElement element)
        {
            _wait.Until(dr => element.Enabled);
        }

        public void WaitElementNotDisplayed(IWebElement element)
        {
            _wait.Until(dr => !element.Displayed);
        }
    }
}
