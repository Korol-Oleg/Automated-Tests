using NUnit.Framework;
using TwitterTest.Helper;

namespace TwitterTest.Test
{
    class TwitterTest : TestBase
    {
        [Test]
        public void Test()
        {
            home.InputLogAndPass(LoginData.Login, LoginData.Password);
            home.ClickLoginSubmit();
            profile.VerifyLogIn();
            profile.WritePost();
            profile.ClickSendPost();
            profile.VerifyPostCreated();
            profile.DeletePost();
            profile.VerifyPostDeleted();
            profile.ClickUserMenu();
            profile.ClickLogOut();
            logOutPage.VerifyLogOut();
        }
    }
}
