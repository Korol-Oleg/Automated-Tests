using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestGoogleSearch
{
    [TestFixture]
    public class TestGoogleSearch
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new FirefoxDriver();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void GoogleSearch()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            IWebElement query = Driver.FindElement(By.Name("q"));
            query.SendKeys("Wikipedia");
            query.Submit();
            var wikiPresent = Driver.FindElements(By.LinkText("Wikipedia"));

            Assert.IsTrue(wikiPresent != null);
        }
    }
}
