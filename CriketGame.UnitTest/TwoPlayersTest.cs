using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CricketGame;

namespace CriketGame.UnitTest
{
    /// <summary>
    /// Summary description for TwoPlayersTest
    /// </summary>
    [TestClass]
    public class TwoPlayersTest
    {
        [TestMethod]
        public void StartingScore_Zero_Validate()
        {
            var twoPlayers = new TwoPlayers();
            var player1Score = twoPlayers.Player1.PlayerScore;
            var player2Score = twoPlayers.Player2.PlayerScore;
            Assert.AreEqual(player1Score, 0);
            Assert.AreEqual(player1Score, 0);
        }

        [TestMethod]
        public void Player1_Can_Score_Update()
        {
            var twoPlayers = new TwoPlayers();
            twoPlayers.Player1.Score(4);
            Assert.AreEqual(4, twoPlayers.Player1.PlayerScore);
        }

        [TestMethod]
        public void Player1_Scores_Multiple_ShouldUpdate()
        {
            var twoPlayers = new TwoPlayers();
            twoPlayers.Player1.Score(4);
            twoPlayers.Player1.Score(2);
            twoPlayers.Player1.Score(1);
            var totalScore = twoPlayers.Player1.PlayerScore;
            Assert.AreEqual(totalScore, 7);
        }

        [TestMethod]
        public void Player1_Invalid_Score_ShouldNotUpdate()
        {
            var twoPlayers = new TwoPlayers();
            twoPlayers.Player1.Score(2);
            twoPlayers.Player1.Score(7);
            twoPlayers.Player1.Score(1);
            Assert.IsTrue(3 == twoPlayers.Player1.PlayerScore);
        }

        [TestMethod]
        public void Player1_Out_Validate()
        {
            var twoPlayers = new TwoPlayers();
            twoPlayers.Player1.Score(6);
            twoPlayers.Player1.PlayerOut();
            Assert.IsTrue(true == twoPlayers.Player1.IsPlayerOut);
        }

        [TestMethod]
        public void Player1_AfterOut_Score_ShouldNotUpdate()
        {
            var twoPlayers = new TwoPlayers();
            twoPlayers.Player1.Score(6);
            twoPlayers.Player1.PlayerOut();
            twoPlayers.Player1.Score(1);
            Assert.IsTrue(6 == twoPlayers.Player1.PlayerScore);
        }

        [TestMethod]
        public void Player2_Score_ShouldUpdate()
        {
            var twoPlayers = new TwoPlayers();
            twoPlayers.Player2.Score(4);
            Assert.AreEqual(4, twoPlayers.Player2.PlayerScore);
        }


        [TestMethod]
        public void Player2_Multiple_Score_ShouldUpdate()
        {
            var twoPlayers = new TwoPlayers();
            twoPlayers.Player2.Score(5);
            twoPlayers.Player2.Score(3);
            twoPlayers.Player2.Score(2);
            var totalScore = twoPlayers.Player2.PlayerScore;
            Assert.AreEqual(totalScore,10);
        }

        [TestMethod]
        public void Player2_Invalid_Score_ShouldNotUpdate()
        {
            var twoPlayers = new TwoPlayers();
            twoPlayers.Player2.Score(2);
            twoPlayers.Player2.Score(-100);
            twoPlayers.Player2.Score(1);
            Assert.IsTrue(3 == twoPlayers.Player2.PlayerScore);
        }

        [TestMethod]
        public void Player2_Out_Validate()
        {
            var twoPlayers = new TwoPlayers();
            twoPlayers.Player2.Score(4);
            twoPlayers.Player2.PlayerOut();
            Assert.IsTrue(true == twoPlayers.Player2.IsPlayerOut);
        }

        [TestMethod]
        public void Player2_AfterOut_Score_ShouldNotUpdate()
        {
            var twoPlayers = new TwoPlayers();
            twoPlayers.Player2.Score(2);
            twoPlayers.Player2.PlayerOut();
            twoPlayers.Player2.Score(1);
            Assert.IsTrue(2 == twoPlayers.Player2.PlayerScore);
        }


        [TestMethod]
        public void Player1_Wins_Validate()
        {
            var twoPlayers = new TwoPlayers();
            twoPlayers.Player1.Score(4);
            twoPlayers.Player1.Score(6);
            twoPlayers.Player1.PlayerOut();
            twoPlayers.Player2.Score(4);
            twoPlayers.Player2.Score(1);
            twoPlayers.Player2.Score(4);
            twoPlayers.Player2.PlayerOut();
            var winner = twoPlayers.Winner();
            Assert.AreEqual(winner, 1);
        }

        [TestMethod]
        public void Player2_Wins_Validate()
        {
            var twoPlayers = new TwoPlayers();
            twoPlayers.Player1.Score(6);
            twoPlayers.Player1.Score(4);
            twoPlayers.Player1.PlayerOut();
            twoPlayers.Player2.Score(4);
            twoPlayers.Player2.Score(4);
            twoPlayers.Player2.Score(4);
            twoPlayers.Player2.PlayerOut();
            var winner = twoPlayers.Winner();
            Assert.AreEqual(winner, 2);
        }

        [TestMethod]
        public void Game_Is_Tie_Validate()
        {
            var twoPlayers = new TwoPlayers();
            twoPlayers.Player1.Score(6);
            twoPlayers.Player1.Score(4);
            twoPlayers.Player1.PlayerOut();
            twoPlayers.Player2.Score(4);
            twoPlayers.Player2.Score(2);
            twoPlayers.Player2.Score(4);
            twoPlayers.Player2.PlayerOut();
            var winner = twoPlayers.Winner();
            Assert.AreEqual(winner, -1);
        }
    }
}
