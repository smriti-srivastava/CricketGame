Feature: TwoPlayer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
	

Scenario: Two Players Cricket Game starts with both the players having score zero
	When Two Player Game starts
	Then Player1 score should be 0
	Then Player2 score should be 0

Scenario: Player1 can score
	Given Two Player Game has Started
	When Player1 scores 4
	Then Player1 score should be 4

Scenario: Player1 can score multiple times
	Given Two Player Game has Started
	And Player1 has scored 5
	When Player1 scores 4
	Then Player1 score should be 9

Scenario: Player2 can score
	Given Two Player Game has Started
	When Player2 scores 6
	Then Player2 score should be 6

Scenario: Player1 should not be able to score after getting out
	Given Two Player Game has Started
	Given Player1 got out
	When Player1 scores 5
	Then Player1 score should be 0

Scenario: Player2 should not be able to score after getting out
	Given Two Player Game has Started
	Given Player2 has scored 1
	Given Player2 got out
	Given Player2 has scored 2
	When Player2 scores 5
	Then Player2 score should be 1

Scenario: Player2 can score multiple times
	Given Two Player Game has Started
	And Player2 has scored 1
	When Player2 scores 3
	Then Player2 score should be 4

Scenario: When Player1 scores more than Player2 then Player1 is the winner
	Given Two Player Game has Started
	Given Player1 has scored 5
	Given Player1 got out
	Given Player2 has scored 2
	When Player2 gets out
	Then Player1 is the winner

Scenario: When Player2 scores more than Player1 then Player2 is the winner
	Given Two Player Game has Started
	Given Player1 has scored 1
	Given Player1 got out
	Given Player2 has scored 4
	When Player2 gets out
	Then Player2 is the winner	

Scenario: When Player2 and Player1 both scores equal then it is tie
	Given Two Player Game has Started
	Given Player1 has scored 4
	Given Player1 got out
	Given Player2 has scored 4
	Given Player2 got out
	Then The game is Tie