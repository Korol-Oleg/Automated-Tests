using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace TestDrowz
{
    class PageElements
    {
        private readonly RemoteWebDriver _driver;

        public PageElements(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement UserName
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[contains(@name,'MainContent_tfUsername')]"));
            }
        }

        public IWebElement Password
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[contains(@name,'MainContent_tfPassword')]"));
            }
        }

        public IWebElement LoginButtonOk
        {
            get
            {
                return _driver.FindElement(By.XPath("//button[text() = 'Login']"));
            }
        }

        public IWebElement CalendarPresent
        {
            get
            {
                return _driver.FindElement(By.XPath("//button[text() = 'Calendar']"));
            }
        }

        public IWebElement PatientsPresent
        {
            get
            {
                return _driver.FindElement(By.XPath("//button[text() = 'Patients']"));
            }
        }

        public IWebElement DocumentManagementPresent
        {
            get
            {
                return _driver.FindElement(By.XPath("//button[text() = 'Document Management']"));
            }
        }

        public IWebElement ReportManagementPresent
        {
            get
            {
                return _driver.FindElement(By.XPath("//button[text() = 'Report Management']"));
            }
        }

        public IWebElement PrintDocsPresent
        {
            get
            {
                return _driver.FindElement(By.XPath("//button[text() = 'Print Docs.']"));
            }
        }

        public IWebElement InventoryPresent
        {
            get
            {
                return _driver.FindElement(By.XPath("//button[text() = 'Inventory']"));
            }
        }

        public IWebElement SetupPresent
        {
            get
            {
                return _driver.FindElement(By.XPath("//button[text() = 'Setup']"));
            }
        }

        public IWebElement TimeTrackingPresent
        {
            get
            {
                return _driver.FindElement(By.XPath("//button[text() = 'Time Tracking']"));
            }
        }

        public IWebElement Offices
        {
            get
            {
                return _driver.FindElement(By.XPath("//span[text() = 'Offices']"));
            }
        }

        public IWebElement PhysicianOffices
        {
            get
            {
                return _driver.FindElement(By.XPath("//span[text() = 'Physician Offices']"));
            }
        }

        public IWebElement AddButton
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[contains(@id,'PhysicianOffices')]//button[text()='Add' and not(ancestor-or-self::*[contains(@style,'visibility: hidden;')])]"));
            }
        }

        public IWebElement PhoneField
        {
            get
            {
                return _driver.FindElement(By.XPath(
                            "//input[contains(@name,'PhysicianOffices_tfPhone1') and not(ancestor-or-self::*[contains(@style,'visibility: hidden;')])]"));
            }
        }

        public IWebElement AdressLine1Field
        {
            get
            {
                return
                    _driver.FindElement(
                        By.XPath(
                            "//input[contains(@name,'Address_addressLineID') and not(ancestor-or-self::*[contains(@style,'visibility: hidden;')])]"));
            }
        }

        public IWebElement AdressLine2Field
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[contains(@name,'Address_addressLine2ID') and not(ancestor-or-self::*[contains(@style,'visibility: hidden;')])]"));
            }
        }

        public IWebElement CityField
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[contains(@name,'Address_cityID') and not(ancestor-or-self::*[contains(@style,'visibility: hidden;')])]"));
            }
        }

        public IWebElement StateSelect
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[contains(@name,'Address_cbStatesID') and not(ancestor-or-self::*[contains(@type, 'hidden')])]"));
            }
        }
        
        public IWebElement ZipCodeField
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[contains(@name,'Address_zipID') and not(ancestor-or-self::*[contains(@type, 'hidden')])]"));
            }
        }

        public IWebElement CountryField
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[contains(@name,'Address_countyID')]"));
            }
        }

        public IWebElement PracticeField
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[contains(@name,'Offices_cbPractices') and not(ancestor-or-self::*[contains(@type, 'hidden')])]"));
            }
        }

        public IWebElement SleepLabSales
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[contains(@name,'Offices_cbsSalesPerson') and not(ancestor-or-self::*[contains(@type, 'hidden')])]"));
            }
        }

        public IWebElement DMESales
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[contains(@name,'Offices_cbsCssSalesPerson') and not(ancestor-or-self::*[contains(@type, 'hidden')])]"));
            }
        }

        public IWebElement AddButtonInForm
        {
            get
            {
                return _driver.FindElement(By.XPath("//table[contains(@id,'PhysicianOfficesSave')]//button[text()='Add' and not(ancestor-or-self::*[contains(@style,'visibility: hidden;')])]"));
            }
        }

        public IWebElement PracticeFilter
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[contains(@name,'Id_cbPracticeFilter')and not(ancestor-or-self::*[contains(@type, 'hidden')])]"));
            }
        }
        
        public IWebElement LastAddedSuccessfully
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@class='x-grid3-body']/div[last()]//div[text() = 'Berlin Family Medicine']"));
            }
        }

        public IWebElement ConfirmEntry
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@class = 'x-combo-list-item x-combo-selected' and not(ancestor-or-self::*[contains(@style,'visibility: hidden;')])]"));
            }
        }

        public IWebElement CancelButtonInForm
        {
            get
            {
                return _driver.FindElement(By.XPath("//table[contains(@id,'PhysicianOfficesCancel')]//button[text()='Cancel' and not(ancestor-or-self::*[contains(@style,'visibility: hidden;')])]"));
            }
        }

        public IWebElement DeleteButton
        {
            get
            {
                return _driver.FindElement(By.XPath("//table[contains(@id,'Id_bDelete')]//button[text()='Delete' and not(ancestor-or-self::*[contains(@style,'visibility: hidden;')])]"));
            }
        }

        public IWebElement ConfirmDeleteButton
        {
            get
            {
                return _driver.FindElement(By.XPath("//button[text() = 'Yes' and not(ancestor-or-self::*[contains(@style,'visibility: hidden;')])]"));
            }
        }

    }
}
