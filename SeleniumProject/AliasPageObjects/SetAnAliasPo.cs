using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class SetAnAliasPo : BaseTest
    {
        public IWebElement AliasButton => Driver.FindElement(By.ClassName("ml-alias-editor__alias-button"));
        public IWebElement SeleniumUser1AliasInputField => Driver.FindElement(By.XPath("//*[contains(@placeholder, 'Selenium User 1')]"));
        public IWebElement SeleniumUser2AliasInputField => Driver.FindElement(By.XPath("//*[contains(@placeholder, 'Selenium User 2')]"));
        
        public SetAnAliasPo(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public void SetAnAlias(string alias)
        {
            AliasButton.Click();
            SeleniumUser1AliasInputField.SendKeys(alias);
            SeleniumUser1AliasInputField.SendKeys(Keys.Enter);
        }
    }
}
