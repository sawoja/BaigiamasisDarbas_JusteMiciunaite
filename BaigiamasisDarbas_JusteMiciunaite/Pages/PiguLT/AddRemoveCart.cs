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
        public static string CheckItemQuantity()
        {
            return Common.GetAttributeValue(Locators.AddToCart.itemQuantity, "value");
        }
        public static void RemoveItems()
        {
            Common.WaitForElementVisible(Locators.AddToCart.buttonRemoveItem, 5);
            Common.Remove(Locators.AddToCart.buttonRemoveItem);
        }

        public static string GetEmptyCartMessage()
        {
            return Common.GetEmptyCartMessage(Locators.AddToCart.emptyCartMessage);
        }


    }

}
