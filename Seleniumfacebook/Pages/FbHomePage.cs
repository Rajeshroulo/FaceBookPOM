using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace facebook
{
   public class FbHomePage
   {
        IWebDriver driver;

        public FbHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "hu5pjgll lzf7d6o1 sp_9v2_9kG0o8E sx_8a7360")]

        public IWebElement dropdown { get; set; }

       



        public void Create()
        {
            Thread.Sleep(3000);
            dropdown.Click();
        }

    }
}
