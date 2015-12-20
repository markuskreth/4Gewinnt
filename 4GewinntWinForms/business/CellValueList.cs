using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    public class CellValueList : List<CellValue>
    {
        public override bool Equals(object obj)
        {
            if (System.Object.ReferenceEquals(this, obj))
                return true;

            List<CellValue> list = obj as List<CellValue>;

            if (list == null)   // Überflüssig, ReferenceEquals sollte das abfangen. 
                return false;
            
            if (this.Count != list.Count)
                return false;

            for (int i = 0; i < Count; i++)
            {
                if ( ! list.Contains(this[i]))
                    return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            List<CellValue> sorted = new List<CellValue>(this);
            sorted.Sort();

            int hash = 19;

            foreach (var e in sorted)
            {
                hash = hash * 31 + e.GetHashCode();
            }
            return hash;
        }
    }
}
