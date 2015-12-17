using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    class Business
    {
        private GameState _currentState = GameState.Tie;
        private CellState[,] cells;

        public Business()
        {
            startNewGame();
        }

        /// <summary>
        /// Aktuelle Zellen (unmodifiable)
        /// </summary>
        public CellState[,] Cells
        {
            get
            {
                return (CellState[,])cells.Clone();
            }
        }

        /// <summary>
        /// Startet ein ein neues Spiel, ein laufendes wird verworfen.
        /// </summary>
        /// <returns></returns>
        public GameState startNewGame()
        {
            cells = new CellState[7, 6];
            _currentState = GameState.Player1;
            return _currentState;
        }

        /// <summary>
        /// Aktueller Spielstatus
        /// </summary>
        public GameState CurrentState
        {
            get
            {
                return _currentState;
            }
        }

        /// <summary>
        /// Spielzug des aktuellen Spielers <see cref="CurrentState" />
        /// </summary>
        /// <param name="column">Spalte, in die der Spiele seinen Zug setzt</param>
        /// <returns></returns>
        public GameState doMove(int column)
        {
            CellState player;

            if (_currentState == GameState.Player1)
            {
                player = CellState.Player1;
                _currentState = GameState.Player2;
            }
            else //if (_currentState == GameState.Player2)
            {
                player = CellState.Player2;
                _currentState = GameState.Player1;
            }

            int row = 0;
            while (cells[column, row] != CellState.Empty)
                row++;

            cells[column, row] = player;

            return _currentState;
        }
    }
}
