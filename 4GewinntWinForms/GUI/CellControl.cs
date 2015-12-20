using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _4GewinntWinForms.business;

namespace _4GewinntWinForms
{
    public partial class CellControl : UserControl
    {
        private CellState state;
                
        public CellControl()
        {
            InitializeComponent();
            state = CellState.Empty;
            Resize += new EventHandler(CellControl_Resize);
        }

        void CellControl_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        public int Column { get; set; }
        public int Row { get; set; }

        protected override void OnPaintBackground(PaintEventArgs pe)
        {
            base.OnPaintBackground(pe);
            Color color = StateToColor(this.state);

            Pen myPen = new Pen(color);
            SolidBrush myBrush = new SolidBrush(color);
            
            int diameter = this.Size.Width;
            
            if (this.Size.Height < diameter)
                diameter =  this.Size.Height;

            int x = 2;
            int y = 2;

            diameter = diameter - 4;

            pe.Graphics.FillEllipse(myBrush, x, y, diameter, diameter);
        }

        private Color StateToColor(CellState state)
        {
            if (state == CellState.Player1)
                return Color.Red;

            if (state == CellState.Player2)
                return Color.Yellow;

            return Color.DarkGray;
            
        }
        
        public CellState Status
        {
            get
            {
                return state;
            }
            set
            {
                if (state != value)
                {
                    state = value;
                    Invalidate();
                }
            }
        }
    }
}
