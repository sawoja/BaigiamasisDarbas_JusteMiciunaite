using System;

namespace BaigiamasisDarbas_JusteMiciunaite.Pages.PiguLT
{
    public class AddRemoveCart
    {
        public static void Open()
        {
            Driver.OpenUrl("https://pigu.lt/lt/sofos");
            Common.MaximizeWindow();



        }

        public static void ClickAddToCartButton()
        {
            Common.ClickElement(Locators.AddToCart.buttonAddToCartWhiteSofa);
        }
        public static void ClickButtonBuy() 
        {
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

        
    }

}
