using System;
using NUnit.Framework;
using TwitterTest.Helper;

namespace TwitterTest.Test
{
    [TestFixture]
    public class TestBase : Browser
    {
        public void RefreshTab()
        {
            Driver().Navigate().Refresh();
        }

        [SetUp]
        public void Setup()
        {
            Driver().Manage().Window.Maximize();
            Driver().Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(25));
        }

        [TearDown]
        public void TearDown()
        {
            CloseDriver();
        }
    }
}
