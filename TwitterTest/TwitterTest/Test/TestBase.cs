using System;
using NUnit.Framework;
using TwitterTest.Helper;
using TwitterTest.Pages;

namespace TwitterTest.Test
{
    [TestFixture]
    public class TestBase : Browser
    {
        protected HomePage home;
        protected ProfilePage profile;
        protected LogOutPage logOutPage;

        public void RefreshTab()
        {
            Driver().Navigate().Refresh();
        }

        [SetUp]
        public void Setup()
        {
            Driver().Manage().Window.Maximize();
            Driver().Url = "https://twitter.com/";
            Driver().Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(25));
            home = new HomePage();
            profile = new ProfilePage();
            logOutPage = new LogOutPage();
        }

        [TearDown]
        public void TearDown()
        {
            CloseDriver();
        }
    }
}
