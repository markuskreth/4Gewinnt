using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    enum  CellState
    {
        Empty,
        /// <summary>
        /// Player one has a stone in this cell
        /// </summary>
        Player1,
        /// <summary>
        /// Player two has a stone in this cell
        /// </summary>
        Player2
    }
}
