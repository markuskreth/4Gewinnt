using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4GewinntWinForms.business;

namespace _4GewinntTestProject
{
    [TestClass]
    public class BusinessGameStateTest : AbstractBusinessTest
    {

        [TestMethod()]
        public void ensureDoMoveChangesPlayer()
        {
            GameState state;

            state = target.doMove(0);
            Assert.AreEqual(GameState.Player2, state);
            Assert.AreEqual(GameState.Player2, target.CurrentState);

            state = target.doMove(0);
            Assert.AreEqual(GameState.Player1, state);
            Assert.AreEqual(GameState.Player1, target.CurrentState);

            state = target.doMove(0);
            Assert.AreEqual(GameState.Player2, state);
            Assert.AreEqual(GameState.Player2, target.CurrentState);

            state = target.doMove(2);
            Assert.AreEqual(GameState.Player1, state);
            Assert.AreEqual(GameState.Player1, target.CurrentState);

            state = target.doMove(2);
            Assert.AreEqual(GameState.Player2, state);
            Assert.AreEqual(GameState.Player2, target.CurrentState);
        }

        [TestMethod()]
        public void leftBottomHorizontal4Wins()
        {
            GameState state;

            state = target.doMove(0);
            Assert.AreEqual(GameState.Player2, state);

            state = target.doMove(0);   // Player 2
            Assert.AreEqual(GameState.Player1, state);

            state = target.doMove(1);
            Assert.AreEqual(GameState.Player2, state);

            state = target.doMove(0);   // Player 2
            Assert.AreEqual(GameState.Player1, state);

            state = target.doMove(2);
            Assert.AreEqual(GameState.Player2, state);

            state = target.doMove(0);   // Player 2
            Assert.AreEqual(GameState.Player1, state);

            state = target.doMove(3);
            Assert.AreEqual(GameState.Player1HasWon, state);

        }

        [TestMethod()]
        public void ensureFullFielEndsGameWithTie()
        {
            fillLines(5);

            GameState state;
            state = target.doMove(0);
            Assert.AreEqual(GameState.Player1, state);

            state = target.doMove(1);
            Assert.AreEqual(GameState.Player2, state);

            state = target.doMove(2);
            Assert.AreEqual(GameState.Player1, state);

            state = target.doMove(4);
            Assert.AreEqual(GameState.Player2, state);

            state = target.doMove(3);
            Assert.AreEqual(GameState.Player1, state);

            state = target.doMove(5);
            Assert.AreEqual(GameState.Player2, state);

            state = target.doMove(6);
            Assert.AreEqual(GameState.Tie, state);

        }
    }
}
