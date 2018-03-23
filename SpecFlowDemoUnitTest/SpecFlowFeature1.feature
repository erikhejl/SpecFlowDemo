Feature: SpecFlowFeature1
	In order to avoid money laundering
	As a bank
	I want to comply with federal regulations

@mytag
Scenario: Make a suspicious deposit
	Given I have a bank account
	When I attempt to deposit over 10,000 dollars
	Then the deposit should be flagged for review

Scenario: Make a legitimate deposit
	Given I have a bank account
	When I attempt to deposit a reasonable amount of money
	Then the deposit should be made