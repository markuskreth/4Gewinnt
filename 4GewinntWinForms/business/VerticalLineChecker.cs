using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    class VerticalLineChecker : LineChecker
    {
        public VerticalLineChecker(CellField cells)
            : base(cells)
        { }

        protected override void countConnected(int column, int row)
        {

            CellState item = cells.get(column, row);

            rowLength = 1;
            tmp = 1;
            Condition con = delegate()
            {
                bool result = rowLength < 4;
                result &= row + tmp < cells.GetLength1();
                if (result)
                    result &= cells.get(column, row + tmp) == item;
                return result;
            };

            countRowItems(con);

            tmp = 1;
            con = delegate()
            {
                bool result = rowLength < 4;
                result &= row - tmp >= 0;
                if (result)
                    result &= cells.get(column, row - tmp) == item;
                return result;
            };

            countRowItems(con);

        }
    }
}
