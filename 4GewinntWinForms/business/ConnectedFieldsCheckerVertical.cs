using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    class ConnectedFieldsCheckerVertical : ConnectedFieldsChecker
    {
        public ConnectedFieldsCheckerVertical(CellField cells)
            : base(cells)
        { }

        protected override void countConnected1(int column, int row)
        {

            CellState item = cells.get(column, row);

            rowLength = 1;
            tmp = 1;
            Condition con = delegate()
            {
                bool result = row + tmp < cells.GetLength1();
                if (result)
                    result &= cells.get(column, row + tmp) == item;
                return result;
            };

            countRowItems(con);

        }

        protected override void countConnected2(int column, int row)
        {

            tmp = 1;
            Condition con = delegate()
            {
                bool result = row - tmp >= 0;
                if (result)
                    result &= cells.get(column, row - tmp) == item;
                return result;
            };

            countRowItems(con);

        }
    }
}
