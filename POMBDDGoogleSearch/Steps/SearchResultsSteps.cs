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
    public class SearchResultsSteps
    {
        SearchResultPage page = new SearchResultPage();

        [Given(@"User should navigated to the Google page")]
        public void GivenUserShouldNavigatedToTheGooglePage()
        {
            page.VerifyIsSearchResultsPage();
        }
        
        [When(@"Click on the settings button")]
        public void WhenClickOnTheSettingsButton()
        {
            page.SettingsButton();
        }
        
        [Then(@"user should be able to see the settings tab")]
        public void ThenUserShouldBeAbleToSeeTheSettingsTab()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
