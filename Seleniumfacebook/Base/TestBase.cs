using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace facebook
{
    public  class TestBase
    {
      public  IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");

            driver = new ChromeDriver(options);
            driver.Url = "http://www.facebook.com/";
            driver.Manage().Window.Maximize();           
        }

        [TearDown]
        public void CloseBrowser()
        {
            Thread.Sleep(5000);
            driver.Quit();
        }

    }
}
