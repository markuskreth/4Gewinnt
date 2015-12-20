using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4GewinntWinForms.GUI
{
    public partial class OptionsDialog : Form
    {
        private bool okClicked;

        public OptionsDialog()
        {
            InitializeComponent();
            okClicked = false;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            okClicked = true;
            Dispose();
        }

        public Color ColorPlaryer1 { 
            get
            {
                return colorPlayer1.BackColor;
            }
            set
            {
                colorPlayer1.BackColor = value;
            }
        }
        
        public Color ColorPlaryer2 {

            get
            {
                return colorPlayer2.BackColor;
            }
            set
            {
                colorPlayer2.BackColor = value;
            }
        }

        public bool RandomStartplayerAlways {
            get
            {
                return checkBox1.Checked;
            }
                set
            {
                checkBox1.Checked = value;
            }
        }

        public bool OkClicked { 
            get
            {
                return okClicked;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            colorDialog1.Color = ColorPlaryer1;
            DialogResult result =  colorDialog1.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ColorPlaryer1 = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            colorDialog1.Color = ColorPlaryer2;
            DialogResult result = colorDialog1.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ColorPlaryer2 = colorDialog1.Color;
            }
        }
    }
}
