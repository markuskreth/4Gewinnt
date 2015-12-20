using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _4GewinntWinForms.business
{
    public abstract class ConnectedFieldsChecker
    {

        protected CellValueList connected;
        protected int tmp = 1;
        protected CellState item;
        protected CellField cells;

        public void setCells(CellField cells)
        {
            this.cells = cells;
        }

        public CellValueList check(int column, int row)
        {
            connected = new CellValueList();

            item = cells.get(column, row);
            CellValue v = new CellValue(column, row, item);
            connected.Add(v);

            countConnected1(column, row);
            countConnected2(column, row);
            return connected;
        }

        protected abstract void countConnected1(int column, int row);
        protected abstract void countConnected2(int column, int row);

        protected delegate CellValue Condition();

        protected void countRowItems(Condition con)
        {
            tmp = 1;
            while (connected.Count  < 4)
            {
                CellValue v = con.Invoke();
                if (v != CellValue.INVALID)
                {
                    connected.Add(v);
                    tmp++;
                }
                else
                    return;
            }

        }

    }
}
