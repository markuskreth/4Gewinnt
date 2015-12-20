using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    public class ConnectedFieldsCheckerHorizontal : ConnectedFieldsChecker
    {

        protected override void countConnected1(int column, int row)
        {
            Condition con = delegate()
            {
                int actCol = column - tmp;
                int actRow = row;

                bool result = actCol >= 0;
                if (result)
                    result &= cells.get(actCol, row) == item;

                if (result)
                {
                    return new CellValue(actCol, actRow, item);
                }
                else
                    return CellValue.INVALID;
            };

            countRowItems(con);

        }

        protected override void countConnected2(int column, int row)
        {
            Condition con = delegate()
            {
                int actCol = column + tmp;
                int actRow = row;

                bool result = actCol < cells.ColumnCount();
                if (result)
                    result &= cells.get(actCol, row) == item;

                if (result)
                {
                    return new CellValue(actCol, actRow, item);
                }
                else
                    return CellValue.INVALID;
            };

            countRowItems(con);

        }
    }
}
