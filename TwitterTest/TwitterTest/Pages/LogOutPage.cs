using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TwitterTest.Pages
{
    public class LogOutPage : BasePage
    {

        [FindsBy(How = How.XPath, Using = @"//body[@class = 'three-col logged-out ms-windows western ru supports-drag-and-drop']")]
        protected IWebElement logOutBody { get; set; }

        public void VerifyLogOut()
        {
            WaitElementDisplayed(logOutBody);
            Assert.True(logOutBody.Displayed);
        }
    }
}
