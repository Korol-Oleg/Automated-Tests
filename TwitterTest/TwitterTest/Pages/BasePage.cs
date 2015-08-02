using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using TwitterTest.Test;

namespace TwitterTest.Pages
{
    public abstract class BasePage : TestBase
    {
        public BasePage()
        {
            PageFactory.InitElements(Driver(), this);
        }

        private readonly WebDriverWait _wait = new WebDriverWait(Driver(), TimeSpan.FromSeconds(150));



        public void WaitElement(IWebElement element)
        {
            _wait.Until(dr => element.Displayed);
        }
    }
}
