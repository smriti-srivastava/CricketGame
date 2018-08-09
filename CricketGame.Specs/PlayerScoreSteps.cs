using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CricketGame.Specs
{
    [Binding]


    public class PlayerScoreSteps
    {
        private Cricket _game;
        [When(@"Player starts a game of cricket")]
        [Given(@"Player has started a game of cricket")]
        public void WhenPlayerHasStartedAGameOfCricket()
        {
            _game = new Cricket();
        }

        [Given(@"Player has scored (.*) runs")]
        [When(@"Player scores (.*) runs")]
        public void WhenPlayerScoresRuns(int runs)
        {
            _game.Score(runs);
        }

        [Then(@"The player score should be (.*)")]
        public void ThenThePlayerScoreShouldBe(int score)
        {
            _game.PlayerScore.Should().Be(score);
        }
        [Given(@"Player gets out")]
        public void GivenPlayerGetsOut()
        {
            _game.IsPlayerOut = true;
        }

        [When(@"Player gets out")]
        public void WhenPlayerGetsOut()
        {
            _game.PlayerOut();
        }

        [Then(@"Player cannot score anymore")]
        public void ThenPlayerCannotScoreAnymore()
        {
            _game.IsPlayerOut.Should().Be(true);
        }

    }
}
