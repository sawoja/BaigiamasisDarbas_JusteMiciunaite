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
            RegisterPage.AddEmail("emailTest@email.com", RegisterPage.RegistrationAction.Login);
            RegisterPage.AddPassword("password", RegisterPage.RegistrationAction.Login);
            RegisterPage.ClickLogIn();

            string actualMessage = RegisterPage.RegistrationErrorMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void SuccesfullRegistration()
        {
            string email = RegisterPage.GenerateEmail();
            string expectedMessage = $"Vienkartinis 6 skaitmenų patvirtinimo kodas išsiųstas adresu: {email}\r\nKeisti el. pašto adresą";

            RegisterPage.ClickDashboardButton();
            RegisterPage.ClickRegister();
            RegisterPage.AddEmail(email, RegisterPage.RegistrationAction.Register);
            RegisterPage.AddPassword("password", RegisterPage.RegistrationAction.Register);
            RegisterPage.RepeatPassword("password");
            RegisterPage.MarkCheckbox();
            RegisterPage.ClickApprove();
            RegisterPage.ConfirmRegister();

            string actualMessage = RegisterPage.RegistrationSuccessMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
