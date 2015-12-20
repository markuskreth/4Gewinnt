using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    /// <summary>
    /// Wert Repräsentation eines vier Gewinnt Spiels.
    /// <para>
    /// Die Koordinaten des Spielfelds entsprechen dem des Spielfelds bzw einer Tabelle: 0,0 ist unten links.
    /// </para>
    /// 
    /// <example>
    /// Beispiel: 
    /// <code>
    /// 5,0  5,1  5,2  5,3  5,4  5,5  5,6
    /// .
    /// .
    /// 1,0  1,1  1,2  ...
    /// 0,0  0,1  0,2  0,3  0,4  0,5  0,6
    /// </code>
    /// </example>
    /// </summary>
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

        public CellValueList Cells()
        {
            CellValueList list = new CellValueList();

            for (int col = 0; col < ColumnCount(); col++)
            {
                for (int row = 0; row < RowCount(); row++)
                {
                    list.Add(new CellValue(col, row, get(col, row)));
                }
            }

            return list;
        }

        public CellState get(int column, int row)
        {
            return cells[column, row];
        }

        public void set(int column, int row, CellState state)
        {
            cells[column, row] = state;
        }

        internal int RowCount()
        {
            return cells.GetLength(1);
        }

        internal int ColumnCount()
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
