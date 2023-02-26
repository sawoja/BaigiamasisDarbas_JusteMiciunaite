using System;

namespace BaigiamasisDarbas_JusteMiciunaite.Pages.PiguLT
{
    public class AddRemoveCart
    {
        public static void Open()
        {
            Driver.OpenUrl("https://pigu.lt/lt/sofos");
            Common.MaximizeWindow();
            Common.AllowCookies(Locators.AllowCookies.allowCookies);



        }



        public static void ClickAddToCartButton()
        {
            Common.ClickElement(Locators.AddToCart.buttonAddToCartWhiteSofa);
        }
        public static void ClickButtonBuy()
        {
            Common.WaitForElementVisible(Locators.AddToCart.buttonBuy, 10);
            Common.ClickElement(Locators.AddToCart.buttonBuy);
        }

        public static void ClickButtonPlusOne()
        {
            Common.ClickElement(Locators.AddToCart.buttonPlusOne);
        }
        public static void ClickButtonRemoveItem()
        {
            Common.ClickElement(Locators.AddToCart.buttonRemoveItem);
        }

        public static void HooverOverItem()
        {
            Common.Hoover(Locators.AddToCart.hoverPopup);
        }

        public static string ShoppingCartNotEmpty()
        {
            return Common.WaitForElementVisible(Locators.AddToCart.shoppingListNotEmpty, 10);
        }



    }

}
