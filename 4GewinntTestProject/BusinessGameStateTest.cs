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

    }
}
