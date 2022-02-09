//using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using NUnit.Framework;
using OpenQA.Selenium;
using POMBDDGoogleSearch.Pages;
using SeleniumExtras.PageObjects;
//using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMBDDGoogleSearch.Pages
{
    class SearchResultPage    {

        public BasePage basePage = BasePage.GetInstance;
        public SearchResultPage()
        {
            PageFactory.InitElements(basePage.driver, this);
        }

        [FindsBy(How = How.Id, Using = "hdtb-msb")]
        public IWebElement tabMain;

        [FindsBy(How = How.ClassName, Using = "gb_Oe")]
        public IWebElement txtSettings;

        public bool VerifyIsSearchResultsPage()
        {
            if (tabMain.Displayed)
            {
                return true;
            }
            else
            {
                throw new Exception("You are not in the search results page");
            }
        }
        public void SettingsButton()
        {
            txtSettings.Click();
        }
    }
}
