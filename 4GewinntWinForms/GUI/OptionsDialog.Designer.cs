namespace _4GewinntWinForms.GUI
{
    partial class OptionsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsDialog));
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.colorPlayer1 = new System.Windows.Forms.Label();
            this.buttonColorPlayer1 = new System.Windows.Forms.Button();
            this.buttonColorPlayer2 = new System.Windows.Forms.Button();
            this.colorPlayer2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBoxPlayer1Name = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(197, 227);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(116, 227);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(184, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Starte immer mit zufälligem Spieler";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // colorPlayer1
            // 
            this.colorPlayer1.BackColor = System.Drawing.Color.Red;
            this.colorPlayer1.Location = new System.Drawing.Point(119, 36);
            this.colorPlayer1.Name = "colorPlayer1";
            this.colorPlayer1.Size = new System.Drawing.Size(37, 20);
            this.colorPlayer1.TabIndex = 4;
            // 
            // buttonColorPlayer1
            // 
            this.buttonColorPlayer1.Image = ((System.Drawing.Image)(resources.GetObject("buttonColorPlayer1.Image")));
            this.buttonColorPlayer1.Location = new System.Drawing.Point(162, 34);
            this.buttonColorPlayer1.Name = "buttonColorPlayer1";
            this.buttonColorPlayer1.Size = new System.Drawing.Size(75, 23);
            this.buttonColorPlayer1.TabIndex = 5;
            this.buttonColorPlayer1.UseVisualStyleBackColor = true;
            this.buttonColorPlayer1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonColorPlayer2
            // 
            this.buttonColorPlayer2.Image = ((System.Drawing.Image)(resources.GetObject("buttonColorPlayer2.Image")));
            this.buttonColorPlayer2.Location = new System.Drawing.Point(162, 59);
            this.buttonColorPlayer2.Name = "buttonColorPlayer2";
            this.buttonColorPlayer2.Size = new System.Drawing.Size(75, 23);
            this.buttonColorPlayer2.TabIndex = 8;
            this.buttonColorPlayer2.UseVisualStyleBackColor = true;
            this.buttonColorPlayer2.Click += new System.EventHandler(this.button2_Click);
            // 
            // colorPlayer2
            // 
            this.colorPlayer2.BackColor = System.Drawing.Color.Yellow;
            this.colorPlayer2.Location = new System.Drawing.Point(119, 62);
            this.colorPlayer2.Name = "colorPlayer2";
            this.colorPlayer2.Size = new System.Drawing.Size(37, 21);
            this.colorPlayer2.TabIndex = 7;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // textBoxPlayer1Name
            // 
            this.textBoxPlayer1Name.Location = new System.Drawing.Point(13, 36);
            this.textBoxPlayer1Name.Name = "textBoxPlayer1Name";
            this.textBoxPlayer1Name.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayer1Name.TabIndex = 9;
            this.textBoxPlayer1Name.Text = "Spieler X";
            // 
            // textBoxPlayer2Name
            // 
            this.textBoxPlayer2Name.Location = new System.Drawing.Point(13, 62);
            this.textBoxPlayer2Name.Name = "textBoxPlayer2Name";
            this.textBoxPlayer2Name.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayer2Name.TabIndex = 10;
            this.textBoxPlayer2Name.Text = "Spieler Y";
            // 
            // OptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxPlayer2Name);
            this.Controls.Add(this.textBoxPlayer1Name);
            this.Controls.Add(this.buttonColorPlayer2);
            this.Controls.Add(this.colorPlayer2);
            this.Controls.Add(this.buttonColorPlayer1);
            this.Controls.Add(this.colorPlayer1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Name = "OptionsDialog";
            this.Text = "Optionen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label colorPlayer1;
        private System.Windows.Forms.Button buttonColorPlayer1;
        private System.Windows.Forms.Button buttonColorPlayer2;
        private System.Windows.Forms.Label colorPlayer2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBoxPlayer1Name;
        private System.Windows.Forms.TextBox textBoxPlayer2Name;
    }
}