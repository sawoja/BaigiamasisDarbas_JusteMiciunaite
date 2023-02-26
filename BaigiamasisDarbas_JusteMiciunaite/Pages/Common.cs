using OpenQA.Selenium;

namespace BaigiamasisDarbas_JusteMiciunaite
{
    public class Common
    {
        
        internal static void MaximizeWindow()
        {
            Driver.GetDriver().Manage().Window.Maximize();
        }
        internal static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
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

