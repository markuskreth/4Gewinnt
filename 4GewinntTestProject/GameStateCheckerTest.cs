using _4GewinntWinForms.business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
        public void PlayerWinsLeftBottomDiagonal()
        {

            CellValueList expected = new CellValueList();

            int koord = 0;
            cells.set(koord, koord, CellState.Player1);
            expected.Add(new CellValue(koord, koord, CellState.Player1));

            koord++;
            cells.set(koord, koord, CellState.Player1);
            expected.Add(new CellValue(koord, koord, CellState.Player1));
            koord++;
            cells.set(koord, koord, CellState.Player1);
            expected.Add(new CellValue(koord, koord, CellState.Player1));
            koord++;
            cells.set(koord, koord, CellState.Player1);
            expected.Add(new CellValue(koord, koord, CellState.Player1));

            koord = 0;
            
            CellValueList actual;
            actual = target.findConnectedLines(cells, koord, koord);
            Assert.AreEqual(expected, actual);

            koord++;
            actual = target.findConnectedLines(cells, koord, koord);
            Assert.AreEqual(expected, actual);

            koord++;
            actual = target.findConnectedLines(cells, koord, koord);
            Assert.AreEqual(expected, actual);

            koord++;
            actual = target.findConnectedLines(cells, koord, koord);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsLeftTopDiagonal()
        {

            CellValueList expected = new CellValueList();

            int koord = 0;            
            cells.set(koord,5 - koord, CellState.Player1);
            expected.Add(new CellValue(koord,  5 - koord, CellState.Player1));
            
            koord++;
            cells.set(koord, 5 - koord, CellState.Player1);
            expected.Add(new CellValue(koord, 5 - koord, CellState.Player1));
            koord++;
            cells.set(koord, 5 - koord, CellState.Player1);
            expected.Add(new CellValue(koord, 5 - koord, CellState.Player1));
            koord++;
            cells.set(koord, 5 - koord, CellState.Player1);
            expected.Add(new CellValue(koord, 5 - koord, CellState.Player1));

            koord = 0;

            CellValueList actual;
            actual = target.findConnectedLines(cells, koord, 5 - koord);
            Assert.AreEqual(expected, actual);

            koord++;
            actual = target.findConnectedLines(cells, koord, 5 - koord);
            Assert.AreEqual(expected, actual);

            koord++;
            actual = target.findConnectedLines(cells, koord, 5 - koord);
            Assert.AreEqual(expected, actual);

            koord++;
            actual = target.findConnectedLines(cells, koord, 5 - koord);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsLeftBottomHorizontal()
        {

            CellValueList expected = new CellValueList();

            int column = 0;
            int row = 0;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column = 0;
            
            CellValueList actual;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 1;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 2;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 3;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsRightBottomHorizontal()
        {
            CellValueList expected = new CellValueList();

            int column = 2;
            int row = 0;

            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column = 2;

            CellValueList actual;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 3;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 4;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 5;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsLeftTopHorizontal()
        {

            CellValueList expected = new CellValueList();

            int column = 0; 
            int row = 5;

            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column = 0;

            CellValueList actual;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 1;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 2;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 3;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

        }
        
        [TestMethod()]
        public void PlayerWinsRightTopHorizontal()
        {

            CellValueList expected = new CellValueList();

            int column = 2;
            int row = 5;

            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));
            
            column++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));
            
            column++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));
            
            column++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column = 2;

            CellValueList actual;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 3;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 4;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 5;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsMiddleHorizontal()
        {

            CellValueList expected = new CellValueList();

            int row = 3;
            int column = 1;

            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column = 1;

            CellValueList actual;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 2;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 3;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            column = 4;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsLeftBottomVertical()
        {

            CellValueList expected = new CellValueList();

            int column = 0;
            int row = 0;

            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row = 0;
            CellValueList actual;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 1;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 2;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 3;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsLeftTopVertical()
        {

            CellValueList expected = new CellValueList();

            int column = 0;
            int row = 2;

            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            CellValueList actual;

            row = 2;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 3;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 4;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 5;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsRightBottomVertical()
        {

            CellValueList expected = new CellValueList();

            int column = 6;
            int row = 0;

            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row = 0;

            CellValueList actual;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 1;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 2;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 3;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsRightTopVertical()
        {

            CellValueList expected = new CellValueList();

            int column = 6;
            int row = 2;

            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            CellValueList actual;
            
            row = 2;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 3;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 4;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 5;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PlayerWinsMiddleVertical()
        {

            CellValueList expected = new CellValueList();

            int column = 3;
            int row = 1;

            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            CellValueList actual;

            row = 1;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 2;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 3;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row = 4;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

        }

        //[TestMethod()]
        public void PlayerWinsLeftBottomDiagonale()
        {

            CellValueList expected = new CellValueList();

            int column = 0;
            int row = 0;

            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column++;
            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column++;
            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));

            column++;
            row++;
            cells.set(column, row, CellState.Player1);
            expected.Add(new CellValue(column, row, CellState.Player1));
            
            CellValueList actual;
            
            column = 0;
            row = 0;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row++;
            column++;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row++;
            column++;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

            row++;
            column++;
            actual = target.findConnectedLines(cells, column, row);
            Assert.AreEqual(expected, actual);

        }
    }
}
