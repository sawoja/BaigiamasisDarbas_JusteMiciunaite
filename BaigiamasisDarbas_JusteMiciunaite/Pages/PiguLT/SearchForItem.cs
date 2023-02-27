using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas_JusteMiciunaite.Pages.PiguLT
{
    public class SearchForItem
    {
        public static void Open()
        {
            Driver.OpenUrl("https://pigu.lt/lt/");
            Common.MaximizeWindow();
            Common.AllowCookies(Locators.AllowCookies.allowCookies);

        }

        public static void EnterSearchPhrase(string phrase)
        {
            Common.SendKeys(Locators.ItemSearch.inputSearchPhrase, phrase);
        }
        public static void ClickSearchButton()
        {
            Common.ClickElement(Locators.ItemSearch.searchButton);
        }

        public static void ClickQuickDelivery()
        {
            Common.ClickElement(Locators.ItemSearch.quickDeliveryCheckbox);
        }

        public static string ActiveFilter()
        {
            return Common.GetElementText(Locators.ItemSearch.messageActiveFilters);
        }

        public static void ClearActiveFilters()
        {
            Common.ClickElement(Locators.ItemSearch.clearButton);
        }

        public static string ItemNotFound()
        {
            return Common.GetElementText(Locators.ItemSearch.messageItemNotFound);
        }

        public static void RemoveBadPhrase()
        {
            Common.ClickElement(Locators.ItemSearch.removePhrase);
        }
    }
}
