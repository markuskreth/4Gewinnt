using _4GewinntWinForms.business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _4GewinntTestProject
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "CellValueListTest" und soll
    ///alle CellValueListTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class CellValueListTest
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

        [TestMethod()]
        public void CellValueListEqualOnDifferentOrder()
        {

            CellValueList first = new CellValueList();
            CellValueList second = new CellValueList();

            CellValue val1 = new CellValue(1, 2, CellState.Player1);
            CellValue val2 = new CellValue(2, 2, CellState.Player2);
            first.Add(val1);
            first.Add(val2);

            second.Add(val2);
            second.Add(val1);
            Assert.AreEqual(first, second);
        }

        [TestMethod()]
        public void CellValueListEqual()
        {

            CellValueList first = new CellValueList();
            CellValueList second = new CellValueList();
            int col = 1;
            int row = 1;

            for (int i = 0; i < 4; i++)
            {
                first.Add(new CellValue(col, row, CellState.Player1));
                second.Add(new CellValue(col, row, CellState.Player1));
                col++;
                row++;
            }

            Assert.AreEqual(first, second);
        }

        [TestMethod()]
        public void CellValueListEqualOpositeOrder()
        {

            CellValueList first = new CellValueList();
            CellValueList second = new CellValueList();
            int col = 1;
            int row = 1;

            for (int i = 0; i < 4; i++)
            {
                first.Add(new CellValue(col, row, CellState.Player1));
                col++;
                row++;
            }

            for (int i = 3; i >=0 ; i--)
            {
                second.Add(first[i]);
            }

            
            Assert.AreEqual(first, second);
        }

    }
}
