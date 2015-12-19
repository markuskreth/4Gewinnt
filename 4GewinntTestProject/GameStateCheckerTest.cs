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

        [TestMethod()]
        public void PlayerWinsLeftBottomHorizontal()
        {
            cells.set(0, 0, CellState.Player1);
            cells.set(1, 0, CellState.Player1);
            cells.set(2, 0, CellState.Player1);
            cells.set(3, 0, CellState.Player1);

            int column = 0;
            int row = 0;
            GameState expected = GameState.Player1HasWon;
            GameState actual;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 1;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 2;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 3;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsRightBottomHorizontal()
        {
            cells.set(2, 0, CellState.Player1);
            cells.set(3, 0, CellState.Player1);
            cells.set(4, 0, CellState.Player1);
            cells.set(5, 0, CellState.Player1);

            int column = 2;
            int row = 0;
            GameState expected = GameState.Player1HasWon;
            GameState actual;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 3;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 4;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 5;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsLeftTopHorizontal()
        {
            cells.set(0, 5, CellState.Player1);
            cells.set(1, 5, CellState.Player1);
            cells.set(2, 5, CellState.Player1);
            cells.set(3, 5, CellState.Player1);

            int column = 0;
            int row = 5;
            GameState expected = GameState.Player1HasWon;
            GameState actual;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 1;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 2;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 3;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsRightTopHorizontal()
        {
            cells.set(2, 5, CellState.Player1);
            cells.set(3, 5, CellState.Player1);
            cells.set(4, 5, CellState.Player1);
            cells.set(5, 5, CellState.Player1);

            int column = 2;

            int row = 5;
            GameState expected = GameState.Player1HasWon;
            GameState actual;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 3;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 4;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 5;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsMiddleHorizontal()
        {
            cells.set(1, 3, CellState.Player1);
            cells.set(2, 3, CellState.Player1);
            cells.set(3, 3, CellState.Player1);
            cells.set(4, 3, CellState.Player1);

            int row = 3;
            int column = 1;

            GameState expected = GameState.Player1HasWon;
            GameState actual;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 2;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 3;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 4;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsLeftBottomVertical()
        {
            cells.set(0, 0, CellState.Player1);
            cells.set(0, 1, CellState.Player1);
            cells.set(0, 2, CellState.Player1);
            cells.set(0, 3, CellState.Player1);

            int column = 0;
            int row = 0;
            GameState expected = GameState.Player1HasWon;
            GameState actual;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 1;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 2;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 3;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsLeftTopVertical()
        {
            cells.set(0, 2, CellState.Player1);
            cells.set(0, 3, CellState.Player1);
            cells.set(0, 4, CellState.Player1);
            cells.set(0, 5, CellState.Player1);

            int column = 0;
            int row = 2;
            GameState expected = GameState.Player1HasWon;
            GameState actual;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 3;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 4;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 5;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsRightBottomVertical()
        {
            cells.set(6, 0, CellState.Player1);
            cells.set(6, 1, CellState.Player1);
            cells.set(6, 2, CellState.Player1);
            cells.set(6, 3, CellState.Player1);

            int column = 6;
            int row = 0;
            GameState expected = GameState.Player1HasWon;
            GameState actual;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 1;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 2;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 3;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsRightTopVertical()
        {
            cells.set(6, 2, CellState.Player1);
            cells.set(6, 3, CellState.Player1);
            cells.set(6, 4, CellState.Player1);
            cells.set(6, 5, CellState.Player1);

            int column = 6;
            int row = 2;
            GameState expected = GameState.Player1HasWon;
            GameState actual;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 3;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 4;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 5;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsMiddleVertical()
        {
            cells.set(3, 1, CellState.Player1);
            cells.set(3, 2, CellState.Player1);
            cells.set(3, 3, CellState.Player1);
            cells.set(3, 4, CellState.Player1);

            int column = 3;
            int row = 1;
            GameState expected = GameState.Player1HasWon;
            GameState actual;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 2;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 3;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 4;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        //[TestMethod()]
        public void PlayerWinsLeftBottomDiagonale()
        {
            cells.set(0, 0, CellState.Player1);
            cells.set(1, 1, CellState.Player1);
            cells.set(2, 2, CellState.Player1);
            cells.set(3, 3, CellState.Player1);

            int column = 0;
            int row = 0;
            GameState expected = GameState.Player1HasWon;
            GameState actual;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row++;
            column++;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row++;
            column++;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

            row++;
            column++;
            actual = target.checkGameEnd(cells, column, row);
            Assert.AreEqual(expected, actual);

        }
    }
}
