using NUnit.Framework;
using TwitterTest.Helper;

namespace TwitterTest.Test
{
    abstract class TestBaseUseLogInOut:TestBase
    {
        [SetUp]
        public void LogInSetup()
        {
            home.InputLogAndPass(GetPametrFromConfig.Login, GetPametrFromConfig.Password);
            home.ClickLoginSubmit();
            profile.VerifyLogIn();
        }

        [TearDown]
        public void LogOutTearDown()
        {
            profile.ClickUserMenu();
            profile.ClickLogOut();
            logOutPage.VerifyLogOut();
        }
    }
}
