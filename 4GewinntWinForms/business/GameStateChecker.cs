using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    class GameStateChecker
    {

        private int rowLength = 1;
        private int tmp = 1;

        public GameState checkGameEnd(CellField cells, GameState _currentState, int column, int row)
        {
            CellState item = cells.get(column, row);
            GameState nextState = map(item);
            
            rowLength = 1;
            tmp = 1;
            Condition con = delegate() 
            { 
                bool result = rowLength < 4;
                result &= row + tmp < cells.GetLength1();
                if (result)
                    result &= cells.get(column, row + tmp) == item;
                return result; 
            };

            CalcTmp calc = delegate() { 
                tmp++; 
            };
            countRowItems(con, calc);

            tmp = 1;
            con = delegate()
            { 
                bool result = rowLength < 4;
                result &= row - tmp >= 0;
                if (result)
                    result &= cells.get(column, row - tmp) == item;
                return result; 
            };
            calc = delegate() { tmp++; };
            countRowItems(con, calc);

            if (rowLength == 4)
                return makePlayerWin(nextState);

            rowLength = 1;
            tmp = 1;
            con = delegate()
            {
                bool result = rowLength < 4;
                result &= column + tmp < cells.GetLength0();
                if (result)
                    result &= cells.get(column + tmp, row) == item;
                return result;
            };
            calc = delegate() { tmp++; };
            countRowItems(con, calc);

            tmp = 1;
            con = delegate()
            {
                bool result = rowLength < 4;
                result &= column - tmp >= 0;
                if (result)
                    result &= cells.get(column - tmp, row) == item;
                return result;
            };
            calc = delegate() { tmp++; };
            countRowItems(con, calc);

            if (rowLength == 4)
                return makePlayerWin(nextState);

            return switchPlayer(nextState);
        }
        
        private delegate bool Condition();
        private delegate void CalcTmp();

        private void countRowItems(Condition con, CalcTmp calc)
        {
            while (con.Invoke())
            {
                calc.Invoke();
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
