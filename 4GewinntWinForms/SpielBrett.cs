using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _4GewinntWinForms.business;
using _4GewinntWinForms.GUI;

namespace _4GewinntWinForms
{
    public partial class SpielBrett : Form
    {
        private business.Business business;
        private bool randomStartPlayerAlways = false;
        private Color player1Color = Color.Red;
        private Color player2Color = Color.Yellow;

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
                case GameState.Player1HasWon: 
                    return player1Color;
                case GameState.Player2:
                case GameState.Player2HasWon:
                    return player2Color;
                case GameState.Tie:
                default:
                    return Color.DarkGray;
            }

        }

        private String GameStateToSting(GameState state)
        {
            String playerName = "";

            switch (state)
            {
                case GameState.Player1:
                    return "Spieler";
                case GameState.Player2:
                    return "Spieler";
                case GameState.Tie:
                    return "Spiel beendet: Unentschieden";
                case GameState.Player1HasWon:
                    if (player1Color.IsNamedColor)
                        playerName = player1Color.Name;
                    else
                        playerName = " 1";
                    return "Spiel beendet: Spieler " + playerName + " hat gewonnen!";
                case GameState.Player2HasWon:

                    if (player2Color.IsNamedColor)
                        playerName = player2Color.Name;
                    else
                        playerName = " 2";
                    return "Spiel beendet: Spieler " + playerName + " hat gewonnen!";
                default:
                    return "";
            }
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
                control.StateToColor = StateToColor;

                control.Click += new EventHandler(cellControlClick);
                control.Show();
                
                tableLayoutPanel1.Controls.Add(control, cell.Column, rowCount - cell.Row -1);
                cellControlls.Add(cell.Row * 100 + cell.Column, control);
            }
        }

        private Color StateToColor(CellState state)
        {
            if (state == CellState.Player1)
                return player1Color;

            if (state == CellState.Player2)
                return player2Color;

            return Color.DarkGray;

        }
        void cellControlClick(object sender, EventArgs e)
        {
            toolStripButtonRandomStarter.Enabled = false;

            if (business.CurrentState == GameState.Player2HasWon || business.CurrentState == GameState.Player1HasWon || business.CurrentState == GameState.Tie)
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
                DialogResult result =  MessageBox.Show(this, GameStateToSting(business.CurrentState) + "\r\n" + "Neues Spiel beginnen?", "Spiel beendet", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                    startNewGame();
            }
            
        }

        private void startNewGame()
        {
            toolStripButtonRandomStarter.Enabled = true;
            business.startNewGame();
            initCells();
            if (randomStartPlayerAlways)
                business.randomStartPlayer();

            showNewGameState();
        }

        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startNewGame();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void toolStripButtonNewGame_Click(object sender, EventArgs e)
        {
            startNewGame();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            business.randomStartPlayer();
            showNewGameState();
        }

        private void optionenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsDialog dlg = new OptionsDialog();
            dlg.RandomStartplayerAlways = randomStartPlayerAlways;
            dlg.ColorPlaryer1 = player1Color;
            dlg.ColorPlaryer2 = player2Color;

            dlg.ShowDialog(this);

            if (dlg.OkClicked)
            {
                bool mustRefreshColors = false;
                this.randomStartPlayerAlways = dlg.RandomStartplayerAlways;

                if (this.player1Color != dlg.ColorPlaryer1 || this.player2Color != dlg.ColorPlaryer2)
                    mustRefreshColors = true;

                this.player1Color = dlg.ColorPlaryer1;
                this.player2Color = dlg.ColorPlaryer2;

                if (mustRefreshColors)
                {
                    refreshColors();
                }
            }

        }

        private void refreshColors()
        {
            showNewGameState();
            foreach (var cell in cellControlls)
            {
                cell.Value.Invalidate();
            }
        }

    }
}
