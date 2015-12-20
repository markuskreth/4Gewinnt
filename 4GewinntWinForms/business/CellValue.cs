using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    public class CellValue
    {

        public static CellValue INVALID = new CellValue(-1, -1, CellState.Empty);

        public int Column { get; set; }
        public int Row { get; set; }
        public CellState Value { get; set; }

        public CellValue(int col, int row, CellState value)
        {
            Column = col;
            Row = row;
            Value = value;
        }

        public override bool Equals(object obj)
        {
            if (System.Object.ReferenceEquals(this, obj))
                return true;

            CellValue other = obj as CellValue;
            if (other == null)
                return false;

            return Column == other.Column && Row == other.Row && Value == other.Value;
        }

        public override int GetHashCode()
        {
            return Column ^ Row ^ Value.GetHashCode();
        }
    }
}
