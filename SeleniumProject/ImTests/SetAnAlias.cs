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
    [Category("Alias")]
    class SetAnAlias : BaseTest
    {
        [Description("Set an alias and assert that it is saved")]
        [Property("Author", "JavanMoe")]
        [Test]
        public void Test()
        {
            var loginTestPo = new LoginTestPo(Driver);
            var openTestRoomPo = new OpenTestRoomPo(Driver);
            var setAnAliasPo = new SetAnAliasPo(Driver);

            loginTestPo.GoToPage();
            loginTestPo.Login("suser1@devsfb2015.local", "Password1");
            openTestRoomPo.FindTestRoom();
            setAnAliasPo.SetAnAlias("TestAliasName");

            Assert.AreEqual("@TestAliasName", Driver.FindElement(By.CssSelector("div.ml-base-button__content.ml-unstyled-button__content")).Text);
        }
    }
}
