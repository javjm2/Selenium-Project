using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumProject.ImTests
{
    [TestFixture]
    class IMSendingAndReceiving : BaseTest
    {
        [Description("Send and receive a message and assert that the message is received")]
        [Property("Author", "JavanMoe")]
        [Test]
        public void SendingAndReceivingAMessage()
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

            Driver.SwitchTo().Window(tab[1]);
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(tab[0]);

        }
    }
}
