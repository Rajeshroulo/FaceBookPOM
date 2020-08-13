using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Seleniumfacebook.TestDataAccess;
using System.Threading;

namespace facebook.PageObjects
{

    public class FbloginPage
    {

       public IWebDriver driver;

        public FbloginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);                      
        }

        [FindsBy(How = How.Id, Using = "email")]

        public IWebElement Mail { get; set; }

        [FindsBy(How = How.Id, Using = "pass")]

        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit'][@name ='login']")]

        public IWebElement LoginButton { get; set; }

        public void Login()
        {
            Mail.SendKeys(ExcelDataAccess.GetTestData("TestLoginAndLogout").email);
            Password.SendKeys(ExcelDataAccess.GetTestData("TestLoginAndLogout").password);
            LoginButton.Click();
        }

    }
}
