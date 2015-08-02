using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AddAdvertToSlando
{
    public class PageElements
    {
        private readonly IWebDriver _driver;

        public PageElements(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement btnMyAccount
        {
            get
            {
                return _driver.FindElement(By.XPath("//a[@id='topLoginLink']"));
            }
        }

        public IWebElement inputEmail
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[@id='userEmail']"));
            }
        }

        public IWebElement inputPassword
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[@id='userPass']"));
            }
        }

        public IWebElement btnLogin
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[@id='se_userLogin']"));
            }
        }

        public IWebElement btnLoggedUserName
        {
            get
            {
                return _driver.FindElement(By.XPath("//strong[text()='okorol.autotest.user']"));
            }
        }

        public IWebElement btnPostFreeAds
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[1]/div[@class = 'inner tcenter']//a/span[text() = 'Подать объявление']"));
            }
        }

        public IWebElement txtTitleToPlaceAnAd
        {
            get
            {
                return _driver.FindElement(By.XPath("//h1[contains(text(), 'Подать бесплатное объявление на OLX')]"));
            }
        }

        public IWebElement fldTitle
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[@id='add-title']"));
            }
        }

        public IWebElement fldGroups
        {
            get
            {
                return _driver.FindElement(By.XPath("//dl[@id='targetrenderSelect1-0']"));
            }
        }

        public IWebElement btnBusinessAndServices
        {
            get
            {
                return _driver.FindElement(By.XPath("//strong[contains(text(), 'Бизнес и услуги')]"));
            }
        }

        public IWebElement listSubGroups
        {
            get
            {
                return _driver.FindElement(By.XPath("//td[text()='Бизнес и услуги']"));
            }
        }

        public IWebElement scrollbar
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@id = 'category-7']//div[@class = 'thumb']"));
            }
        }

        public IWebElement scrollbardown
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@id = 'category-7']//span[@class = 'icon abs scrollbardown']"));
            }
        }

        public IWebElement btnSubGroups
        {
            get
            {
                return _driver.FindElement(By.XPath("//li/a/span[contains(text(),'Прочие услуги')]"));
            }
        }

        public IWebElement slctUserType
        {
            get
            {
                return _driver.FindElement(By.XPath("//dl[@id = 'targetid_private_business']/dt/a"));
            }
        }

        public IWebElement slctPrivatePerson
        {
            get
            {
                return _driver.FindElement(By.XPath("//dd/ul[@style = 'display: block;']/li[2]/a"));
            }
        }

        public IWebElement fldDescription
        {
            get
            {
                return _driver.FindElement(By.XPath("//textarea[@id = 'add-description']"));
            }
        }

        public IWebElement btnPublish
        {
            get
            {
                return _driver.FindElement(By.XPath("//input[@id = 'save']"));
            }
        }

        public IWebElement txtConfirmTitle
        {
            get
            {
                return _driver.FindElement(By.XPath("//p[text() = 'Ваше объявление принято!']"));
            }
        }

        public IWebElement btnAdverts
        {
            get
            {
                return _driver.FindElement(By.XPath("//span[@class='link fbold']/span[text() = 'Объявления']"));
            }
        }

        public IWebElement btnWaiting
        {
            get
            {
                return _driver.FindElement(By.XPath("//a[@class = 'fbold' and contains(text(), 'Ожидающие')]"));
            }
        }

        public IWebElement txtWaitingAdvert
        {
            get
            {
                return _driver.FindElement(By.XPath("//h3[@title = 'Automation test for all']"));
            }
        }

        public IWebElement chckAdvert
        {
            get
            {
                return _driver.FindElement(By.XPath("//div/label[@class = 'icon f_checkbox inlblk vtop']"));
            }
        }

        public IWebElement btnDeleteAdverts
        {
            get
            {
                return _driver.FindElement(By.XPath("//span[text() = 'Удалить выбранные']"));
            }
        }

        public IWebElement txtNotHaveAdverts
        {
            get
            {
                return _driver.FindElement(By.XPath("//h3[text() = 'Нет объявлений']"));
            }
        }

        public IWebElement btnQuit
        {
            get
            {
                return _driver.FindElement(By.XPath("//span[text() = 'Выйти']"));
            }
        }

    }
}
