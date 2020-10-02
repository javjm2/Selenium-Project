using SeleniumProject.ImPageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class ImOpenConverastionPo : BasePageObject
    {
        private By WaitForSeleniumUser1 = By.XPath("//*[contains(@aria-label,'Selenium User 1')]");
        private By WaitForSeleniumUser2 = By.XPath("//*[contains(@aria-label,'Selenium User 2')]");
        private IWebElement SeleniumUser1 => Driver.FindElement(By.XPath("//*[contains(@aria-label,'Selenium User 1')]"));
        private IWebElement SeleniumUser2 => Driver.FindElement(By.XPath("//*[contains(@aria-label,'Selenium User 2')]"));
        public bool SeleniumUser1IsVisible => Driver.FindElement(By.XPath("//*[contains(@title,'Selenium User 1')]")).Displayed;
        public bool SeleniumUser2IsVisible => Driver.FindElement(By.XPath("//*[contains(@title,'Selenium User 2')]")).Displayed;


        public ImOpenConverastionPo(IWebDriver driver) : base(driver) { }

        public void OpenAConversationWithSeleniumUser1()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(WaitForSeleniumUser1));
            SeleniumUser1.Click();
        }

        public void OpenAConversationWithSeleniumUser2()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(WaitForSeleniumUser2));
            SeleniumUser2.Click();
        }
    }
}
