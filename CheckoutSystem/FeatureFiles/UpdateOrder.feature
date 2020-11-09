Feature: UpdateOrder
	In order to calculate the bill
	As a checkout system
	I want to add the cost of the total order plus 10 percent
	And be able to Add more items to the order to recalculate the new amount


@mytag
Scenario: Add 2 more orders to the existing order
	Given A group of 2 people order 1 starter and 2 mains
	Then the result should be 19.80
	When 2 more mains are added 
	Then the result should be 35.20