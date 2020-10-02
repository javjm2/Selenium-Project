using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.ImPageObjects
{
    class BasePageObject
    {
        protected IWebDriver Driver { get; set; }
        protected WebDriverWait wait { get; private set; }
        
        public BasePageObject(IWebDriver driver)
        {
            Driver = driver;
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
        }
    }
}
