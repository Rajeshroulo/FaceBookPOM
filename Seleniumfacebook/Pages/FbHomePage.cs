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

        [FindsBy(How = How.XPath, Using ="//div[text()='Account Settings']")]

        public IWebElement dropdown { get; set; }

        [FindsBy(How = How.LinkText, Using ="Log Out")]

        public IWebElement logoutButton { get; set; }

        public void Logout()
        {
            Thread.Sleep(2000);
            dropdown.Click();
            logoutButton.Click();
        }

    }
}
