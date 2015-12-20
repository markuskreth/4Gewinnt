using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    public class GameStateChecker
    {

        private int rowLength = 1;
        private int tmp = 1;

        public GameState checkGameEnd(CellField cells, int column, int row)
        {
            GameState _currentState = map(cells.get(column, row));
            List<ConnectedFieldsChecker> checkerList = new List<ConnectedFieldsChecker>();
            checkerList.Add(new ConnectedFieldsCheckerVertical(cells));
            checkerList.Add(new ConnectedFieldsCheckerHorizontal(cells));

            foreach (ConnectedFieldsChecker checker in checkerList)
            {

                rowLength = checker.check(column, row);

                if (rowLength == 4)
                    return makePlayerWin(_currentState);

            }

            return switchPlayer(_currentState);
        }

        private delegate bool Condition();

        private void countRowItems(Condition con)
        {
            while (con.Invoke())
            {
                tmp++;
                rowLength++;
            }
        }

        private GameState map(CellState cellState)
        {
            if (cellState == CellState.Player1)
                return GameState.Player1;

            if (cellState == CellState.Player2)
                return GameState.Player2;

            return GameState.Tie;
        }

        private GameState switchPlayer(GameState state)
        {
            if (state == GameState.Player1)
                state = GameState.Player2;
            else if (state == GameState.Player2)
                state = GameState.Player1;
            return state;
        }

        private GameState makePlayerWin(GameState state)
        {
            if (state == GameState.Player1)
                state = GameState.Player1HasWon;
            else if (state == GameState.Player2)
                state = GameState.Player2HasWon;
            return state;
        }

    }
}
