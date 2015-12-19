using _4GewinntWinForms.business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _4GewinntTestProject
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "GameStateCheckerTest" und soll
    ///alle GameStateCheckerTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class GameStateCheckerTest
    {
        GameStateChecker target;
        CellField cells;

        #region Zusätzliche Testattribute

        [TestInitialize()]
        public void MyTestInitialize()
        {
            target = new GameStateChecker();
            cells = new CellField(7, 6);
        }

        #endregion


        /// <summary>
        ///Ein Test für "checkGameEnd"
        ///</summary>
        [TestMethod()]
        public void PlayerWinsLeftBottomHorizontal()
        {
            cells.set(0, 0,CellState.Player1);
            cells.set(1, 0,CellState.Player1);
            cells.set(2, 0,CellState.Player1);
            cells.set(3, 0,CellState.Player1);
            GameState _currentState = GameState.Player1;
            int column = 0;
            int row = 0;
            GameState expected = GameState.Player1HasWon;
            GameState actual;
            actual = target.checkGameEnd(cells, _currentState, column, row);
            Assert.AreEqual(expected, actual);

            column = 1;
            actual = target.checkGameEnd(cells, _currentState, column, row);
            Assert.AreEqual(expected, actual);

            column = 2;
            actual = target.checkGameEnd(cells, _currentState, column, row);
            Assert.AreEqual(expected, actual);

            column = 3;
            actual = target.checkGameEnd(cells, _currentState, column, row);
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///Ein Test für "checkGameEnd"
        ///</summary>
        [TestMethod()]
        public void PlayerWinsLeftBottomVertical()
        {
            cells.set(0, 0,CellState.Player1);
            cells.set(0, 1,CellState.Player1);
            cells.set(0, 2,CellState.Player1);
            cells.set(0, 3,CellState.Player1);
            GameState _currentState = GameState.Player1;
            int column = 0;
            int row = 0;
            GameState expected = GameState.Player1HasWon;
            GameState actual;
            actual = target.checkGameEnd(cells, _currentState, column, row);
            Assert.AreEqual(expected, actual);

            row = 1;
            actual = target.checkGameEnd(cells, _currentState, column, row);
            Assert.AreEqual(expected, actual);

            row = 2;
            actual = target.checkGameEnd(cells, _currentState, column, row);
            Assert.AreEqual(expected, actual);

            row = 3;
            actual = target.checkGameEnd(cells, _currentState, column, row);
            Assert.AreEqual(expected, actual);

        }
    }
}
