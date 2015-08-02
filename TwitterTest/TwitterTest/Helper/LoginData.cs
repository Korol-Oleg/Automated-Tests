using System.Configuration;

namespace TwitterTest.Helper
{
    static class LoginData
    {
        public static string Login = ConfigurationManager.AppSettings.Get("login");
        public static string Password = ConfigurationManager.AppSettings.Get("password");
    }
}
