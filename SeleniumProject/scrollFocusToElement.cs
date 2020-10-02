using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Program
    {
        String url = "https://www.google.com/search?q=test&oq=test&aqs=chrome..69i57.815j0j4&sourceid=chrome&ie=UTF-8";

        [Test]
        public void scrollFocusToElement()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            IWebElement link = driver.FindElement(By.ClassName("LC20lb DKV0Md"));
            int linkpos = link.Location.Y;

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0," + linkpos + "),");

            link.Click();

            Thread.Sleep(2000);

            driver.Quit();
        }
    }
}
