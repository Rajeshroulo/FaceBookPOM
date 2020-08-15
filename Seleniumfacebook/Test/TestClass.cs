// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using facebook;
using facebook.PageObjects;
using NUnit.Framework;
using System;

namespace Seleniumfacebook
{
    [TestFixture]
    public class FaceBook : FBBase
    {
        [Test,Order(1)]
        public void FaceBookLogin()
        {
            var loginpage = new FbloginPage(driver);
            loginpage.Login();
        }

        [Test,Order(2)]
        public void PostAStory()
        {
           
            var homepage = new FbHomePage(driver);
            homepage.PostStory();

            Assert.AreEqual("(15) Facebook", driver.Title);

        }

    }
}
