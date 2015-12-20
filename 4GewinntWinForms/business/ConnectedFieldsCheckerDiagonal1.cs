using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    class ConnectedFieldsCheckerDiagonal1 : ConnectedFieldsChecker
    {
        protected override void countConnected1(int column, int row)
        {
            Condition con = delegate()
            {
                int actRow = row + tmp;
                int actCol = column + tmp;

                bool result = actRow < cells.RowCount() && actCol < cells.ColumnCount();
                
                if (result)
                    result &= cells.get(actCol, actRow) == item;

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
                int actCol = column - tmp;

                bool result = actCol >= 0 && actRow >= 0;
                if (result)
                    result &= cells.get(actCol, actRow) == item;

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

    class ConnectedFieldsCheckerDiagonal2 : ConnectedFieldsChecker
    {
     
        protected override void countConnected1(int column, int row)
        {
            Condition con = delegate()
            {
                int actRow = row - tmp;
                int actCol = column + tmp;

                bool result = actRow >= 0 && actCol < cells.ColumnCount();
                if (result)
                    result &= cells.get(actCol, actRow) == item;

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
                int actRow = row + tmp;
                int actCol = column - tmp;

                bool result = actCol >= 0 && actRow < cells.RowCount();
                if (result)
                    result &= cells.get(actCol, actRow) == item;

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
