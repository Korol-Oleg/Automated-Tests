using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TwitterTest.Pages
{
    class HomePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "signin-email")]
        protected IWebElement txtLogin { get; set; }

        [FindsBy(How = How.Id, Using = "signin-password")]
        protected IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = @"//button[@type = 'submit' and contains(@class, 'submit btn primary')]")]
        protected IWebElement btnLogin { get; set; }

        public void InputLogAndPass(string login, string pass)
        {
            txtLogin.SendKeys(login);
            txtPassword.SendKeys(pass);
        }

        public ProfilePage ClickLoginSubmit()
        {
            btnLogin.Click();
            return new ProfilePage();
        }

    }
}
