using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    public class HorizontalLineChecker : LineChecker
    {

        public HorizontalLineChecker(CellField cells)
            : base(cells)
        {
        }
        
        protected override void countConnected(int column, int row)
        {

            Condition con = delegate()
            {
                bool result = rowLength < 4;
                result &= column + tmp < cells.GetLength0();
                if (result)
                    result &= cells.get(column + tmp, row) == item;
                return result;
            };

            countRowItems(con);

            tmp = 1;
            con = delegate()
            {
                bool result = rowLength < 4;
                result &= column - tmp >= 0;
                if (result)
                    result &= cells.get(column - tmp, row) == item;
                return result;
            };

            countRowItems(con);

        }
    }
}
