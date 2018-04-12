Feature: Substraction
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario Outline: Substract two numbers
	Given I have entered <a> into the calculator
	And I have entered <b> into the calculator
	When I press substract
	Then the result should be <c> on the screen
	Examples: 
	| a  | b  | c   |
	| 20 | 10 | 10  |
	| 10 | 20 | -10 |
	| 20 | 0  | 20  |
	| 0  |    | 0   |