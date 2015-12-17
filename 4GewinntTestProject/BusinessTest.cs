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

        #region Zusätzliche Testattribute
        // 
        //Sie können beim Verfassen Ihrer Tests die folgenden zusätzlichen Attribute verwenden:
        //
        //Mit ClassInitialize führen Sie Code aus, bevor Sie den ersten Test in der Klasse ausführen.
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Mit ClassCleanup führen Sie Code aus, nachdem alle Tests in einer Klasse ausgeführt wurden.
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Mit TestInitialize können Sie vor jedem einzelnen Test Code ausführen.
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Mit TestCleanup können Sie nach jedem einzelnen Test Code ausführen.
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///Ein Test für "Business-Konstruktor"
        ///</summary>
        [TestMethod()]
        public void BusinessConstructorTest()
        {
            Business target = new Business();
            testInitState(target);
        }

        /// <summary>
        ///Ein Test für "startNewGame"
        ///</summary>
        [TestMethod()]
        public void startNewGameTest()
        {
            Business target = new Business();
            target.doMove(0);
            target.doMove(1);

            target.startNewGame();
            testInitState(target);
        }

        private void testInitState(Business target)
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
        public void ensureDoMovechangesCorrectColumn()
        {
            Business target = new Business();
            CellState[,] cells;
            int column;

            column = 6;
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 0]);

            column = 5;
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 0]);

            column = 4;
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 0]);

            column = 3;
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 0]);

            column = 2;
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 0]);

            column = 1;
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 0]);

            column = 0;
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 0]);

        }

        [TestMethod()]
        public void ensureDoMovechangesCorrectColumnRow1()
        {
            Business target = new Business();
            CellState[,] cells;
            int column;

            column = 6;
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 1]);

            column = 5;
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 1]);

            column = 4;
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 1]);

            column = 3;
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 1]);

            column = 2;
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 1]);

            column = 1;
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 1]);

            column = 0;
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 1]);

        }

        [TestMethod()]
        public void ensureDoMovechangesCorrectColumnRow5()
        {
            Business target = new Business();
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
            Assert.AreEqual(CellState.Player1, cells[column, 5]);

            column = 5;
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 5]);

            column = 4;
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 5]);

            column = 3;
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 5]);

            column = 2;
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 5]);

            column = 1;
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 5]);

            column = 0;
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            target.doMove(column);
            cells = target.Cells;
            Assert.AreEqual(CellState.Player1, cells[column, 5]);

        }

        [TestMethod()]
        public void ensureDoMoveRow6Throws()
        {
            Business target = new Business();
            
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
