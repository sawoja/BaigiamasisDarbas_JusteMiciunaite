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
            RegisterPage.AddEmail("emailTest@email.com", 1);
            RegisterPage.AddPassword("password", 1);
            RegisterPage.ClickLogIn();

            string actualMessage = RegisterPage.RegistrationErrorMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void SuccesfullRegistration()
        {
            Random rnd = new Random();
            int skaicius = rnd.Next(1, 10);

            string expectedMessage = "Vienkartinis 6 skaitmenų patvirtinimo kodas išsiųstas adresu: emailTest+" + skaicius + "@email.com\r\nKeisti el. pašto adresą";

            RegisterPage.ClickDashboardButton();
            RegisterPage.ClickRegister();
            RegisterPage.AddEmail("emailTest+" + skaicius + "@email.com", 2);
            RegisterPage.AddPassword("password", 2);
            RegisterPage.RepeatPassword("password");
            RegisterPage.MarkCheckbox();
            RegisterPage.ClickApprove();
            RegisterPage.ConfirmRegister();

            string actualMessage = RegisterPage.RegistrationSuccessMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
