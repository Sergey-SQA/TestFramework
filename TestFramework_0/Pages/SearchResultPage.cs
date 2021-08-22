namespace TestFramework
{
    using OpenQA.Selenium;
    using System;

    public class SearchResultPage: BasePage
    {
        private string SearchResultTitle = "Search - My Store"; 
        public SearchResultPage(IWebDriver driver) : base(driver)
        {
        }
        public override void GoToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
            if (!Driver.Title.Equals(SearchResultTitle))
            {
                throw new InvalidOperationException("This is not " + SearchResultTitle + " page," +
                      " current page is: " + Driver.Title);
            }
        }
    }

}
