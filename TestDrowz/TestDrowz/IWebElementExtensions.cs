using OpenQA.Selenium;

namespace TestDrowz
{
    public static class IWebElementExtensions
    {
        public static string GetValue(this IWebElement element)
        {
            return element.GetAttribute("value");
        }
    }
}
