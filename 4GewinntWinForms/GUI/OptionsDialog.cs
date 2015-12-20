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
        private bool randomStartPl = false;
        private string namePlayer1 = "";
        private string namePlayer2 = "";

        public OptionsDialog()
        {
            InitializeComponent();
            okClicked = false;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            okClicked = true;

            randomStartPl = checkBox1.Checked;
            namePlayer1 = textBoxPlayer1Name.Text;
            namePlayer2 = textBoxPlayer2Name.Text;
            Dispose();
        }

        public Color ColorPlayer1 { 
            get
            {
                return colorPlayer1.BackColor;
            }
            set
            {
                colorPlayer1.BackColor = value;
            }
        }

        public String NamePlayer1
        {
            get
            {
                return namePlayer1;
            }
            set
            {
                textBoxPlayer1Name.Text = value;
                namePlayer1 = value;
            }
        }

        public Color ColorPlayer2 {

            get
            {
                return colorPlayer2.BackColor;
            }
            set
            {
                colorPlayer2.BackColor = value;
            }
        }

        public String NamePlayer2
        {
            get
            {
                return namePlayer2;
            }
            set
            {
                textBoxPlayer2Name.Text = value;
                namePlayer2 = value;
            }
        }

        public bool RandomStartplayerAlways {
            get
            {
                return randomStartPl;
            }
                set
            {
                checkBox1.Checked = value;
                randomStartPl = value;
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
            
            colorDialog1.Color = ColorPlayer1;
            DialogResult result =  colorDialog1.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ColorPlayer1 = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            colorDialog1.Color = ColorPlayer2;
            DialogResult result = colorDialog1.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ColorPlayer2 = colorDialog1.Color;
            }
        }

    }
}
