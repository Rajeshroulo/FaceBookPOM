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

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/span[1]")]
        public IWebElement Create;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]")]
       
        public IWebElement Content;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[2]/div[1]/div[2]/span[1]/div[1]/div[1]/div[1]/div[1]/div[1]/i[1]")]
        public IWebElement Photo;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Post')]")]
        public IWebElement Post;

        public void PostStory()
        {
            Thread.Sleep(3000);
            Create.Click();
            Thread.Sleep(5000);
            Content.SendKeys("automation");
            Thread.Sleep(5000);
            Photo.Click();

            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");
            Thread.Sleep(2000);

            autoIt.Send(@"C:\Users\HP\Downloads\automation.jpg");

            Thread.Sleep(5000);
            autoIt.Send("{ENTER}");

            Thread.Sleep(5000);
            Post.Click();
        }

    }
}
