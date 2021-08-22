namespace TestFramework
{
    using OpenQA.Selenium;
    using System;

    public class SignInPage: BasePage
    {
        private string SignInTitle = "Login - My Store";
        public string ValidEmail { get; } = "1@1.1";
        public By EmailFieldCreateBy { get; } = By.XPath("//input[@id='email_create']");
        public By EmailFieldSignInBy { get; } = By.XPath("//*[@id='email']");
        public By PasswordFieldBy { get; } = By.XPath("//input[@id='passwd']");
        public By CreateAccountButtonBy { get; } = By.XPath("//button[@id='SubmitCreate']");
        public By SignInButtonBy { get; } = By.XPath("//*[@id='SubmitLogin']");
        public SignInPage(IWebDriver driver) : base(driver) //constructor
        {
        }
        public override void GoToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
            if (!Driver.Title.Equals(SignInTitle))
            {
                throw new InvalidOperationException("This is not " + SignInTitle + " page," +
                      " current page is: " + Driver.Title);
            }
        }
    }

}
