using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _4GewinntWinForms.business;

namespace _4GewinntWinForms
{
    public partial class SpielBrett : Form
    {
        private business.Business business;
        /// <summary>
        /// Der Index jedes CellControls wird berechnet durch Row * 100 + Column
        /// </summary>
        private Dictionary<int, CellControl> cellControlls; 
        
        public SpielBrett()
        {
            cellControlls = new Dictionary<int, CellControl>();
            InitializeComponent();
            this.business = new business.Business();
            initCells();
            showNewGameState();
        }

        private Color GameStateToColor(GameState state)
        {
            switch (state)
            {
                case GameState.Player1: 
                    return Color.Red;
                case GameState.Player2:
                    return Color.Yellow;
                case GameState.Tie:
                    return Color.DarkGray;
                case GameState.Player1HasWon: 
                    return Color.Red;
                case GameState.Player2HasWon:
                    return Color.Yellow;
                default:
                    return Color.DarkGray;
            }

            //if (state == CellState.Player1)
            //    return Color.Red;

            //if (state == CellState.Player2)
            //    return Color.Yellow;
        }

        private void initCells()
        {
            tableLayoutPanel1.Controls.Clear();
            cellControlls.Clear();

            int rowCount = business.RowCount;
            int colCount = business.ColumnCount;

            foreach (var cell in business.Cells)
            {

                CellControl control = new CellControl();
                control.Status = cell.Value;

                control.Row = cell.Row;
                control.Column = cell.Column;
                control.Click += new EventHandler(cellControlClick);
                control.Show();
                
                tableLayoutPanel1.Controls.Add(control, cell.Column, rowCount - cell.Row -1);
                cellControlls.Add(cell.Row * 100 + cell.Column, control);
            }
        }

        void cellControlClick(object sender, EventArgs e)
        {
            if (business.CurrentState == GameState.Player2HasWon || business.CurrentState == GameState.Player1HasWon)
            {
                showNewGameState();
            }
            else
            {

                CellControl control = sender as CellControl;

                if (control != null)
                {
                    business.doMove(control.Column);
                    updateColumn(control.Column);
                    showNewGameState();
                }
            }
        }

        private void updateColumn(int column)
        {
            for (int row = 0; row < business.RowCount; row++)
            {
                cellControlls[row * 100 + column].Status = business.get(column, row);
            }
        }

        private void showNewGameState()
        {
            toolStripStatusColor.BackColor = GameStateToColor(business.CurrentState);
            toolStripStatusPlayer.Text = GameStateToSting(business.CurrentState);
            if (business.CurrentState == GameState.Player2HasWon || business.CurrentState == GameState.Player1HasWon || business.CurrentState == GameState.Tie)
            {
                MessageBox.Show(GameStateToSting(business.CurrentState));
            }
            
        }

        private String GameStateToSting(GameState state)
        {
            switch (state)
            {
                case GameState.Player1:
                    return "Spieler";
                case GameState.Player2:
                    return "Spieler";
                case GameState.Tie:
                    return "Spiel beendet: Unentschieden";
                case GameState.Player1HasWon:
                    return "Spiel beendet: Spieler 1 hat gewonnen!";
                case GameState.Player2HasWon:
                    return "Spiel beendet: Spieler 2 hat gewonnen!";
                default:
                    return "";
            }
        }

        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            business.startNewGame();
            initCells();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

    }
}
