using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using TwitterTest.Helper;

namespace TwitterTest.Pages
{
    class ProfilePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "tweet-box-home-timeline")]
        protected IWebElement txtFieldPost { get; set; }

        [FindsBy(How = How.XPath, Using = @"//div[@class = 'home-tweet-box tweet-box component tweet-user']//span[@class = 'button-text tweeting-text']")]
        protected IWebElement btnSendPost { get; set; }

        [FindsBy(How = How.XPath, Using = @"//a[@class = 'btn js-tooltip settings dropdown-toggle js-dropdown-toggle']")]
        protected IWebElement navUserMenu { get; set; }

        [FindsBy(How = How.Id, Using = "signout-button")]
        protected IWebElement btnLogOut { get; set; }

        [FindsBy(How = How.XPath, Using = @"//li[@class = 'js-actionDelete' and @role = 'presentation']")]
        protected IWebElement btnDeletePost { get; set; }

        [FindsBy(How = How.XPath, Using = @"//button[@class = 'btn primary-btn delete-action']")]
        protected IWebElement btnAcceptDeletePost { get; set; }

        private string _textPost;

        public void DeletePost()
        { 
            FindDynamicElement.FindDropMenuInPost(_textPost).Click();
            btnDeletePost.Click();
            btnAcceptDeletePost.Click();
        }

        public void WritePost()
        {
            _textPost = string.Format("Test post " + DateTime.Now);
            WaitElement(txtFieldPost);
            txtFieldPost.SendKeys(_textPost);
        }

        public void ClickSendPost()
        {
            WaitElement(btnSendPost);
            btnSendPost.Click();

        }

        public void ClickUserMenu()
        {
            navUserMenu.Click();
        }

        public LogOutPage ClickLogOut()
        {
            btnLogOut.Click();
            return new LogOutPage();
        }

        public void VerifyLogIn()
        {
            WaitElement(navUserMenu);
            Assert.True(navUserMenu.Displayed);
        }

        public void VerifyPostCreated()
        {
            Assert.True(FindDynamicElement.FindTextPost(_textPost).Displayed);
        }

        public void VerifyPostDeleted()
        {
            
            Assert.IsFalse(!FindDynamicElement.FindTextPost(_textPost).Displayed);
        }
    }
}
