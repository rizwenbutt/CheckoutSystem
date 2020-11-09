Feature: NewOrder
	In order to calculate the bill
	As a checkout system
	I want to add the cost of the total order plus 10 percent

@mytag
Scenario: calculate bill for 4 customers
	Given there are 4 customers  
	And they order 4 starters
	And they order 4 mains
	And they order 4 drinks
	When the total bill is calculated
	Then the result should be 59.40
