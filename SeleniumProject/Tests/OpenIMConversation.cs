using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumProject
{
    [TestFixture]
    [Category("OpenAnIMConversation")]
    class OpenIMConversationm : BaseTest
    {
        [Description("Open a converastion and assert that it's open")]
        [Property("Author", "JavanMoe")]
        [Test]
        public void OpenAnIMConversation()
        {
            LoginTestPo loginTestPo = new LoginTestPo(Driver);
            ImOpenConverastionPo imOpenConverastionPo = new ImOpenConverastionPo(Driver);

            loginTestPo.GoToPage();
            loginTestPo.Login("suser1@devsfb2015.local", "Password1");
            imOpenConverastionPo.OpenAConversationWithSeleniumUser2();

            Assert.IsTrue(imOpenConverastionPo.SeleniumUser2IsVisible);
        }
    }
}
