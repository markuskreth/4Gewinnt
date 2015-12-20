using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _4GewinntWinForms.business;

namespace _4GewinntTestProject
{

    /// <summary>
    ///Dies ist eine Testklasse für "BusinessTest" und soll
    ///alle BusinessTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class BusinessCellStateTest : AbstractBusinessTest
    {
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
            
            Assert.AreEqual(6*7, target.Cells.Count);

            foreach (var cell in target.Cells)
            {
                Assert.AreEqual(CellState.Empty, cell.Value);
            }

        }

        [TestMethod()]
        public void ensureCellPropertyCanNotChangeGame()
        {
            CellValue val = target.Cells[2];
            val.Value = CellState.Player1;

            Assert.AreEqual(CellState.Empty, target.Cells[2].Value);
        }

        [TestMethod()]
        public void ensureDoMovechangesCorrectColumnRow0()
        {

            int column;

            column = 6;
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player1, target.get(column, 0));

            column = 5;
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player2, target.get(column, 0));

            column = 4;
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player1, target.get(column, 0));

            column = 3;
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player2, target.get(column, 0));

            column = 2;
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player1, target.get(column, 0));

            column = 1;
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player2, target.get(column, 0));

            column = 0;
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player1, target.get(column, 0));

        }

        [TestMethod()]
        public void ensureDoMovechangesCorrectColumnRow1()
        {
            int column;

            fillLines(1);

            column = 6;
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player2, target.get(column, 1));

            column = 5;
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player1, target.get(column, 1));

            target.doMove(column);
            column = 4;
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player1, target.get(column, 1));

            column = 3;
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player2, target.get(column, 1));

            column = 2;
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player1, target.get(column, 1));

            column = 1;
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player2, target.get(column, 1));

            column = 0;
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player1, target.get(column, 1));

        }

        [TestMethod()]
        public void ensureDoMovechangesCorrectColumnRow5()
        {
            fillLines(4);

            int column;

            column = 6;
            target.doMove(column);
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player1, target.get(column, 4));
            Assert.AreEqual(CellState.Player2, target.get(column, 5));

            column = 5;
            target.doMove(column);
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player1, target.get(column, 4));
            Assert.AreEqual(CellState.Player2, target.get(column, 5));

            column = 4;
            target.doMove(column);
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player1, target.get(column, 4));
            Assert.AreEqual(CellState.Player2, target.get(column, 5));

            // Spalte 3 auslassen, damit Spiel nicht endet.

            column = 2;
            target.doMove(column);
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player1, target.get(column, 4));
            Assert.AreEqual(CellState.Player2, target.get(column, 5));

            column = 1;
            target.doMove(column);
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player1, target.get(column, 4));
            Assert.AreEqual(CellState.Player2, target.get(column, 5));

            column = 0;
            target.doMove(column);
            target.doMove(column);
            
            Assert.AreEqual(CellState.Player1, target.get(column, 4));
            Assert.AreEqual(CellState.Player2, target.get(column, 5));

        }

        [TestMethod()]
        public void testFillLines()
        {
            fillLines(6);
            CellValueList cells = target.Cells;

            foreach (var cell in cells)
            {
                Assert.AreNotEqual(CellState.Empty, cell.Value);
            }

        }

        private void fillLines(int lineCount)
        {
            for (int y = 0; y < lineCount; y++)
            {
                for (int x = 0; x < target.ColumnCount; x++)
                {
                    if (x == 3)
                    {
                        target.doMove(4);
                        target.doMove(x);
                        x++;
                        continue;
                    }

                    target.doMove(x);
                }
            }
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

    }
}
