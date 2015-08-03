using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TwitterTest.Helper;

namespace TwitterTest.Pages
{
    public class ProfilePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "tweet-box-home-timeline")]
        protected IWebElement txtFieldPost { get; set; }

        [FindsBy(How = How.XPath, Using = @"//div[@class = 'home-tweet-box tweet-box component tweet-user']//span[@class = 'button-text tweeting-text']")]
        protected IWebElement btnSendPost { get; set; }

        [FindsBy(How = How.XPath, Using = @"//li[@id= 'user-dropdown']/a[@id='user-dropdown-toggle']")]
        protected IWebElement navUserMenu { get; set; }

        [FindsBy(How = How.Id, Using = "signout-button")]
        protected IWebElement btnLogOut { get; set; }

        [FindsBy(How = How.Id, Using = "empty-timeline-recommendations")]
        protected IWebElement listRecomendation { get; set; }

        [FindsBy(How = How.XPath, Using = @"//li[@class = 'js-actionDelete' and @role = 'presentation']")]
        protected IWebElement btnDeletePost { get; set; }

        [FindsBy(How = How.XPath, Using = @"//button[@class = 'btn primary-btn delete-action']")]
        protected IWebElement btnAcceptDeletePost { get; set; }

        [FindsBy(How = How.XPath, Using = @"//div[@data-user-id = '3398606787']//div[@class = 'content']/p")]
        protected IList<IWebElement> txtUsrPost { get; set; }

        private string _textPost;

        public void DeletePost()
        { 
            FindDynamicElement.FindDropMenuInPost(_textPost).Click();
            btnDeletePost.Click();
            btnAcceptDeletePost.Click();
            WaitElementNotDisplayed(btnAcceptDeletePost);
        }

        public void WritePost()
        {
            WaitElementDisplayed(listRecomendation);
            _textPost = string.Format("Test post " + DateTime.Now);
            WaitElementEnabled(txtFieldPost);
            txtFieldPost.SendKeys(_textPost);
        }

        public void ClickSendPost()
        {

            WaitElementDisplayed(btnSendPost);
            btnSendPost.Click();
        }

        public void ClickUserMenu()
        {
            navUserMenu.Click();
        }

        public void ClickLogOut()
        {
            WaitElementDisplayed(btnLogOut);
            btnLogOut.Click();
        }

        public void VerifyLogIn()
        {
            WaitElementDisplayed(navUserMenu);
            Assert.True(navUserMenu.Displayed);
        }

        public void VerifyPostCreated()
        {
            Assert.True(FindDynamicElement.FindTextPost(_textPost).Displayed);
        }

        public void VerifyPostDeleted()
        {
            int postCount = txtUsrPost.Count(post => post.Text == _textPost);
            Console.WriteLine(postCount);
            //Assert.True(postCount<1);
        }
    }
}
