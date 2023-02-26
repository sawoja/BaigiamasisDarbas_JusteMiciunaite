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
        [Test]
        public void SingleInputField()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            string expectedResult = "First field test";
            IWebElement inputEnterMessage = driver.FindElement(By.XPath("//*[@id='user-message']"));
            IWebElement buttonShowMessage = driver.FindElement(By.XPath("//*[@id=\"get-input\"]/button"));
            IWebElement spanMessage = driver.FindElement(By.XPath("//*[@id=\"display\"]"));

            inputEnterMessage.SendKeys(expectedResult);
            buttonShowMessage.Click();
            driver.Quit();

        }
    }
}
