using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TwitterTest.Pages
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "signin-email")]
        protected IWebElement txtLogin { get; set; }

        [FindsBy(How = How.Id, Using = "signin-password")]
        protected IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = @"//button[@type = 'submit' and contains(@class, 'submit btn primary')]")]
        protected IWebElement btnLogin { get; set; }

        public void InputLogAndPass(string login, string pass)
        {
            WaitElementDisplayed(txtLogin);
            txtLogin.SendKeys(login);
            WaitElementDisplayed(txtPassword);
            txtPassword.SendKeys(pass);
        }

        public void ClickLoginSubmit()
        {
            btnLogin.Click();
        }

    }
}
