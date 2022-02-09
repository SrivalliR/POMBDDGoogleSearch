Feature: Serching in Google
	Test the search functionality of the Google application


@RegressionTesting
Scenario Outline: Verify the Login functionality
	Given Navigate to the Google page
	And enter <searchstring>
	When click on the search button
	Then UI should navigate to SearchResults page

	Examples:
	| searchstring |
	| BDD        |
	| Specflow   |
	| Selenium   |