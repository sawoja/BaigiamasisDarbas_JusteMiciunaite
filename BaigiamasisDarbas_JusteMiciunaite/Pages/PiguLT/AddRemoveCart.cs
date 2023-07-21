﻿namespace BaigiamasisDarbas_JusteMiciunaite.Pages.PiguLT
{
    public class AddRemoveCart
    {
        public static void Open()
        {
            Driver.OpenUrl("https://pigu.lt/lt/sofos");
            Common.ClickElement(Locators.AllowCookies.allowCookies);
        }

        public static void ClickAddToCartButton()
        {
            HooverOverItem();
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
            Common.WaitForElementVisible(Locators.AddToCart.shoppingListNotEmpty, 10);
            return Common.GetElementText(Locators.AddToCart.shoppingListNotEmpty);
        }

        public static string CheckItemQuantity()
        {
            return Common.GetAttributeValue(Locators.AddToCart.itemQuantity, "value");
        }

        public static void RemoveItems()
        {
            Common.WaitForElementToBeInvisible("//*[@class='loader-overlay']", 5);
            Common.ClickElement(Locators.AddToCart.buttonRemoveItem);
        }

        public static string GetEmptyCartMessage()
        {
            Common.WaitForElementVisible(Locators.AddToCart.emptyCartMessage, 5);
            return Common.GetElementText(Locators.AddToCart.emptyCartMessage);
        }
    }
}
