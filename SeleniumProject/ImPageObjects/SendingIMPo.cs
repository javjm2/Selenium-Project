using SeleniumProject.ImPageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class SendingIMPo : BasePageObject
    {
        private IWebElement MessageInputField => Driver.FindElement(By.ClassName("ml-message-input-editor"));
        private IWebElement MessageComposer => Driver.FindElement(By.XPath("//*[contains(@data-text, 'true')]"));
        private IWebElement SendMessageButton => Driver.FindElement(By.XPath("//*[contains(@title,'Send message')]"));
        public bool TypingIndicatorIsVisible => Driver.FindElement(By.XPath("//*[contains(@title,'Someone is typing a message')]")).Displayed;

        public SendingIMPo(IWebDriver driver) : base(driver) { }

        public void TypeAMessage(String typeingMessage)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MessageInputField));
            MessageComposer.SendKeys(typeingMessage);
        }

        public void SendAMessage(String message)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MessageInputField));
            MessageComposer.SendKeys(message);
            SendMessageButton.Click();
        }
    }
}
