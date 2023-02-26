using BaigiamasisDarbas_JusteMiciunaite;
using BaigiamasisDarbas_JusteMiciunaite.Pages.PiguLT;
using NUnit.Framework;
using SeleniumTests.BaseClass;
using System;

namespace SeleniumTests.PiguLT
{
    internal class RegisterPageTest : Base
    {

        [SetUp]

        public void Open()
        {
            RegisterPage.Open();
        }

        [Test]

        public void FailedLogin()
        {
            string expectedMessage = "Neteisingi prisijungimo duomenys";

            RegisterPage.ClickDashboardButton();
            RegisterPage.ClickLogIn();
            RegisterPage.AddEmail("emailTest@email.com");
            RegisterPage.AddPassword("password");
            RegisterPage.ClickLogIn();

            string actualMessage = RegisterPage.RegistrationErrorMessage();

            Assert.AreEqual(expectedMessage, actualMessage);

        }

        [Test]

        public void SuccesfullLogin() 
        {
        
        }
    }
}
