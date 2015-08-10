Feature: Celsius To Fahrenheit Conversion

Scenario: Converting to fahrenheit should work
	Given I have loaded the "Celsius to Fahrenheit" page
	And I have entered "35" in the "Celsius value"
	When I click "Convert"
	Then "Fahrenheit value" should be "95"

Scenario Outline: Celcius to Fahrenheit from scenarios
	Given I have loaded the "Celsius to Fahrenheit" page
	And I have entered "<Celsius>" in the "Celsius value"
	When I click "Convert"
	Then "Fahrenheit value" should be "<Fahrenheit>"
	Scenarios:
	| Celsius | Fahrenheit |
	| 100     | 212        |
	| 0       | 32         |
	| -40     | -40        |
