using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumProject
{
    class WebDriverFactory
    {
        public enum BrowserType
        {
            Chrome
        }

        public IWebDriver Create(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return GetChromeDriver();
                default:
                    throw new ArgumentOutOfRangeException("Browser does not exist");
            }
                
        }

        public IWebDriver GetChromeDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("headless");
            chromeOptions.AddArgument("--ignore-certificate-errors");
            chromeOptions.AddArgument("--window-size=1920,1080");
            var outputPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outputPath, chromeOptions);
        }
    }
}
