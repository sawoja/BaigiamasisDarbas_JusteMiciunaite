using BaigiamasisDarbas_JusteMiciunaite;
using BaigiamasisDarbas_JusteMiciunaite.Pages.PiguLT;
using NUnit.Framework;
using SeleniumTests.BaseClass;
using System;

namespace SeleniumTests.PiguLT
{
    internal class AddRemoveCartTest : Base
    {
        [SetUp]

        public void Open()
        {
            AddRemoveCart.Open();
        }

        [Test]
        public void CorrectItemAddedToCart()
        {
            string expectedMessage = "Prekė";
            AddRemoveCart.HooverOverItem();
            AddRemoveCart.ClickAddToCartButton();
            AddRemoveCart.ClickButtonBuy();

            string actualMessage = AddRemoveCart.ShoppingCartNotEmpty();
            //krepselis ne tuscias
            Assert.AreNotEqual(actualMessage, "");

            
        }
    }
}
