using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.IO;

namespace BaigiamasisDarbas_JusteMiciunaite
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void SetupDriver()
        {
            driver = new ChromeDriver();
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void OpenUrl(string url)
        {
            driver.Url = url;
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }

        public static void TakeScreenshot()
        {
            string screenshotsDirectory = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            string screenshotName = $"screenshot_{Guid.NewGuid()}.png";
            string screenshotFilePath = $"{screenshotsDirectory}\\{screenshotName}";

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            Directory.CreateDirectory(screenshotsDirectory);
            screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
        }
    }
}
