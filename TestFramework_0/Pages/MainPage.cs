namespace TestFramework
{
    using OpenQA.Selenium;
    using System;

    public class MainPage : BasePage
    {
        public By SearchFieldBy { get; } = By.XPath("//*[@id='search_query_top']");
        public By SignInLinkBy { get; } = By.XPath("//a[contains(text(),'Sign in')]");
        public string UrlMainPage { get; } = "http://automationpractice.com/index.php";

        private string MainPageTitle = "My Store";

        public MainPage(IWebDriver driver) : base(driver)
        {
        }
        public override void GoToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
            if (!Driver.Title.Equals(MainPageTitle))
            {
                throw new InvalidOperationException("This is not "+MainPageTitle+" page," +
                      " current page is: " + Driver.Title);
            }
        }

    }

}
