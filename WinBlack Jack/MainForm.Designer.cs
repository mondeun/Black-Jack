namespace WinBlack_Jack
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStay = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnBet = new System.Windows.Forms.Button();
            this.txtBoxBet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.picBoxPlayer2 = new System.Windows.Forms.PictureBox();
            this.picBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.picBoxDealer2 = new System.Windows.Forms.PictureBox();
            this.picBoxDealer1 = new System.Windows.Forms.PictureBox();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.txtBoxMoney = new System.Windows.Forms.TextBox();
            this.picBoxPlayer4 = new System.Windows.Forms.PictureBox();
            this.picBoxPlayer3 = new System.Windows.Forms.PictureBox();
            this.picBoxPlayer6 = new System.Windows.Forms.PictureBox();
            this.picBoxPlayer5 = new System.Windows.Forms.PictureBox();
            this.picBoxDealer4 = new System.Windows.Forms.PictureBox();
            this.picBoxDealer6 = new System.Windows.Forms.PictureBox();
            this.picBoxDealer3 = new System.Windows.Forms.PictureBox();
            this.picBoxDealer5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxHand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDealer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDealer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDealer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDealer6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDealer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDealer5)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnStay
            // 
            this.btnStay.Enabled = false;
            this.btnStay.Location = new System.Drawing.Point(356, 526);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(75, 23);
            this.btnStay.TabIndex = 0;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // btnHit
            // 
            this.btnHit.Enabled = false;
            this.btnHit.Location = new System.Drawing.Point(469, 526);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 1;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(244, 526);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 23);
            this.btnBet.TabIndex = 4;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // txtBoxBet
            // 
            this.txtBoxBet.Location = new System.Drawing.Point(244, 481);
            this.txtBoxBet.Name = "txtBoxBet";
            this.txtBoxBet.Size = new System.Drawing.Size(75, 20);
            this.txtBoxBet.TabIndex = 3;
            this.txtBoxBet.Text = "0";
            this.txtBoxBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bet";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(375, 250);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(54, 13);
            this.lblPlayerName.TabIndex = 10;
            this.lblPlayerName.Text = "Player #";
            // 
            // picBoxPlayer2
            // 
            this.picBoxPlayer2.Location = new System.Drawing.Point(399, 277);
            this.picBoxPlayer2.Name = "picBoxPlayer2";
            this.picBoxPlayer2.Size = new System.Drawing.Size(117, 159);
            this.picBoxPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPlayer2.TabIndex = 4;
            this.picBoxPlayer2.TabStop = false;
            // 
            // picBoxPlayer1
            // 
            this.picBoxPlayer1.Location = new System.Drawing.Point(276, 277);
            this.picBoxPlayer1.Name = "picBoxPlayer1";
            this.picBoxPlayer1.Size = new System.Drawing.Size(117, 159);
            this.picBoxPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPlayer1.TabIndex = 3;
            this.picBoxPlayer1.TabStop = false;
            // 
            // picBoxDealer2
            // 
            this.picBoxDealer2.Location = new System.Drawing.Point(399, 72);
            this.picBoxDealer2.Name = "picBoxDealer2";
            this.picBoxDealer2.Size = new System.Drawing.Size(117, 159);
            this.picBoxDealer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDealer2.TabIndex = 2;
            this.picBoxDealer2.TabStop = false;
            // 
            // picBoxDealer1
            // 
            this.picBoxDealer1.Location = new System.Drawing.Point(276, 72);
            this.picBoxDealer1.Name = "picBoxDealer1";
            this.picBoxDealer1.Size = new System.Drawing.Size(117, 159);
            this.picBoxDealer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDealer1.TabIndex = 0;
            this.picBoxDealer1.TabStop = false;
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerName.Location = new System.Drawing.Point(378, 45);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(44, 13);
            this.lblDealerName.TabIndex = 11;
            this.lblDealerName.Text = "Dealer";
            // 
            // txtBoxMoney
            // 
            this.txtBoxMoney.Location = new System.Drawing.Point(469, 481);
            this.txtBoxMoney.Name = "txtBoxMoney";
            this.txtBoxMoney.ReadOnly = true;
            this.txtBoxMoney.Size = new System.Drawing.Size(75, 20);
            this.txtBoxMoney.TabIndex = 12;
            this.txtBoxMoney.TabStop = false;
            this.txtBoxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBoxPlayer4
            // 
            this.picBoxPlayer4.Location = new System.Drawing.Point(522, 277);
            this.picBoxPlayer4.Name = "picBoxPlayer4";
            this.picBoxPlayer4.Size = new System.Drawing.Size(117, 159);
            this.picBoxPlayer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPlayer4.TabIndex = 13;
            this.picBoxPlayer4.TabStop = false;
            // 
            // picBoxPlayer3
            // 
            this.picBoxPlayer3.Location = new System.Drawing.Point(153, 277);
            this.picBoxPlayer3.Name = "picBoxPlayer3";
            this.picBoxPlayer3.Size = new System.Drawing.Size(117, 159);
            this.picBoxPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPlayer3.TabIndex = 14;
            this.picBoxPlayer3.TabStop = false;
            // 
            // picBoxPlayer6
            // 
            this.picBoxPlayer6.Location = new System.Drawing.Point(645, 277);
            this.picBoxPlayer6.Name = "picBoxPlayer6";
            this.picBoxPlayer6.Size = new System.Drawing.Size(117, 159);
            this.picBoxPlayer6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPlayer6.TabIndex = 15;
            this.picBoxPlayer6.TabStop = false;
            // 
            // picBoxPlayer5
            // 
            this.picBoxPlayer5.Location = new System.Drawing.Point(30, 277);
            this.picBoxPlayer5.Name = "picBoxPlayer5";
            this.picBoxPlayer5.Size = new System.Drawing.Size(117, 159);
            this.picBoxPlayer5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPlayer5.TabIndex = 16;
            this.picBoxPlayer5.TabStop = false;
            // 
            // picBoxDealer4
            // 
            this.picBoxDealer4.Location = new System.Drawing.Point(522, 72);
            this.picBoxDealer4.Name = "picBoxDealer4";
            this.picBoxDealer4.Size = new System.Drawing.Size(117, 159);
            this.picBoxDealer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDealer4.TabIndex = 17;
            this.picBoxDealer4.TabStop = false;
            // 
            // picBoxDealer6
            // 
            this.picBoxDealer6.Location = new System.Drawing.Point(645, 72);
            this.picBoxDealer6.Name = "picBoxDealer6";
            this.picBoxDealer6.Size = new System.Drawing.Size(117, 159);
            this.picBoxDealer6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDealer6.TabIndex = 18;
            this.picBoxDealer6.TabStop = false;
            // 
            // picBoxDealer3
            // 
            this.picBoxDealer3.Location = new System.Drawing.Point(153, 72);
            this.picBoxDealer3.Name = "picBoxDealer3";
            this.picBoxDealer3.Size = new System.Drawing.Size(117, 159);
            this.picBoxDealer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDealer3.TabIndex = 19;
            this.picBoxDealer3.TabStop = false;
            // 
            // picBoxDealer5
            // 
            this.picBoxDealer5.Location = new System.Drawing.Point(30, 72);
            this.picBoxDealer5.Name = "picBoxDealer5";
            this.picBoxDealer5.Size = new System.Drawing.Size(117, 159);
            this.picBoxDealer5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDealer5.TabIndex = 20;
            this.picBoxDealer5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Money";
            // 
            // txtBoxHand
            // 
            this.txtBoxHand.Location = new System.Drawing.Point(356, 481);
            this.txtBoxHand.Name = "txtBoxHand";
            this.txtBoxHand.ReadOnly = true;
            this.txtBoxHand.Size = new System.Drawing.Size(75, 20);
            this.txtBoxHand.TabIndex = 22;
            this.txtBoxHand.TabStop = false;
            this.txtBoxHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Hand";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxHand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBoxDealer5);
            this.Controls.Add(this.picBoxDealer3);
            this.Controls.Add(this.picBoxDealer6);
            this.Controls.Add(this.picBoxDealer4);
            this.Controls.Add(this.picBoxPlayer5);
            this.Controls.Add(this.picBoxPlayer6);
            this.Controls.Add(this.picBoxPlayer3);
            this.Controls.Add(this.picBoxPlayer4);
            this.Controls.Add(this.txtBoxMoney);
            this.Controls.Add(this.lblDealerName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxBet);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.picBoxPlayer2);
            this.Controls.Add(this.picBoxPlayer1);
            this.Controls.Add(this.picBoxDealer2);
            this.Controls.Add(this.picBoxDealer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Black Jack";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDealer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDealer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDealer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDealer6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDealer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDealer5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.TextBox txtBoxBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBoxPlayer2;
        private System.Windows.Forms.PictureBox picBoxPlayer1;
        private System.Windows.Forms.PictureBox picBoxDealer2;
        private System.Windows.Forms.PictureBox picBoxDealer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.TextBox txtBoxMoney;
        private System.Windows.Forms.PictureBox picBoxPlayer4;
        private System.Windows.Forms.PictureBox picBoxPlayer3;
        private System.Windows.Forms.PictureBox picBoxPlayer6;
        private System.Windows.Forms.PictureBox picBoxPlayer5;
        private System.Windows.Forms.PictureBox picBoxDealer4;
        private System.Windows.Forms.PictureBox picBoxDealer6;
        private System.Windows.Forms.PictureBox picBoxDealer3;
        private System.Windows.Forms.PictureBox picBoxDealer5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxHand;
        private System.Windows.Forms.Label label3;
    }
}

