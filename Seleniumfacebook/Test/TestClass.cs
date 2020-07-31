// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using facebook;
using facebook.PageObjects;
using NUnit.Framework;

namespace Seleniumfacebook
{
    [TestFixture]
    public class FaceBook : TestBase
    {
        [Test]
        public void TestLoginAndLogout()
        {
           var loginpage= new FbloginPage(driver);
             loginpage.Login();

            var homepage = new FbHomePage(driver);
            homepage.Logout();
            Thread.Sleep(2000);
            }

       
        

    }
}
