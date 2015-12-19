using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    public class ConnectedFieldsCheckerHorizontal : ConnectedFieldsChecker
    {

        public ConnectedFieldsCheckerHorizontal(CellField cells)
            : base(cells)
        {
        }

        protected override void countConnected1(int column, int row)
        {

            tmp = 1;
            Condition con = delegate()
            {
                bool result = column - tmp >= 0;
                if (result)
                    result &= cells.get(column - tmp, row) == item;
                return result;
            };

            countRowItems(con);

        }
        protected override void countConnected2(int column, int row)
        {
            tmp = 1;
            Condition con = delegate()
            {
                bool result = column + tmp < cells.GetLength0();
                if (result)
                    result &= cells.get(column + tmp, row) == item;
                return result;
            };

            countRowItems(con);

        }
    }
}
