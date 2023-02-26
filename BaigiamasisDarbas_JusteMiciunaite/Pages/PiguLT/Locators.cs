using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas_JusteMiciunaite.Pages.PiguLT
{
    internal class Locators

    {
        internal class AddToCart
        {
            internal static string buttonAddToCartWhiteSofa = "//*[@widget-attachpoint='addToCart'][@rel-widget-id='productBlock43640428']";
            internal static string hoverPopup = "//*[@src=\'https://lt2.pigugroup.eu/colours/404/911/53/40491153/sofa-micadoni-home-byron-3s-smelio-spalvos_large.jpg\']";
            internal static string buttonBuy = "//*[@id='buy']";
            internal static string buttonPlusOne = "//*[@widget-attachpoint='changeNumberUp']";
            internal static string buttonRemoveItem = "//i[@class='c-icon--trash']/parent::div";
            internal static string checkCorrectItem = "//div[@class='product-name']/a[@href[contains(.,'43640428')]]";
            internal static string shoppingListNotEmpty = "//*[table[@class='order-table']]";
            internal static string itemQuantity = "//table[@class='order-table']//input[@type='text'][@rel-widget-id[starts-with(.,'productSliceBlock')]]";
            internal static string emptyCartMessage = "//p[contains(.,'Jūsų prekių krepšelis tuščias')]";

        }

        internal class AllowCookies
        {
            internal static string allowCookies = "//button[@widget-attachpoint='agree']";


        }

        internal class Registration
        {
            internal static string buttonDashboard = "//ul[@class=\"c-user-menu\"]//a//i[@class=\"c-icon--profile\"][1]/parent::a";
            internal static string buttonLogin = "//input[@value=\"Prisijungti\"]";
            internal static string inputEmail = "//input[@type=\"email\"]";
            internal static string inputPassword = "//div[@class='pg-password-container']/input[@type=\"password\"][@tabindex=\"2\"]";
            internal static string errorMessage = "//div[@class=\"error-message\"]";
            internal static string buttonRegister = "//a[@rel-widget-id=\"loginModal\"]";
            internal static string inputRepeatPassword = "//input[@name=\"action\" and @value=\"register\"]/following-sibling::div/div/input[@type=\"password\" and @tabindex=\"3\"]";
            internal static string checkboxTC = "//div[contains(@class, 'icheckbox') and contains(@class, 'icheck-item')]";
            internal static string inputEmailRegister = "//input[@name=\"action\" and @value=\"register\"]/following-sibling::div/input[@type=\"email\"]";
            internal static string inputPasswordRegister = "//input[@name=\"action\" and @value=\"register\"]/following-sibling::div/div/input[@type=\"password\"]";
            internal static string approveButton = "//a[@id=\"policiesButtonApprove\"]";
        }
    }
}
