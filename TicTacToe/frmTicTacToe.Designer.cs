namespace TicTacToe
{
    partial class frmTicTacToe
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.btnOK1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblVS = new System.Windows.Forms.Label();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblAIWins = new System.Windows.Forms.Label();
            this.txtAI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStart.Location = new System.Drawing.Point(12, 505);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(42, 54);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(93, 13);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "Player One Name:";
            this.lblPlayer.Visible = false;
            // 
            // txtPlayer
            // 
            this.txtPlayer.Location = new System.Drawing.Point(141, 47);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(169, 20);
            this.txtPlayer.TabIndex = 0;
            this.txtPlayer.Visible = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(138, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(121, 13);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "Please enter your name.";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInstructions.Visible = false;
            // 
            // pnlBoard
            // 
            this.pnlBoard.Enabled = false;
            this.pnlBoard.Location = new System.Drawing.Point(12, 123);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(480, 376);
            this.pnlBoard.TabIndex = 7;
            this.pnlBoard.Visible = false;
            // 
            // btnOK1
            // 
            this.btnOK1.Location = new System.Drawing.Point(325, 44);
            this.btnOK1.Name = "btnOK1";
            this.btnOK1.Size = new System.Drawing.Size(47, 23);
            this.btnOK1.TabIndex = 1;
            this.btnOK1.Text = "OK";
            this.btnOK1.UseVisualStyleBackColor = true;
            this.btnOK1.Visible = false;
            this.btnOK1.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(93, 505);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Location = new System.Drawing.Point(220, 82);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(43, 23);
            this.btnPlayGame.TabIndex = 6;
            this.btnPlayGame.Text = "Play Game";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Visible = false;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRestart.Location = new System.Drawing.Point(174, 505);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 10;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.Location = new System.Drawing.Point(220, 43);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(43, 29);
            this.lblVS.TabIndex = 12;
            this.lblVS.Text = "VS";
            this.lblVS.Visible = false;
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWins.Location = new System.Drawing.Point(117, 79);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(46, 23);
            this.lblPlayerWins.TabIndex = 0;
            this.lblPlayerWins.Text = "N/A";
            this.lblPlayerWins.Visible = false;
            // 
            // lblAIWins
            // 
            this.lblAIWins.AutoSize = true;
            this.lblAIWins.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIWins.Location = new System.Drawing.Point(340, 79);
            this.lblAIWins.Name = "lblAIWins";
            this.lblAIWins.Size = new System.Drawing.Size(46, 23);
            this.lblAIWins.TabIndex = 13;
            this.lblAIWins.Text = "N/A";
            this.lblAIWins.Visible = false;
            // 
            // txtAI
            // 
            this.txtAI.Enabled = false;
            this.txtAI.Location = new System.Drawing.Point(141, 79);
            this.txtAI.Name = "txtAI";
            this.txtAI.Size = new System.Drawing.Size(169, 20);
            this.txtAI.TabIndex = 15;
            this.txtAI.Visible = false;
            // 
            // frmTicTacToe
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(504, 549);
            this.Controls.Add(this.txtAI);
            this.Controls.Add(this.lblAIWins);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOK1);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.pnlBoard);
            this.Name = "frmTicTacToe";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button btnOK1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblAIWins;
        private System.Windows.Forms.TextBox txtAI;
    }
}

