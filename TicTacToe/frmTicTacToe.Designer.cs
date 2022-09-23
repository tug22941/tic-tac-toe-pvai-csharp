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
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.txtPlayerOne = new System.Windows.Forms.TextBox();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.btnOK1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOK2 = new System.Windows.Forms.Button();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.txtPlayerTwo = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblVS = new System.Windows.Forms.Label();
            this.lblPlayer1Wins = new System.Windows.Forms.Label();
            this.lblPlayer2Wins = new System.Windows.Forms.Label();
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
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.Location = new System.Drawing.Point(42, 54);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(93, 13);
            this.lblPlayerOne.TabIndex = 2;
            this.lblPlayerOne.Text = "Player One Name:";
            this.lblPlayerOne.Visible = false;
            // 
            // txtPlayerOne
            // 
            this.txtPlayerOne.Location = new System.Drawing.Point(141, 47);
            this.txtPlayerOne.Name = "txtPlayerOne";
            this.txtPlayerOne.Size = new System.Drawing.Size(169, 20);
            this.txtPlayerOne.TabIndex = 0;
            this.txtPlayerOne.Visible = false;
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.Location = new System.Drawing.Point(41, 87);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(94, 13);
            this.lblPlayerTwo.TabIndex = 4;
            this.lblPlayerTwo.Text = "Player Two Name:";
            this.lblPlayerTwo.Visible = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(138, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(178, 13);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "Player One, please enter your name.";
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
            // btnOK2
            // 
            this.btnOK2.Enabled = false;
            this.btnOK2.Location = new System.Drawing.Point(325, 77);
            this.btnOK2.Name = "btnOK2";
            this.btnOK2.Size = new System.Drawing.Size(47, 23);
            this.btnOK2.TabIndex = 5;
            this.btnOK2.Text = "OK";
            this.btnOK2.UseVisualStyleBackColor = true;
            this.btnOK2.Visible = false;
            this.btnOK2.Click += new System.EventHandler(this.btnOK2_Click);
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Location = new System.Drawing.Point(389, 54);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(43, 23);
            this.btnPlayGame.TabIndex = 6;
            this.btnPlayGame.Text = "Play Game";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Visible = false;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // txtPlayerTwo
            // 
            this.txtPlayerTwo.Enabled = false;
            this.txtPlayerTwo.Location = new System.Drawing.Point(141, 79);
            this.txtPlayerTwo.Name = "txtPlayerTwo";
            this.txtPlayerTwo.Size = new System.Drawing.Size(169, 20);
            this.txtPlayerTwo.TabIndex = 4;
            this.txtPlayerTwo.Visible = false;
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
            // lblPlayer1Wins
            // 
            this.lblPlayer1Wins.AutoSize = true;
            this.lblPlayer1Wins.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Wins.Location = new System.Drawing.Point(117, 79);
            this.lblPlayer1Wins.Name = "lblPlayer1Wins";
            this.lblPlayer1Wins.Size = new System.Drawing.Size(46, 23);
            this.lblPlayer1Wins.TabIndex = 0;
            this.lblPlayer1Wins.Text = "N/A";
            this.lblPlayer1Wins.Visible = false;
            // 
            // lblPlayer2Wins
            // 
            this.lblPlayer2Wins.AutoSize = true;
            this.lblPlayer2Wins.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Wins.Location = new System.Drawing.Point(340, 79);
            this.lblPlayer2Wins.Name = "lblPlayer2Wins";
            this.lblPlayer2Wins.Size = new System.Drawing.Size(46, 23);
            this.lblPlayer2Wins.TabIndex = 13;
            this.lblPlayer2Wins.Text = "N/A";
            this.lblPlayer2Wins.Visible = false;
            // 
            // frmTicTacToe
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(504, 549);
            this.Controls.Add(this.lblPlayer2Wins);
            this.Controls.Add(this.lblPlayer1Wins);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.txtPlayerTwo);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.btnOK2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOK1);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblPlayerOne);
            this.Controls.Add(this.txtPlayerOne);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.pnlBoard);
            this.Name = "frmTicTacToe";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.TextBox txtPlayerOne;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button btnOK1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOK2;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.TextBox txtPlayerTwo;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Label lblPlayer1Wins;
        private System.Windows.Forms.Label lblPlayer2Wins;
    }
}

