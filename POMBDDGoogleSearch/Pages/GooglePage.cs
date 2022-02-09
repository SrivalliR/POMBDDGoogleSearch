//using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using POMBDDGoogleSearch.Pages;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace POMBDDGoogleSearch.Pages
{
    public class GooglePage
    {
        //IWebDriver driver = null;
        public BasePage basePage = BasePage.GetInstance;
        public GooglePage()
        {
            PageFactory.InitElements(basePage.driver, this);
        }

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement txtsearch;

        //[FindsBy(How = How.LinkText, Using = "Google Search")]
        //public IWebElement btnsearch;

        public void NavigateGooglePage()
        {
           basePage = BasePage.GetInstance;
        }

        public void Search(string searchstring)
        {
            txtsearch.Clear();
            txtsearch.SendKeys(searchstring);

        }
        public dynamic SearchResult()
        {
            txtsearch.Submit();
            return new SearchResultPage();
        }
    }
}

