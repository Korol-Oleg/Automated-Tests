using System.Threading;
using NUnit.Framework;
using TwitterTest.Helper;
using TwitterTest.Pages;

namespace TwitterTest.Test
{
    class TwitterTest : TestBase
    {
        [Test]
        public void Test()
        {
            Driver().Url = "https://twitter.com/";
            HomePage home = new HomePage();
            home.InputLogAndPass(LoginData.Login, LoginData.Password);

            ProfilePage profile = home.ClickLoginSubmit();
            profile.VerifyLogIn();
            profile.WritePost();
            profile.ClickSendPost();
            profile.VerifyPostCreated();
            profile.DeletePost();
            profile.VerifyPostDeleted();
            profile.ClickUserMenu();
            LogOutPage logOutPage = profile.ClickLogOut();
            logOutPage.VerifyLogOut();
        }
    }
}
