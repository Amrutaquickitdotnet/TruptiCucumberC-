Feature: Login into OrangHrm

@tag1
Scenario: Successful Login with OrangeHRM
	Given Home Page URL 
	When User enters valid Credentials
	| Username | Password |
	| Admin    | admin123 |
	And clicks on Login Button
	Then successful login message must displayed.
