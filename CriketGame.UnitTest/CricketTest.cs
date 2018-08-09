using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CricketGame;

namespace CriketGame.UnitTest
{
    [TestClass]
    public class CricketTest
    {
        [TestMethod]
        public void PlayerScore_NewGame_ShouldBeZero()
        {
            var game = new Cricket();
            Assert.IsTrue(game.PlayerScore == 0);
        }
        [TestMethod]
        public void Score_ValidRuns_ShouldUpdateScore()
        {
            var game = new Cricket();
            game.Score(3);
            Assert.IsTrue(game.PlayerScore == 3);
        }
        [TestMethod]
        public void Score_InvalidRuns_ShouldNotUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(7);
            Assert.IsTrue(game.PlayerScore == 0);
        }

        [TestMethod]
        public void Player_Out_ShouldBeTrue()
        {
            var game = new Cricket();
            game.PlayerOut();
            Assert.IsTrue(game.IsPlayerOut == true);
        }

        [TestMethod]
        public void Player_NotOut_Out_ShouldBeFalse()
        {
            var game = new Cricket();
            Assert.IsTrue(game.IsPlayerOut == false);
        }

        [TestMethod]
        public void Score_AfterOut_ShouldNotUpdate()
        {
            var game = new Cricket();
            game.Score(6);
            game.PlayerOut();
            game.Score(4);
            Assert.IsTrue(game.PlayerScore == 6);
        }
    }
}
