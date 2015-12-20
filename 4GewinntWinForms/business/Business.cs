using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4GewinntWinForms.business
{
    public class Business
    {
        private GameStateChecker checker;
        private GameState _currentState;
        private CellField cells;

        public Business()
        {
            checker = new GameStateChecker();
            _currentState = GameState.Tie;
            startNewGame();
        }

        /// <summary>
        /// Aktuelle Zellen (unmodifiable)
        /// </summary>
        public CellValueList Cells
        {
            get
            {
                return cells.Cells();
            }
        }

        public CellState get(int column, int row)
        {
            return cells.get(column, row);
        }

        public byte ColumnCount
        {
            get
            {
                int cols = cells.ColumnCount();
                return (byte)cols;
            }
        }

        public byte RowCount
        {
            get
            {
                int cols = cells.RowCount();
                return (byte)cols;
            }
        }

        /// <summary>
        /// Startet ein ein neues Spiel, ein laufendes wird verworfen.
        /// </summary>
        /// <returns></returns>
        public GameState startNewGame()
        {
            cells = new CellField(7, 6);
            _currentState = GameState.Player1;
            return _currentState;
        }

        /// <summary>
        /// Aktueller Spielstatus.
        /// </summary>
        public GameState CurrentState
        {
            get
            {
                return _currentState;
            }
        }

        public GameState randomStartPlayer()
        {
            if (isFieldEmpty())
            {
                int index = new Random().Next(2);
                if (index == 0)
                    _currentState = GameState.Player1;
                else
                    _currentState = GameState.Player2;
                
                if (index > 1)
                    throw new IndexOutOfRangeException("Ungültige Zufallszahl");
            }
            return _currentState;
        }

        /// <summary>
        /// Spielzug des aktuellen Spielers <see cref="CurrentState" />
        /// </summary>
        /// <param name="column">Spalte, in die der Spiele seinen Zug setzt</param>
        /// <returns></returns>
        public GameState doMove(int column)
        {
            CellState player;
            GameState nextState = _currentState;

            if (_currentState == GameState.Player1)
            {
                player = CellState.Player1;
                nextState = GameState.Player2;
            }
            else if (_currentState == GameState.Player2)
            {
                player = CellState.Player2;
                nextState = GameState.Player1;
            }
            else
                return _currentState;

            int row = 0;
            while (cells.get(column, row) != CellState.Empty)
                row++;

            cells.set(column, row, player);
            List<CellValue> connected = checker.findConnectedLines(cells, column, row);

            if (connected.Count >= 4)
                nextState = makePlayerWin(player);
            else if (isFieldFull())
                nextState = GameState.Tie;

            _currentState = nextState;
            return _currentState;
        }

        private bool isFieldFull()
        {
            bool nothingEmpty = true;
            for (int column = 0; column < cells.ColumnCount(); column++)
            {
                if (cells.get(column, cells.RowCount() - 1) == CellState.Empty)
                {
                    nothingEmpty = false;
                    break;
                }
            }

            return nothingEmpty;
        }

        private bool isFieldEmpty()
        {
            bool empty = true;
            for (int column = 0; column < cells.ColumnCount(); column++)
            {
                if (cells.get(column, 0) != CellState.Empty)
                {
                    empty = false;
                    break;
                }
            }

            return empty;
        }

        private GameState makePlayerWin(CellState state)
        {
            GameState st = GameState.Tie;

            if (state == CellState.Player1)
                st = GameState.Player1HasWon;
            else if (state == CellState.Player2)
                st = GameState.Player2HasWon;
            return st;
        }

        public override string ToString()
        {
            return cells.ToString();
        }
    }
}
