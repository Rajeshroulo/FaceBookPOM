using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using AutoItX3Lib;

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

        public IWebElement Create { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='mount_0_0']/div/div/div[1]/div[4]/div/div/div[1]/div/div[2]/div/div/div/form/div/div[1]/div/div[2]/div[2]/div[1]/div[1]/div[1]/div/div/div/div/div[2]/div/div/div/div")]
       
        public IWebElement Content { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='mount_0_0']/div/div/div[1]/div[4]/div/div/div[1]/div/div[2]/div/div/div/form/div/div[1]/div/div[2]/div[3]/div[1]/div[2]/div/div[2]/span/div/div/div/div/div[1]/i")]

        public IWebElement Photo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='mount_0_0']/div/div/div[1]/div[4]/div/div/div[1]/div/div[2]/div/div/div/form/div/div[1]/div/div[2]/div[3]/div[2]/div")]

        public IWebElement Post { get; set; }

        public void Created()
        {
            Create.Click();
            Thread.Sleep(2000);
            Content.SendKeys("Working on automation");
            Photo.Click();

            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");

            autoIt.Send(@"C:\Users\HP\Downloads\automation.jpg");

            Thread.Sleep(1000);
            autoIt.Send("{ENTER}");

            Post.Click();
        }

    }
}
