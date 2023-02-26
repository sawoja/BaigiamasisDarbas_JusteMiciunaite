using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas_JusteMiciunaite.Pages.PiguLT
{
    public class RegisterPage
    {
        
        public static void Open()
        {
            Driver.OpenUrl("https://pigu.lt/lt/");
            Common.MaximizeWindow();
            Common.AllowCookies(Locators.AllowCookies.allowCookies);



        }

        public static void ClickDashboardButton()
        {
            Common.ClickElement(Locators.Registration.buttonDashboard);
        }

        public static void ClickLogIn()
        {
            Common.ClickElement(Locators.Registration.buttonLogin);
        }

        public static void AddEmail(string email)
        {
            Common.SendKeys(Locators.Registration.inputEmail, email);
        }

        public static void AddPassword(string password)
        {
            Common.SendKeys(Locators.Registration.inputPassword, password);
        }

        public static string RegistrationErrorMessage()
        {
            return Common.GetElementText(Locators.Registration.errorMessage);
        }
    }
}
