using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace facebook
{
    public class FbHomePage
    {
      public IWebDriver driver;

        public FbHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='mount_0_0']/div/div/div[1]/div[3]/div/div/div[1]/div[1]/div/div[2]/div/div/div[3]/div/div[2]/div/div/div/div[1]/div/div[1]/div")]

        public IWebElement create { get; set; }

        public void Create()
        {
            create.Click();
        }

    }
}
