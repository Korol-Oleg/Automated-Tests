using NUnit.Framework;

namespace TwitterTest.Test
{
    class TwitterTest : TestBaseUseLogInOut
    {
        [Test]
        public void TestWritePost()
        {
            profile.WritePost();
            profile.ClickSendPost();
            profile.VerifyPostCreated();
            profile.DeletePost();
            profile.VerifyPostDeleted();
        }
    }
}