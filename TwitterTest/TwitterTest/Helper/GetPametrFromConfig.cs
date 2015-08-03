using System.Configuration;

namespace TwitterTest.Helper
{
    static class GetPametrFromConfig
    {
        public static string Login = ConfigurationManager.AppSettings.Get("login");
        public static string Password = ConfigurationManager.AppSettings.Get("password");
        public static string PathToDriver = ConfigurationManager.AppSettings.Get("path");
    }
}
