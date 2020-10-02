using NUnit.Framework;

namespace SeleniumProject
{
    [TestFixture]
    [Category("Login")]
    class LoginTest : BaseTest
    {
        [Description("Test that a user can login to MLA")]
        [Property("Author", "JavanMoe")]
        [Test]
        public void Login()
        {
            var loginTestPo = new LoginTestPo(Driver);
            loginTestPo.GoToPage();
            loginTestPo.Login("suser1@devsfb2015.local", "Password1");
            Driver.SwitchTo().Frame(0);
            Assert.IsTrue(loginTestPo.MLHeadlinIsVisible);
        }
    }
}
