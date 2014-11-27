using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace AddAdvertToSlando
{
    [Binding]
    public class AddAdvertSteps
    {
        private IWebDriver driver;
        private PageElements _page;
        private WebDriverWait wait;
        private Actions action;

        [BeforeScenario()]
        public void Setup()
        {

            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(25));
            _page = new PageElements(driver);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(150));
            action = new Actions(driver);
        }

        //[AfterScenario()]
        //public void TearDown()
        //{
        //    driver.Quit();
        //}

        [Given(@"that I open page  ""(.*)""")]
        public void GivenThatIOpenPage(string Url)
        {
            driver.Url = Url;
        }
        
        [When(@"I click ""(.*)""")]
        public void WhenIClick(string clickToElement)
        {
            wait.Until(el=>_page.GetProperty(clickToElement).Enabled);
            _page.GetProperty(clickToElement).Click();
        }
        
        [When(@"I write ""(.*)"" to ""(.*)""")]
        public void WhenIWriteTo(string text, string fieldToWrite)
        {
            wait.Until(el=>_page.GetProperty(fieldToWrite).Enabled);
            _page.GetProperty(fieldToWrite).SendKeys(text);

        }
        
        [When(@"I see ""(.*)""")]
        public void WhenISee(string element)
        {
            wait.Until(el=>_page.GetProperty(element).Displayed);
            Assert.IsNotNull(_page.GetProperty(element));
        }
        
        [When(@"I scroll ""(.*)"" to ""(.*)""")]
        public void WhenIScrollTo(string elem1, string elem2)
        {
            wait.Until(el => _page.GetProperty(elem1).Displayed);
            wait.Until(el => _page.GetProperty(elem2).Displayed);
            action.DragAndDrop(_page.GetProperty(elem1), _page.GetProperty(elem2)).Perform();
        }
        
        [When(@"I move to ""(.*)""")]
        public void WhenIMoveTo(string moveToElement)
        {
            wait.Until(el => _page.GetProperty(moveToElement).Enabled);
            action.MoveToElement(_page.GetProperty(moveToElement)).Build().Perform();
        }
        
        [Then(@"I see ""(.*)""")]
        public void ThenISee(string element)
        {
            wait.Until(el => _page.GetProperty(element).Displayed);
            Assert.IsNotNull(_page.GetProperty(element));
        }
    }
}
