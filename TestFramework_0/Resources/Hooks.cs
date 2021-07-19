namespace TestFramework
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;

    public class Hooks
    {
        public IWebDriver Driver { get; private set; }

        [SetUp]
        public void SetUp()//must be non-static
        {
            Driver = new ChromeDriver();
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Manage().Window.Maximize();
        }

        [TearDown]//must be non-static
        public void TearDown()
        {
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Close();
        }

     
    }       
}
