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
        }

        private void initCells()
        {
            tableLayoutPanel1.Controls.Clear();
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
            CellControl control = sender as CellControl;

            if (control != null)
            {
                business.doMove(control.Column);
                updateColumn(control.Column);
                showNewGameState();
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
            MessageBox.Show("Neuer GameState=" + business.CurrentState);
        }

        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            business.startNewGame();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

    }
}
