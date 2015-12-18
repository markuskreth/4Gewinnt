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
        Business target;

        #region Zusätzliche Testattribute

        [TestInitialize()]
        public void MyTestInitialize()
        {
            target = new Business();
        }

        #endregion

        [TestMethod()]
        public void ToStringOnEmptyTest()
        {
            string expected = "              \r\n              \r\n              \r\n              \r\n              \r\n              \r\n";
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringOn0x0Test()
        {
            string expected = "              \r\n              \r\n              \r\n              \r\n              \r\n1             \r\n";
            string actual;
            target.doMove(0);

            actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringOn0x6Test()
        {
            string expected = "              \r\n              \r\n              \r\n              \r\n              \r\n            1 \r\n";
            string actual;
            target.doMove(6);

            actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringOnRow0Test()
        {
            string expected = "              \r\n              \r\n              \r\n              \r\n              \r\n1 2 1 2 1 2 1 \r\n";
            string actual;

            for (int i = 0; i < 7; i++)
                target.doMove(i);

            actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringOnColumn0Test()
        {
            string expected = "2             \r\n1             \r\n2             \r\n1             \r\n2             \r\n1             \r\n";
            string actual;

            for (int i = 0; i < 6; i++)
                target.doMove(0);

            actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
