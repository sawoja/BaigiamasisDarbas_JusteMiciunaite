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
            AddRemoveCart.Open();
        }

        [Test]

        public void FailedLogin()
        {
            RegisterPage.ClickDashboardButton();
            RegisterPage.ClickLogIn();
            RegisterPage.AddEmail();
            RegisterPage.AddPassword();
            RegisterPage.ClickLogIn();

        }
    }
}
