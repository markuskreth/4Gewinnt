using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    public abstract class LineChecker
    {
        
        protected int rowLength = 1;
        protected int tmp = 1;
        protected CellState item;
        protected CellField cells;

        public LineChecker(CellField cells) 
        {
            this.cells = cells;
        }
        
        public int check(int column, int row)
        {
            item = cells.get(column, row);
            countConnected(column, row);
            return rowLength;
        }

        protected abstract void countConnected(int column, int row);

        protected delegate bool Condition();

        protected void countRowItems(Condition con)
        {
            while (con.Invoke())
            {
                tmp++;
                rowLength++;
            }
        }

    }
}
