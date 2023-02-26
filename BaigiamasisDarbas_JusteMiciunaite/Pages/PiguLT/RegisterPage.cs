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

        public static void AddEmail(string email, int regway)
        {
            if (regway == 1)
            {
                Common.SendKeys(Locators.Registration.inputEmail, email);
            }
            else if (regway == 2)
            {
                Common.SendKeys(Locators.Registration.inputEmailRegister, email);
            }
        }

        public static void AddPassword(string password, int regway)
        {
            if (regway == 1)
            {
                Common.SendKeys(Locators.Registration.inputPassword, password);
            }
            else if (regway == 2)
            {
                Common.SendKeys(Locators.Registration.inputPasswordRegister, password);
            }

        }

        public static string RegistrationErrorMessage()
        {
            return Common.GetElementText(Locators.Registration.errorMessage);
        }

        public static void ClickRegister()
        {
            Common.WaitForElementVisible(Locators.Registration.buttonRegister, 5);
            Common.ClickElement(Locators.Registration.buttonRegister);
        }

        public static void RepeatPassword(string password)
        {
            Common.SendKeys(Locators.Registration.inputRepeatPassword, password);
        }

        public static void MarkCheckbox()
        {
            Common.ClickElement(Locators.Registration.checkboxTC);
        }

        public static void ClickApprove()
        {
            Common.ClickElement(Locators.Registration.approveButton);
        }
    }
}
