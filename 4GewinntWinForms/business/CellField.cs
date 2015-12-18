using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    public class CellField
    {
        private CellState[,] cells;

        public CellField(byte width, byte hight)
        {
            cells = new CellState[width, hight];

            for (int y = 0; y < width; y++)
            {
                for (int x = 0; x < hight; x++)
                {
                    cells[y, x] = CellState.Empty;
                }
            }
        }

        public CellState[,] Cells()
        {
            return (CellState[,])cells.Clone();
        }

        public CellState get(int column, int row)
        {
            return cells[column, row];
        }

        public void set(int column, int row, CellState state)
        {
            cells[column, row] = state;
        }

        internal int GetLength1()
        {
            return cells.GetLength(1);
        }

        internal int GetLength0()
        {
            return cells.GetLength(0);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            for (int y = cells.GetLength(1) - 1; y >= 0; y--)
            {
                for (int x = 0; x < cells.GetLength(0); x++)
                {
                    switch (cells[x, y])
                    {
                        case CellState.Player1:
                            str.Append("1 ");
                            break;
                        case CellState.Player2:
                            str.Append("2 ");
                            break;
                        case CellState.Empty:
                            str.Append("  ");
                            break;
                    }

                }
                str.AppendLine();
            }
            return str.ToString();
        }
    }
}
