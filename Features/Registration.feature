Feature: Registrations
	As a user of the site
	I would like to register
	So that I can login to the site

@mytag
Scenario: Valid Registration
    Given I navigate to the giftrete
	When click on the register link
	And I enter firstname
	And I enter last name
	And I enter email "emailaddress"
	And I enter mobile number
	And I enter password
	And I confirm password
	And I click on signup
	Then I should be registered



