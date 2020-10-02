using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Reflection;
namespace SeleniumProject
{
    internal class BaseTest
    {
        protected IWebDriver Driver { get; set; }
        public WebDriverWait wait { get; set; }

        [SetUp]
        public void SetUp()
        {
            Driver = new WebDriverFactory().Create(WebDriverFactory.BrowserType.Chrome);
        }

        [TearDown]
        public void TearDown()
        {
            string methodName = TestContext.CurrentContext.Test.Name;
            Screenshot image = ((ITakesScreenshot)Driver).GetScreenshot();
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            image.SaveAsFile($"{path}../../../../SeleniumProject/SeleniumScreenshots/{methodName}.png");
            Driver.Quit();
        }
    }
}