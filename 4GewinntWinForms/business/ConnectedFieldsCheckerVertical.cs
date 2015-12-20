using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    class ConnectedFieldsCheckerVertical : ConnectedFieldsChecker
    {
        protected override void countConnected1(int column, int row)
        {

            Condition con = delegate()
            {

                int actRow = row + tmp;
                int actCol = column;

                bool result = actRow < cells.GetLength1();
                if (result)
                    result &= cells.get(column, actRow) == item;

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

                int actRow = row - tmp;
                int actCol = column;

                bool result = actRow >= 0;
                if (result)
                    result &= cells.get(column, actRow) == item;

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
