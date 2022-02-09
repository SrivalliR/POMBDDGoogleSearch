using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using System.Threading;
using POMBDDGoogleSearch.Pages;

namespace POMBDDGoogleSearch.Steps
{
    [Binding]
    public class SerchingInGoogleSteps
    {
        //IWebDriver driver = null;
        GooglePage page = new GooglePage();
        SearchResultPage currentPage = new SearchResultPage();
        
        [Given(@"Navigate to the Google page")]
        public void GivenNavigateToTheGooglePage()
        {
            page.NavigateGooglePage();
            //driver = Browser.Current;
        }
        
        [Given(@"enter (.*)")]
        public void GivenEnterBDD(string searchstring)
        {
            page.Search(searchstring);
        }
        
        [When(@"click on the search button")]
        public void WhenClickOnTheSearchButton()
        {
            currentPage = page.SearchResult();
        }
        
        [Then(@"UI should navigate to SearchResults page")]
        public void ThenUIShouldNavigateToSearchResultsPage()
        {
            ((SearchResultPage)currentPage).VerifyIsSearchResultsPage();
        }
    }
}
