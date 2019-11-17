namespace TicTacToe
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 120);
            this.panel1.TabIndex = 0;
            // 
            // aboutBox
            // 
            this.aboutBox.Location = new System.Drawing.Point(156, 57);
            this.aboutBox.Multiline = true;
            this.aboutBox.Name = "aboutBox";
            this.aboutBox.ReadOnly = true;
            this.aboutBox.Size = new System.Drawing.Size(175, 147);
            this.aboutBox.TabIndex = 1;
            this.aboutBox.TabStop = false;
            this.aboutBox.Text = "Tic Tac Toe Game v1.0\r\n\r\nBalazs Berdar\r\nmr.bberdar@hotmail.com";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 277);
            this.Controls.Add(this.aboutBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(900, 250);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "About";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox aboutBox;
    }
}