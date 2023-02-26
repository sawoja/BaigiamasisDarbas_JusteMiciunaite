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
    internal class RegisterPage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://pigu.lt/lt/");
            Common.MaximizeWindow();
            Common.AllowCookies(Locators.AllowCookies.allowCookies);



        }
    }
}
