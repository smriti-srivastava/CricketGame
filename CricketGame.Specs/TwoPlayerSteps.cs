using System;
using TechTalk.SpecFlow;
using FluentAssertions;
namespace CricketGame.Specs
{
    [Binding]
    public class TwoPlayerSteps
    {
        private TwoPlayers _twoPlayers;
        [When(@"Two Player Game starts")]
        [Given(@"Two Player Game has Started")]
        public void WhenTwoPlayerGameStarts()
        {
            _twoPlayers = new TwoPlayers();
        }

        [When(@"Player1 scores (.*)")]
        [Given(@"Player1 has scored (.*)")]
        public void WhenPlayer1Scores(int runs)
        {
            _twoPlayers.Player1.Score(runs);
        }

        [Then(@"Player1 score should be(.*)")]
        public void ThenPlayer1ScoreIs(int score)
        {
            _twoPlayers.Player1.PlayerScore.Should().Be(score);
        }

        [Given(@"Player2 has scored (.*)")]
        [When(@"Player2 scores (.*)")]
        public void WhenPlayer2Scores(int runs)
        {
            _twoPlayers.Player2.Score(runs);
        }


        [Then(@"Player2 score should be (.*)")]
        public void ThenPlayer2ScoreIs(int score)
        {
            _twoPlayers.Player2.PlayerScore.Should().Be(score);
        }

        [Given(@"Player1 got out")]
        [When(@"Player1 gets out")]
        public void GivenPlayer1GetsOut()
        {
            _twoPlayers.Player1.PlayerOut();
        }

        [Given(@"Player2 got out")]
        [When(@"Player2 gets out")]
        public void GivenPlaye2rGetsOut()
        {
            _twoPlayers.Player2.PlayerOut();
        }

        [Then(@"Player(.*) is the winner")]
        public void ThenPlayerIsTheWinner(int playerNumber)
        {
            _twoPlayers.Winner().Should().Be(playerNumber);
        }

        [Then(@"The game is Tie")]
        public void ThenTheGameIsTie()
        {
            _twoPlayers.Winner().Should().Be(-1);
        }
    }
}
