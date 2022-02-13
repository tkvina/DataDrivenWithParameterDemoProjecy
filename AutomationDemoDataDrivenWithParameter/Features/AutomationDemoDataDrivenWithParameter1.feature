Feature: AutomationDemoDataDrivenWithParameter1
	In order to be able to Register

@mytag
Scenario: AutomationDemoDataDrivenWithParameter valid
	Given I navigate to the website "http://demo.automationtesting.in/Register.html"
	And I enter my first name "brownsugar"
	And I enter last name "wickham"
	And I enter my address "Pedro street"
	And I enter my Email address "tautau@gmail.com"
	#And I enter my Gender "Female"
	#And I enter of Hobbies "cricket"
	And I enter my password "beruit"
	And I enter confirmed password "beruit"
	When I click on the submit button
	#Then I should be able to register sucessfully