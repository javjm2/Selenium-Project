using SeleniumProject.ImPageObjects;
using OpenQA.Selenium;
using System;


namespace SeleniumProject
{
    class LoginTestPo : BasePageObject
    {
        private IWebElement UserNameField => Driver.FindElement(By.XPath("//input[@autocomplete='username']"));
        private IWebElement PasswordField => Driver.FindElement(By.XPath("//input[@name='password']"));
        private IWebElement LoginButton => Driver.FindElement(By.XPath("//button[@type='submit']"));
        public bool MLHeadlinIsVisible => Driver.FindElement(By.ClassName("ml-title__headline")).Text.Contains("MindLink");

        public By WaitForUserNameField = By.XPath("//input[@autocomplete='username']");
        public By HomeIFrame = By.ClassName("ml-home__frame");

        public LoginTestPo(IWebDriver driver) : base(driver) { }

        public void GoToPage()
        {
            Driver.Navigate().GoToUrl("https://devsfb2015appe.devsfb2015.local:9080/#/");
        }

        public void Login(String username, String password)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(WaitForUserNameField));
            UserNameField.SendKeys(username);
            PasswordField.SendKeys(password);
            LoginButton.Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(HomeIFrame));
        }
    }
}
