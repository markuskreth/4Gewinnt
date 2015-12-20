using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    public class GameStateChecker
    {

        List<ConnectedFieldsChecker> checkerList = new List<ConnectedFieldsChecker>();
        
        public GameStateChecker()
        {
            checkerList.Add(new ConnectedFieldsCheckerVertical());
            checkerList.Add(new ConnectedFieldsCheckerHorizontal());
            checkerList.Add(new ConnectedFieldsCheckerDiagonal1());
            checkerList.Add(new ConnectedFieldsCheckerDiagonal2());
        }

        public CellValueList findConnectedLines(CellField cells, int column, int row)
        {
            GameState _currentState = map(cells.get(column, row));
            CellValueList values;

            foreach (ConnectedFieldsChecker checker in checkerList)
            {
                checker.setCells(cells);
                values = checker.check(column, row);

                if (values.Count == 4)
                    return values;

            }

            return new CellValueList();
        }

        private delegate bool Condition();

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

    }
}
