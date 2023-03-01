using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace BaigiamasisDarbas_JusteMiciunaite
{
    public class Common
    {
        internal static IWebElement GetElement(string locator)
        {
            IWebDriver drv = Driver.GetDriver();
            return drv.FindElement(By.XPath(locator));
        }
        internal static void AllowCookies(string locator)
        {
            GetElement(locator).Click();
        }
        internal static void Hoover(string locator)
        {
            var popup = GetElement(locator);
            Actions action = new Actions(Driver.GetDriver());
            action.MoveToElement(popup).Perform();
        }
        internal static string WaitForElementVisible(string locator, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(seconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locator)));
            return GetElement(locator).Text;
        }

        public static void Remove(string locator)
        {
            GetElement(locator).Click();
        }

        public static string GetEmptyCartMessage(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }
        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }
        internal static void SendKeys(string locator, string message)
        {
            GetElement(locator).SendKeys(message);
        }

        internal static string GetAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }

        internal static string SendKeys(string valueInputNumbers)
        {
            return SendKeys(valueInputNumbers);
        }

        internal static string Open(string locator)
        {
            return GetElement(locator).Text;
        }
    }
}

