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
        private String Player1Name = "Player 1";
        private String Player2Name = "Player 2";

        /// <summary>
        /// Der Index jedes CellControls wird berechnet durch Row * 100 + Column
        /// </summary>
        private Dictionary<int, CellControl> cellControlls; 
        
        public SpielBrett()
        {
            cellControlls = new Dictionary<int, CellControl>();
            InitializeComponent();
            this.business = new business.Business();
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

        private String StateToSting(GameState state)
        {
            String playerName = "";

            switch (state)
            {
                case GameState.Player1:
                    return "An der Reihe: " + Player1Name + " ";
                case GameState.Player2:
                    return "An der Reihe: " + Player2Name + " ";
                case GameState.Tie:
                    return "Spiel beendet: Unentschieden";
                case GameState.Player1HasWon:
                    if (player1Color.IsNamedColor)
                        playerName = Player1Name ;
                    else
                        playerName = " 1";
                    return "Spiel beendet: " + playerName + " hat gewonnen!";
                case GameState.Player2HasWon:

                    if (player2Color.IsNamedColor)
                        playerName = Player2Name;
                    else
                        playerName = " 2";
                    return "Spiel beendet: " + playerName + " hat gewonnen!";
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
                    try
                    {
                        business.doMove(control.Column);
                        updateColumn(control.Column);
                        showNewGameState();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Diese Spalte ist schon geüllt!", "Fehler");
                    }
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
            toolStripStatusPlayer.Text = StateToSting(business.CurrentState);
            if (business.CurrentState == GameState.Player2HasWon || business.CurrentState == GameState.Player1HasWon || business.CurrentState == GameState.Tie)
            {
                DialogResult result =  MessageBox.Show(this, StateToSting(business.CurrentState) + "\r\n" + "Neues Spiel beginnen?", "Spiel beendet", MessageBoxButtons.YesNo);
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
            dlg.ColorPlayer1 = player1Color;
            dlg.ColorPlayer2 = player2Color;
            dlg.NamePlayer1 = Player1Name;
            dlg.NamePlayer2 = Player2Name;

            dlg.ShowDialog(this);

            if (dlg.OkClicked)
            {
                bool mustRefreshPlayer = false;
                this.randomStartPlayerAlways = dlg.RandomStartplayerAlways;

                if (this.player1Color != dlg.ColorPlayer1 || this.player2Color != dlg.ColorPlayer2 || this.Player1Name != dlg.NamePlayer1  || this.Player2Name != dlg.NamePlayer2 )
                    mustRefreshPlayer = true;

                this.player1Color = dlg.ColorPlayer1;
                this.player2Color = dlg.ColorPlayer2;
                this.Player1Name = dlg.NamePlayer1;
                this.Player2Name = dlg.NamePlayer2;

                if (mustRefreshPlayer)
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

        private void SpielBrett_Load(object sender, EventArgs e)
        {
            this.Player1Name = Properties.Settings.Default.Player1Name;
            this.Player2Name = Properties.Settings.Default.Player2Name;

            this.player1Color = Properties.Settings.Default.Player1Color;
            this.player2Color = Properties.Settings.Default.Player2Color;
            this.randomStartPlayerAlways = Properties.Settings.Default.RandomStartPlayer;

            initCells();
            showNewGameState();
        }

        private void SpielBrett_FormClosing(object sender, FormClosingEventArgs e)
        {

            Properties.Settings.Default.Player1Name = this.Player1Name;
            Properties.Settings.Default.Player2Name = this.Player2Name;

            Properties.Settings.Default.Player1Color = this.player1Color;
            Properties.Settings.Default.Player2Color = this.player2Color;
            this.randomStartPlayerAlways = Properties.Settings.Default.RandomStartPlayer;

            Properties.Settings.Default.Save();
        }

    }
}
