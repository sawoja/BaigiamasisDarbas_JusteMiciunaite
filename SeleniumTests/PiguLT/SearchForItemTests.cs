﻿using BaigiamasisDarbas_JusteMiciunaite;
using BaigiamasisDarbas_JusteMiciunaite.Pages.PiguLT;
using NUnit.Framework;
using SeleniumTests.BaseClass;
using System;

namespace SeleniumTests.PiguLT
{
    internal class SearchForItemTests : Base
    {
        [SetUp]

        public void Open()
        {
            SearchForItem.Open();
        }
        [Test]
        public void SuccessfullSearch()
        {
            string expectedMessage = "Aktyvūs filtrai";

            SearchForItem.EnterSearchPhrase("Saldytuvas");
            SearchForItem.ClickSearchButton();
            SearchForItem.ClickQuickDelivery();

            string actualMessage = SearchForItem.ActiveFilter();

            Assert.AreEqual(expectedMessage, actualMessage);

            SearchForItem.ClearActiveFilters();
        }
    }
}
