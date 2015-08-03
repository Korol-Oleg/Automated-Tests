using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TwitterTest.Helper
{
    public class Browser
    {
        private static IWebDriver _driver;
        public static IWebDriver Driver()
        {
            _driver = _driver ?? new ChromeDriver(GetPametrFromConfig.PathToDriver);
            return _driver;
        }

        public static void CloseDriver()
        {
            if (_driver != null) _driver.Quit();
        }

        static readonly Finalizer finalizer = new Finalizer();
        sealed class Finalizer
        {
            ~Finalizer()
            {
                //CloseDriver();
            }
        }
    }
}
