using BaigiamasisDarbas_JusteMiciunaite.Pages.PiguLT;
using NUnit.Framework;
using SeleniumTests.BaseClass;

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
            AddRemoveCart.ClickAddToCartButton();
            AddRemoveCart.ClickButtonBuy();

            string actualMessage = AddRemoveCart.ShoppingCartNotEmpty();
            //krepselis ne tuscias
            Assert.AreNotEqual(actualMessage, "");

            string quantity = AddRemoveCart.CheckItemQuantity();
            Assert.AreEqual(quantity, "1");
            AddRemoveCart.ClickButtonPlusOne();

            string quantityAfter = AddRemoveCart.CheckItemQuantity();
            Assert.AreEqual(quantityAfter, "2");

            string expectedMessage = "Jūsų prekių krepšelis tuščias";
            AddRemoveCart.RemoveItems();

            string actualMessage2 = AddRemoveCart.GetEmptyCartMessage();
            Assert.AreEqual(actualMessage2, expectedMessage);
        }
    }
}
