Feature: Fahrenheit To Celsius Conversion

Scenario: Converting to celsius should work
	Given I have loaded the "Fahrenheit to Celsius" page
	And I have entered "95" in the "Fahrenheit value"
	When I click "Convert"
	Then "Celsius value" should be "34"

Scenario Outline: Fahrenheit to Celsius from scenarios
	Given I have loaded the "Fahrenheit to Celsius" page
	And I have entered "<Fahrenheit>" in the "Fahrenheit value"
	When I click "Convert"
	Then "Celsius value" should be "<Celsius>"
	Scenarios:
	| Fahrenheit | Celsius |
	| 212        | 100     |
	| 32         | 0       |
	| -40        | -40     |
