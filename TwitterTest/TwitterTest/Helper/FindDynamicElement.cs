using OpenQA.Selenium;

namespace TwitterTest.Helper
{
    static class FindDynamicElement
    {
        public static IWebElement FindTextPost(string textPost)
        {
            return Browser.Driver().FindElement(By.XPath(string.Format
                ("//div[@data-user-id = '3398606787']//div[@class = 'content']/p[text() = '{0}']", textPost)));
        }

        public static IWebElement FindDropMenuInPost(string textPost)
        {
            return Browser.Driver().FindElement(By.XPath
                (string.Format("//div[@class = 'content' and descendant-or-self::*[text() = '{0}']]//button[@class = " +
                        "'ProfileTweet-actionButton u-textUserColorHover dropdown-toggle js-tooltip js-dropdown-toggle']",textPost)));
        }
    }
}
