using NUnit.Framework;
using OpenQA.Selenium;


namespace SeleniumProject.ImTests
{
    [TestFixture]
    class IMAnOfflineContact : BaseTest
    {
        [Description("Message an offline contact and assert that the conversation is open")]
        [Property("Author", "JavanMoe")]
        [Test]
        public void MessageAnOfflineContact()
        {
            LoginTestPo loginTestPo = new LoginTestPo(Driver);
            ImOpenConverastionPo imOpenConverastionPo = new ImOpenConverastionPo(Driver);
            SendingIMPo imSendingAndReceivingPo = new SendingIMPo(Driver);

            loginTestPo.GoToPage();
            loginTestPo.Login("suser1@devsfb2015.local", "Password1");
            imOpenConverastionPo.OpenAConversationWithSeleniumUser2();
            imSendingAndReceivingPo.SendAMessage("Test Message");

            Assert.IsTrue(imOpenConverastionPo.SeleniumUser2IsVisible);
        }
    }
}
