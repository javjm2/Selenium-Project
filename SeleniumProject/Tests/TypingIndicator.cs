using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumProject.ImTests
{
    class TypingIndicator : BaseTest
    {
        [Description("Test that the typing indicator appears and assert that it is displayed")]
        [Property("Author", "JavanMoe")]
        [Test]
        public void IMTypingIndicator()
        {
            LoginTestPo loginTestPo = new LoginTestPo(Driver);
            ImOpenConverastionPo imOpenConverastionPo = new ImOpenConverastionPo(Driver);
            SendingIMPo imSendingAndReceivingPo = new SendingIMPo(Driver);

            loginTestPo.GoToPage();
            loginTestPo.Login("suser1@devsfb2015.local", "Password1");
            imOpenConverastionPo.OpenAConversationWithSeleniumUser2();
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.open()");
            var tab = Driver.WindowHandles;
            Driver.SwitchTo().Window(tab[1]);

            loginTestPo.GoToPage();
            loginTestPo.Login("suser2@devsfb2015.local", "Password1");
            imOpenConverastionPo.OpenAConversationWithSeleniumUser1();

            Driver.SwitchTo().Window(tab[0]);
            imSendingAndReceivingPo.SendAMessage("Test Message");
            imSendingAndReceivingPo.TypeAMessage("Test Message");
            Driver.SwitchTo().Window(tab[1]);

            Assert.IsTrue(imSendingAndReceivingPo.TypingIndicatorIsVisible);
        }
    }
}
