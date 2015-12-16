using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    class Business
    {
        private GameState currentState = GameState.Tie;
        private CellState[,] cells;

        public Business()
        {
            startNewGame();
        }

        public GameState startNewGame()
        {
            cells = new CellState[7, 6];
            currentState = GameState.Player1;
            return currentState;
        }

        public GameState doMove(int column)
        {
            return currentState;
        }
    }
}
