using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using System.Threading;
using static SeleniumProject.WebDriverFactory;

namespace SeleniumProject
{
    [TestFixture]
    class LoginTestSSL :BaseTest
    {
        private ChromeOptions options;

        [Test]
        [Description("Test that users can login to MLA")]
        public void Login()
        {
            var loginTestPo = new LoginTestPo(Driver);

            loginTestPo.GoToPage();
            loginTestPo.Login("suser1@devsfb2015.local", "Password1");
            Driver.SwitchTo().Frame(0);

            Assert.IsTrue(loginTestPo.MLHeadlinIsVisible);
            Screenshot image = ((ITakesScreenshot)Driver).GetScreenshot();
            image.SaveAsFile("C:/Selenium/screenshots/Chrome/Login/Login.png");
        }

        public IWebDriver GetChromeDriver()
        {
            options = new ChromeOptions();
            options.AddArguments("--ignore-certificate-errors");
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options));
            return new ChromeDriver();
        }
    }
}
