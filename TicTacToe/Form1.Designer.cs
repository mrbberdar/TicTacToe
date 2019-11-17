namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tile00 = new System.Windows.Forms.Button();
            this.tile10 = new System.Windows.Forms.Button();
            this.tile20 = new System.Windows.Forms.Button();
            this.tile11 = new System.Windows.Forms.Button();
            this.tile01 = new System.Windows.Forms.Button();
            this.tile21 = new System.Windows.Forms.Button();
            this.tile02 = new System.Windows.Forms.Button();
            this.tile12 = new System.Windows.Forms.Button();
            this.tile22 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tictactoeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newgameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreboxPlayer = new System.Windows.Forms.TextBox();
            this.tieBox = new System.Windows.Forms.TextBox();
            this.scoreboxComp = new System.Windows.Forms.TextBox();
            this.playerSwitch = new System.Windows.Forms.Button();
            this.labelComputer = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tile00
            // 
            this.tile00.BackColor = System.Drawing.Color.White;
            this.tile00.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tile00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tile00.Location = new System.Drawing.Point(12, 29);
            this.tile00.Name = "tile00";
            this.tile00.Size = new System.Drawing.Size(100, 100);
            this.tile00.TabIndex = 0;
            this.tile00.UseVisualStyleBackColor = false;
            this.tile00.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tile00_MouseDown);
            // 
            // tile10
            // 
            this.tile10.BackColor = System.Drawing.Color.White;
            this.tile10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tile10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tile10.Location = new System.Drawing.Point(12, 126);
            this.tile10.Name = "tile10";
            this.tile10.Size = new System.Drawing.Size(100, 100);
            this.tile10.TabIndex = 1;
            this.tile10.UseVisualStyleBackColor = false;
            this.tile10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tile10_MouseDown);
            // 
            // tile20
            // 
            this.tile20.BackColor = System.Drawing.Color.White;
            this.tile20.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tile20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tile20.Location = new System.Drawing.Point(12, 223);
            this.tile20.Name = "tile20";
            this.tile20.Size = new System.Drawing.Size(100, 100);
            this.tile20.TabIndex = 2;
            this.tile20.UseVisualStyleBackColor = false;
            this.tile20.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tile20_MouseDown);
            // 
            // tile11
            // 
            this.tile11.BackColor = System.Drawing.Color.White;
            this.tile11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tile11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tile11.Location = new System.Drawing.Point(111, 126);
            this.tile11.Name = "tile11";
            this.tile11.Size = new System.Drawing.Size(100, 100);
            this.tile11.TabIndex = 3;
            this.tile11.UseVisualStyleBackColor = false;
            this.tile11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tile11_MouseDown);
            // 
            // tile01
            // 
            this.tile01.BackColor = System.Drawing.Color.White;
            this.tile01.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tile01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tile01.Location = new System.Drawing.Point(111, 29);
            this.tile01.Name = "tile01";
            this.tile01.Size = new System.Drawing.Size(100, 98);
            this.tile01.TabIndex = 4;
            this.tile01.UseVisualStyleBackColor = false;
            this.tile01.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tile01_MouseDown);
            // 
            // tile21
            // 
            this.tile21.BackColor = System.Drawing.Color.White;
            this.tile21.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tile21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tile21.Location = new System.Drawing.Point(111, 223);
            this.tile21.Name = "tile21";
            this.tile21.Size = new System.Drawing.Size(100, 100);
            this.tile21.TabIndex = 5;
            this.tile21.UseVisualStyleBackColor = false;
            this.tile21.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tile21_MouseDown);
            // 
            // tile02
            // 
            this.tile02.BackColor = System.Drawing.Color.White;
            this.tile02.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tile02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tile02.Location = new System.Drawing.Point(210, 29);
            this.tile02.Name = "tile02";
            this.tile02.Size = new System.Drawing.Size(100, 100);
            this.tile02.TabIndex = 6;
            this.tile02.UseVisualStyleBackColor = false;
            this.tile02.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tile02_MouseDown);
            // 
            // tile12
            // 
            this.tile12.BackColor = System.Drawing.Color.White;
            this.tile12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tile12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tile12.Location = new System.Drawing.Point(210, 126);
            this.tile12.Name = "tile12";
            this.tile12.Size = new System.Drawing.Size(100, 100);
            this.tile12.TabIndex = 7;
            this.tile12.UseVisualStyleBackColor = false;
            this.tile12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tile12_MouseDown);
            // 
            // tile22
            // 
            this.tile22.BackColor = System.Drawing.Color.White;
            this.tile22.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tile22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tile22.Location = new System.Drawing.Point(210, 223);
            this.tile22.Name = "tile22";
            this.tile22.Size = new System.Drawing.Size(100, 100);
            this.tile22.TabIndex = 8;
            this.tile22.UseVisualStyleBackColor = false;
            this.tile22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tile22_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tictactoeMenu,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tictactoeMenu
            // 
            this.tictactoeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newgameMenu,
            this.exitMenu});
            this.tictactoeMenu.Name = "tictactoeMenu";
            this.tictactoeMenu.Size = new System.Drawing.Size(78, 20);
            this.tictactoeMenu.Text = "Tic Tac Toe";
            // 
            // newgameMenu
            // 
            this.newgameMenu.Name = "newgameMenu";
            this.newgameMenu.Size = new System.Drawing.Size(132, 22);
            this.newgameMenu.Text = "New Game";
            this.newgameMenu.Click += new System.EventHandler(this.newgameMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(132, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "TIE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "O";
            // 
            // scoreboxPlayer
            // 
            this.scoreboxPlayer.BackColor = System.Drawing.Color.White;
            this.scoreboxPlayer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.scoreboxPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboxPlayer.Location = new System.Drawing.Point(86, 392);
            this.scoreboxPlayer.Name = "scoreboxPlayer";
            this.scoreboxPlayer.ReadOnly = true;
            this.scoreboxPlayer.Size = new System.Drawing.Size(36, 22);
            this.scoreboxPlayer.TabIndex = 13;
            this.scoreboxPlayer.TabStop = false;
            this.scoreboxPlayer.Text = "0";
            this.scoreboxPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tieBox
            // 
            this.tieBox.BackColor = System.Drawing.Color.White;
            this.tieBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tieBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieBox.Location = new System.Drawing.Point(143, 392);
            this.tieBox.Name = "tieBox";
            this.tieBox.ReadOnly = true;
            this.tieBox.Size = new System.Drawing.Size(36, 22);
            this.tieBox.TabIndex = 14;
            this.tieBox.TabStop = false;
            this.tieBox.Text = "0";
            this.tieBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scoreboxComp
            // 
            this.scoreboxComp.BackColor = System.Drawing.Color.White;
            this.scoreboxComp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.scoreboxComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboxComp.Location = new System.Drawing.Point(198, 392);
            this.scoreboxComp.Name = "scoreboxComp";
            this.scoreboxComp.ReadOnly = true;
            this.scoreboxComp.Size = new System.Drawing.Size(35, 22);
            this.scoreboxComp.TabIndex = 15;
            this.scoreboxComp.TabStop = false;
            this.scoreboxComp.Text = "0";
            this.scoreboxComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerSwitch
            // 
            this.playerSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playerSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerSwitch.Image = ((System.Drawing.Image)(resources.GetObject("playerSwitch.Image")));
            this.playerSwitch.Location = new System.Drawing.Point(129, 420);
            this.playerSwitch.Name = "playerSwitch";
            this.playerSwitch.Size = new System.Drawing.Size(66, 38);
            this.playerSwitch.TabIndex = 17;
            this.playerSwitch.UseVisualStyleBackColor = true;
            this.playerSwitch.Click += new System.EventHandler(this.playerSwitch_Click);
            // 
            // labelComputer
            // 
            this.labelComputer.AutoSize = true;
            this.labelComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputer.Location = new System.Drawing.Point(241, 395);
            this.labelComputer.Name = "labelComputer";
            this.labelComputer.Size = new System.Drawing.Size(76, 13);
            this.labelComputer.TabIndex = 18;
            this.labelComputer.Text = "COMPUTER";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.Location = new System.Drawing.Point(17, 395);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(55, 13);
            this.labelPlayer.TabIndex = 19;
            this.labelPlayer.Text = "PLAYER";
            // 
            // reset
            // 
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset.Location = new System.Drawing.Point(120, 332);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(82, 34);
            this.reset.TabIndex = 20;
            this.reset.Text = "Reset Scores";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 465);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.labelComputer);
            this.Controls.Add(this.playerSwitch);
            this.Controls.Add(this.scoreboxComp);
            this.Controls.Add(this.tieBox);
            this.Controls.Add(this.scoreboxPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tile22);
            this.Controls.Add(this.tile12);
            this.Controls.Add(this.tile02);
            this.Controls.Add(this.tile21);
            this.Controls.Add(this.tile01);
            this.Controls.Add(this.tile11);
            this.Controls.Add(this.tile20);
            this.Controls.Add(this.tile10);
            this.Controls.Add(this.tile00);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tile00;
        private System.Windows.Forms.Button tile10;
        private System.Windows.Forms.Button tile20;
        private System.Windows.Forms.Button tile11;
        private System.Windows.Forms.Button tile01;
        private System.Windows.Forms.Button tile21;
        private System.Windows.Forms.Button tile02;
        private System.Windows.Forms.Button tile12;
        private System.Windows.Forms.Button tile22;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tictactoeMenu;
        private System.Windows.Forms.ToolStripMenuItem newgameMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scoreboxPlayer;
        private System.Windows.Forms.TextBox tieBox;
        private System.Windows.Forms.TextBox scoreboxComp;
        private System.Windows.Forms.Button playerSwitch;
        private System.Windows.Forms.Label labelComputer;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

