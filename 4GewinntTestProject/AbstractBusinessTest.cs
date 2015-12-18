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

    }
}
