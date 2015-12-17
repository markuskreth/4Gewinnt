using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _4GewinntWinForms.business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _4GewinntTestProject
{
    class AbstractBusinessTest
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
