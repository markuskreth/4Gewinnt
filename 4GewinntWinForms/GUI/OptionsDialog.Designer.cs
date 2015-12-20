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
            this.label1 = new System.Windows.Forms.Label();
            this.colorPlayer1 = new System.Windows.Forms.Label();
            this.buttonColorPlayer1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonColorPlayer2 = new System.Windows.Forms.Button();
            this.colorPlayer2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Farbe Spieler 1";
            // 
            // colorPlayer1
            // 
            this.colorPlayer1.BackColor = System.Drawing.Color.Red;
            this.colorPlayer1.Location = new System.Drawing.Point(98, 37);
            this.colorPlayer1.Name = "colorPlayer1";
            this.colorPlayer1.Size = new System.Drawing.Size(37, 13);
            this.colorPlayer1.TabIndex = 4;
            // 
            // buttonColorPlayer1
            // 
            this.buttonColorPlayer1.Image = ((System.Drawing.Image)(resources.GetObject("buttonColorPlayer1.Image")));
            this.buttonColorPlayer1.Location = new System.Drawing.Point(142, 26);
            this.buttonColorPlayer1.Name = "buttonColorPlayer1";
            this.buttonColorPlayer1.Size = new System.Drawing.Size(75, 23);
            this.buttonColorPlayer1.TabIndex = 5;
            this.buttonColorPlayer1.UseVisualStyleBackColor = true;
            this.buttonColorPlayer1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Farbe Spieler 2";
            // 
            // buttonColorPlayer2
            // 
            this.buttonColorPlayer2.Image = ((System.Drawing.Image)(resources.GetObject("buttonColorPlayer2.Image")));
            this.buttonColorPlayer2.Location = new System.Drawing.Point(141, 55);
            this.buttonColorPlayer2.Name = "buttonColorPlayer2";
            this.buttonColorPlayer2.Size = new System.Drawing.Size(75, 23);
            this.buttonColorPlayer2.TabIndex = 8;
            this.buttonColorPlayer2.UseVisualStyleBackColor = true;
            this.buttonColorPlayer2.Click += new System.EventHandler(this.button2_Click);
            // 
            // colorPlayer2
            // 
            this.colorPlayer2.BackColor = System.Drawing.Color.Yellow;
            this.colorPlayer2.Location = new System.Drawing.Point(98, 60);
            this.colorPlayer2.Name = "colorPlayer2";
            this.colorPlayer2.Size = new System.Drawing.Size(37, 13);
            this.colorPlayer2.TabIndex = 7;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // OptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonColorPlayer2);
            this.Controls.Add(this.colorPlayer2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonColorPlayer1);
            this.Controls.Add(this.colorPlayer1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label colorPlayer1;
        private System.Windows.Forms.Button buttonColorPlayer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonColorPlayer2;
        private System.Windows.Forms.Label colorPlayer2;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}