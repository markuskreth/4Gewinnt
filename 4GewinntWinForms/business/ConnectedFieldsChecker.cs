using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    public abstract class ConnectedFieldsChecker
    {

        protected int rowLength = 1;
        protected int tmp = 1;
        protected CellState item;
        protected CellField cells;

        public ConnectedFieldsChecker(CellField cells)
        {
            this.cells = cells;
        }

        public int check(int column, int row)
        {
            item = cells.get(column, row);
            countConnected1(column, row);
            countConnected2(column, row);
            return rowLength;
        }

        protected abstract void countConnected1(int column, int row);
        protected abstract void countConnected2(int column, int row);

        protected delegate bool Condition();

        protected void countRowItems(Condition con)
        {
            while (rowLength < 4 && con.Invoke())
            {
                tmp++;
                rowLength++;
            }
        }

    }
}
