Feature: DeleteFromOrder
	In order to calculate the bill
	As a checkout system
	I want to add the cost of the total order plus 10 percent
	And be able to delete part of the order and update the result

@mytag
Scenario: Delete an order from the total
	Given A group of 4 people order 4 starter and 4 mains and 4 drinks
	Then the result should be 59.04
	When 1 starter 1 main and 1 drink is removed 
	Then the result should be 44.55