using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace facebook.PageObjects
{

    public class FbloginPage
    {

        IWebDriver driver;

        public FbloginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);                      
        }

        [FindsBy(How = How.Id, Using = "email")]

        public IWebElement mail { get; set; }

        [FindsBy(How = How.Id, Using = "pass")]

        public IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit'][@value ='Log In']")]

        public IWebElement loginButton { get; set; }

        public void Login()
        {
            mail.SendKeys("9542048044");
            password.SendKeys("djrajesh");
            loginButton.Click();
        }
    }
}
