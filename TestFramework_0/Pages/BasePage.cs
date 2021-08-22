namespace TestFramework
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;

    public class BasePage
    {
        public IWebDriver Driver { get; }

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }
        //Business methods:
        public virtual void GoToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public virtual void SendKeysInField(string input, By locator)
        {
            IWebElement element = Driver.FindElement(locator);
            element.SendKeys(input);
        }

        public virtual void ClickOnElement(By locator)
        {
            IWebElement element = Driver.FindElement(locator);
            element.Click();
        }

        public virtual void SubmitElement(By locator)
        {
            IWebElement element = Driver.FindElement(locator);
            element.Submit();
            //element.SendKeys(Keys.Enter); Enum for keyboard emulation
        }

        public virtual void WaitUntillElement(string xpath)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(xpath)));
        }

        public virtual IWebElement FindElementByXpath(string xpath)
        {
            return Driver.FindElement(By.XPath(xpath));
        }
    }
}
