namespace TestFramework
{
    using NUnit.Framework;

    //dotnet test -l:html;LogFileName=TestOutput.html Console for report

    [TestFixture]
    //[Ignore("")]
    public class TestClass01: Hooks
    {  
        [Test, Category("Smoke"), Property("Priority", 1)]
        [TestCaseSource(typeof(DataUtil), nameof(DataUtil.SearchFieldDataSource))]
        public void CL01_TC01_ValidateSearchField(string dataKeys, string dataXPpath)
        {
            MainPage MainPage = new MainPage(Driver);
            SearchResultPage SearchResultPage = new SearchResultPage(Driver);

            MainPage.GoToUrl(MainPage.UrlMainPage);
            MainPage.SendKeysInField(dataKeys, MainPage.SearchFieldBy);
            MainPage.SubmitElement(MainPage.SearchFieldBy);
            Assert.That(MainPage.FindElementByXpath(dataXPpath).Displayed); 
        }

        [Test, Category("Smoke"), Property("Priority", 1)]
        [TestCaseSource(typeof(DataUtil), nameof(DataUtil.EmailFieldDataSource))]
        public void CL01_TC02_ValidateCreateAccount(string dataKeys, string dataXPath)
        {
            MainPage MainPage = new MainPage(Driver);
            SignInPage SignInPage = new SignInPage(Driver);

            MainPage.GoToUrl(MainPage.UrlMainPage);
            MainPage.ClickOnElement(MainPage.SignInLinkBy);
            SignInPage.SendKeysInField(dataKeys, MainPage.SearchFieldBy);
            SignInPage.SubmitElement(SignInPage.CreateAccountButtonBy);
            SignInPage.WaitUntillElement(dataXPath);
            Assert.That(SignInPage.FindElementByXpath(dataXPath).Displayed);         
        }

        [Test, Category("Smoke"), Property("Priority", 2)]
        [TestCaseSource(typeof(DataUtil), nameof(DataUtil.PasswordFieldDataSource))]
        public void CL01_TC03_ValidatePassword(string dataKeys, string dataXPath)
        {
            MainPage MainPage = new MainPage(Driver);
            SignInPage SignInPage = new SignInPage(Driver);

            MainPage.GoToUrl(MainPage.UrlMainPage);
            MainPage.ClickOnElement(MainPage.SignInLinkBy);
            SignInPage.SendKeysInField(SignInPage.ValidEmail, SignInPage.EmailFieldSignInBy);
            SignInPage.SendKeysInField(dataKeys, SignInPage.PasswordFieldBy);
            SignInPage.SubmitElement(SignInPage.SignInButtonBy);
            SignInPage.WaitUntillElement(dataXPath);
            Assert.That(SignInPage.FindElementByXpath(dataXPath).Displayed);
        }
    }
}
