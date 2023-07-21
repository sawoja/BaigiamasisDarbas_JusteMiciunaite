using System;

namespace BaigiamasisDarbas_JusteMiciunaite.Pages.PiguLT
{
    public class RegisterPage
    {
        public enum RegistrationAction
        {
            Register,
            Login
        }

        public static void Open()
        {
            Driver.OpenUrl("https://pigu.lt/lt/");
            Common.ClickElement(Locators.AllowCookies.allowCookies);
        }

        public static void ClickDashboardButton()
        {
            Common.ClickElement(Locators.Registration.buttonDashboard);
        }

        public static void ClickLogIn()
        {
            Common.ClickElement(Locators.Registration.buttonLogin);
        }
        
        public static void AddEmail(string email, RegistrationAction action)
        {
            string locator = "";

            switch (action)
            {
                case RegistrationAction.Login:
                    locator = Locators.Registration.inputEmail;
                    break;
                case RegistrationAction.Register:
                    locator = Locators.Registration.inputEmailRegister;
                    break;
            }

            Common.SendKeys(locator, email);
        }

        public static void AddPassword(string password, RegistrationAction action)
        {
            string locator = "";

            switch (action)
            {
                case RegistrationAction.Login:
                    locator = Locators.Registration.inputPassword;
                    break;
                case RegistrationAction.Register:
                    locator = Locators.Registration.inputPasswordRegister;
                    break;
            }

            Common.SendKeys(locator, password);
        }

        public static string RegistrationErrorMessage()
        {
            return Common.GetElementText(Locators.Registration.errorMessage);
        }

        public static string RegistrationSuccessMessage()
        {
            return Common.GetElementText(Locators.Registration.messageSuccessfull);
        }

        public static void ClickRegister()
        {
            Common.WaitForElementVisible(Locators.Registration.buttonRegister, 5);
            Common.ClickElement(Locators.Registration.buttonRegister);
        }

        public static void ConfirmRegister()
        {
            Common.WaitForElementVisible(Locators.Registration.buttonFinalRegister, 5);
            Common.ClickElement(Locators.Registration.buttonFinalRegister);
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

        public static string GenerateEmail()
        {
            return $"email{Guid.NewGuid()}@email.com";
        }
    }
}
