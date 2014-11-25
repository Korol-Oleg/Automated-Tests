using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace TestDrowz
{
    [TestFixture]
    public class Drowz
    {
        private RemoteWebDriver driver;
        private PageElements _page;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new InternetExplorerDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(25));
            //URL, Login, Password скрыты в целях безопасности данного ресурса
	    driver.Url = "**********";
            _page = new PageElements(driver);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(150));

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void RunTest()
        {

            Actions action = new Actions(driver);
            _page.UserName.SendKeys("********");
            _page.Password.SendKeys("********");
            _page.LoginButtonOk.Click();
            wait.Until(dr => _page.CalendarPresent.Displayed);
            Assert.IsTrue(_page.CalendarPresent.Displayed);
            Assert.IsTrue(_page.PatientsPresent.Displayed);
            Assert.IsTrue(_page.DocumentManagementPresent.Displayed);
            Assert.IsTrue(_page.ReportManagementPresent.Displayed);
            Assert.IsTrue(_page.PrintDocsPresent.Displayed);
            Assert.IsTrue(_page.InventoryPresent.Displayed);
            Assert.IsTrue(_page.SetupPresent.Displayed);
            Assert.IsTrue(_page.TimeTrackingPresent.Displayed);
            _page.SetupPresent.Click();
            wait.Until(dr => _page.Offices.Displayed);
            _page.Offices.Click();
            wait.Until(dr => _page.AddButton.Enabled);
            _page.AddButton.Click();
            wait.Until(dr => _page.PhoneField.Displayed);

            action.DoubleClick(_page.PhoneField);
            action.Perform();
            _page.PhoneField.SendKeys("1234567890");
            _page.AdressLine1Field.SendKeys("Adress1");
            _page.AdressLine2Field.SendKeys("Adress2");
            _page.CityField.SendKeys("Wayne");
            _page.StateSelect.SendKeys("New Jersey");
            _page.ZipCodeField.SendKeys("07470");
            _page.PracticeField.SendKeys("Berlin Family Medicine");
            _page.SleepLabSales.SendKeys("TBD Sales");
            _page.DMESales.SendKeys("TBD Sales");
            _page.StateSelect.SendKeys(Keys.Enter);
            _page.ZipCodeField.SendKeys(Keys.Enter);
            _page.PracticeField.SendKeys(Keys.Enter);
            _page.SleepLabSales.SendKeys(Keys.Enter);
            _page.DMESales.SendKeys(Keys.Enter);
            _page.AddButtonInForm.Click();
            wait.Until(dr => _page.PhysicianOffices.Displayed);
            _page.PracticeFilter.SendKeys("Berlin Family Medicine");
            wait.Until(dr => _page.PhysicianOffices.Displayed);
            _page.ConfirmEntry.Click();
            wait.Until(dr => _page.LastAddedSuccessfully.Displayed);
            wait.Until(dr => _page.PhysicianOffices.Displayed);
            action.DoubleClick(_page.LastAddedSuccessfully);
            action.Perform();
            wait.Until(dr => _page.PhoneField.Displayed);

            Assert.AreEqual("(123) 456-7890", _page.PhoneField.GetValue());
            Assert.AreEqual("Adress1", _page.AdressLine1Field.GetValue());
            Assert.AreEqual("Adress2", _page.AdressLine2Field.GetValue());
            Assert.AreEqual("Wayne", _page.CityField.GetValue());
            Assert.AreEqual("New Jersey", _page.StateSelect.GetValue());
            Assert.AreEqual("07470", _page.ZipCodeField.GetValue());
            Assert.AreEqual("Berlin Family Medicine", _page.PracticeField.GetValue());
            Assert.AreEqual("TBD Sales", _page.SleepLabSales.GetValue());
            Assert.AreEqual("TBD Sales", _page.DMESales.GetValue());
            Assert.AreEqual("Passaic", _page.CountryField.GetValue());

            _page.CancelButtonInForm.Click();
            _page.LastAddedSuccessfully.Click();
            _page.DeleteButton.Click();
            _page.ConfirmDeleteButton.Click();



        }

    }
}
