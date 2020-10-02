using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumProject.ImTests
{
    [TestFixture]
    [Category("CloseConversation")]
    class CloseIMConversation : BaseTest
    {
        [Description("Open and close a conversation and assert that the homepage is visible")]
        [Property("Author", "JavanMoe")]
        [Test]
        public void ClosingAnIMConversation()
        {
            MlaMessageToolbarPo mlaMessageToolbarPo = new MlaMessageToolbarPo(Driver);
            LoginTestPo loginTestPo = new LoginTestPo(Driver);
            ImOpenConverastionPo imOpenConverastionPo = new ImOpenConverastionPo(Driver);

            loginTestPo.GoToPage();
            loginTestPo.Login("suser1@devsfb2015.local", "Password1");
            imOpenConverastionPo.OpenAConversationWithSeleniumUser2();
            Assert.IsTrue(imOpenConverastionPo.SeleniumUser2IsVisible);

            mlaMessageToolbarPo.CloseConversationButton();
            Driver.SwitchTo().Frame(0);
            Assert.IsTrue(loginTestPo.MLHeadlinIsVisible);
        }
    }
}
