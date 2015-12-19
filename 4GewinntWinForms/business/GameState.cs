using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    public enum GameState
    {
        /// <summary>
        /// Spieler 1 ist am Zug
        /// </summary>
        Player1,
        /// <summary>
        /// Spieler 2 ist am Zug
        /// </summary>
        Player2,
        /// <summary>
        /// Spiel beendet - unentschieden
        /// </summary>
        Tie,
        /// <summary>
        /// Spiel beendet - Spieler 1 hat gewonnen
        /// </summary>
        Player1HasWon,
        /// <summary>
        /// Spiel beendet - Spieler 2 hat gewonnen
        /// </summary>
        Player2HasWon
    }
}
