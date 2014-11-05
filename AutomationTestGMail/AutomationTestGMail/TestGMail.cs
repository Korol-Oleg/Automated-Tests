using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace AutomationTestGMail
{
    [TestFixture]
    public class TestGMail
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
        public void AuthorizationInGMail()
        {
            Driver.Navigate().GoToUrl("http://www.gmail.com");
            
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));


            IWebElement loginField = Driver.FindElement(By.Name("Email"));
            loginField.SendKeys("okorol.autotest.user");
            IWebElement passwordField = Driver.FindElement(By.Name("Passwd"));
            passwordField.SendKeys("rjhjkmjktu");
            Driver.FindElement(By.Name("signIn")).Click();
            IWebElement userPresent = Driver.FindElement(By.LinkText("okorol.autotest.user@gmail.com"));
            Assert.IsTrue(userPresent.Displayed);

            IWebElement sendMail = Driver.FindElement(By.XPath("//div[@class='z0']"));
            sendMail.Click();

            Driver.FindElement(By.Name("to")).SendKeys("okorol.autotest.user@gmail.com");
            Driver.FindElement(By.Name("subjectbox")).SendKeys("Test");
            Driver.FindElement(By.XPath("//div[@class='Am Al editable LW-avf']")).SendKeys("test");
            Driver.FindElement(By.XPath("//div[contains(@data-tooltip,'Enter')]")).Click();

            IWebElement outboxMail = Driver.FindElement(By.XPath("//a[@href = 'https://mail.google.com/mail/#sent']"));
            outboxMail.Click();
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            IWebElement sendMailSuccessfulInOutbox = Driver.FindElement(By.XPath("//div[2]/span/b[text() = 'Test']"));
            Assert.IsTrue(sendMailSuccessfulInOutbox.Displayed);
            
            IWebElement inboxMail = Driver.FindElement(By.XPath("//a[@href = 'https://mail.google.com/mail/#inbox']"));
            inboxMail.Click();

            //Знаю что это плохо, но иначе ожидания не срабатывают(( может кто предложит идею?
            Thread.Sleep(1000);
            
            IWebElement sendMailSuccessfulInInbox = Driver.FindElement(By.XPath("//div[@class='y6']/span/b"));
            Assert.IsTrue(sendMailSuccessfulInInbox.Displayed);
            sendMailSuccessfulInInbox.Click();
        }
    }
}
