using SeleniumProject.ImPageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class MlaMessageToolbarPo : BasePageObject
    {
        private IWebElement CloseButton => Driver.FindElement(By.XPath("//button[contains(@title,'Close conversation')]"));

        public MlaMessageToolbarPo(IWebDriver driver) : base(driver) { }

        public void CloseConversationButton()
        {
            CloseButton.Click();
        }
    }
}
