using _4GewinntWinForms.business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _4GewinntTestProject
{
    
    /// <summary>
    ///Dies ist eine Testklasse für "BusinessTest" und soll
    ///alle BusinessTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class BusinessTest
    {
        private Business target;

        #region Zusätzliche Testattribute

        [TestInitialize()]
        public void MyTestInitialize()
        {
            target = new Business();
        }

        #endregion

        /// <summary>
        ///Ein Test für "Business-Konstruktor"
        ///</summary>
        [TestMethod()]
        public void BusinessConstructorTest()
        {
            testInitState(target);
        }

        /// <summary>
        ///Ein Test für "startNewGame"
        ///</summary>
        [TestMethod()]
        public void startNewGameTest()
        {
            target.doMove(0);
            target.doMove(1);

            target.startNewGame();
            testInitState(target);
        }

        private static void testInitState(Business target)
        {

            Assert.AreEqual(GameState.Player1, target.CurrentState);
            CellState[,] cells = target.Cells;
            Assert.AreEqual(7, cells.GetLength(0));
            Assert.AreEqual(6, cells.GetLength(1));

            foreach (var cell in cells )
            {
                Assert.AreEqual(CellState.Empty, cell);
            }

        }

        [TestMethod()]
        public void ensureCellPropertyCanNotChangeGame()
        {
            CellState[,] cells;
            cells = target.Cells;
            cells[1, 1] = CellState.Player1;
            Assert.AreEqual(CellState.Empty, target.Cells[1, 1]);
        }

        [TestMethod()]
        public void ensureDoMovechangesCorrectColumn()
        {
            CellState[,] cells;
            int column;

            column = 6;
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 0]);

            column = 5;
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 0]);

            column = 4;
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 0]);

            column = 3;
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 0]);

            column = 2;
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 0]);

            column = 1;
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 0]);

            column = 0;
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 0]);

        }

        [TestMethod()]
        public void ensureDoMovechangesCorrectColumnRow1()
        {
            CellState[,] cells;
            int column;

            column = 6;
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 1]);

            column = 5;
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 1]);

            column = 4;
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 1]);

            column = 3;
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 1]);

            column = 2;
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 1]);

            column = 1;
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 1]);

            column = 0;
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 1]);

        }

        [TestMethod()]
        public void ensureDoMovechangesCorrectColumnRow5()
        {
            CellState[,] cells;
            int column;

            column = 6;
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 5]);

            column = 5;
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 5]);

            column = 4;
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 5]);

            column = 3;
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 5]);

            column = 2;
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 5]);

            column = 1;
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 5]);

            column = 0;
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player2, cells[column, 5]);

        }

        [TestMethod()]
        public void ensureDoMoveRow6Throws()
        {
            int column;

            column = 6;
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            try
            {
                target.doMove(column);
                Assert.Fail("Exception expected, but not thrown");
            }
            catch (Exception) { }

        }

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
