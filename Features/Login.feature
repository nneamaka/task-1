Feature: Login
	As a registered user of giftrete
	I would like to login 


@mytag


Scenario  Valid Login
Given I navigate to giftrete website
When I go to loginpage
And I enter email address
And I enter my password
And I click on secure signin
Then I should login



Scenario :Invalid Login
Given I navigate to giftrete site
When I go to login page
And I enter invalid email address
And I enter valid password
And I click on secure sign in
Then I should not be able to login

 

 

Scenario : Invalid Login
Given I navigate to giftrete site
When I go to login page
And I enter valid email address
And I enter invalid password
And I click on secure sign in
Then I should not be able to login

 

Scenario : Invalid Login
Given I navigate to giftrete site
When I go to login page
And click on sign in with facebook
And I enter invalid facebook username
And I enter valid facebook password
And I click on login
Then I should not be able to login

 

Scenario : Invalid Login
Given I navigate to giftrete site
When I go to login page
And click on sign in with facebook
And I enter valid facebook username
And I enter invalid facebook password
And I click on login
Then I should not be able to login


 

Scenario:Invalid Login
Given I navigate to giftrete site
When I go to login page
And click on sign in with google
And I enter invalid google account
And I enter valid google password
And I click on login
Then I should not be able to login

 

Scenario:Invalid Login
Given I navigate to giftrete site
When I go to login page
And click on sign in with google
And I enter valid google account
And I enter invalid google password
And I click on login
Then I should not be able to login