using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4GewinntWinForms.business;

namespace _4GewinntTestProject
{
    [TestClass()]
    public abstract class AbstractBusinessTest
    {

        protected Business target;

        #region Zusätzliche Testattribute

        [TestInitialize()]
        public void MyTestInitialize()
        {
            target = new Business();
        }

        #endregion

        protected void fillLines(int lineCount)
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

    }
}
