Feature: Division
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario Outline: Divide two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press divide
	Then the result should be 120 on the screen
	Examples: 
	| a   | b   | c   |
	| 20  | 10  | 2   |
	| 10  | 20  | 0.5 |
	| 20  | 20  | 1   |
	| 600 | 200 | 3   |