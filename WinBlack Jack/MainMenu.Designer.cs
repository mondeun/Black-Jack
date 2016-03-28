namespace WinBlack_Jack
{
    partial class MainMenu
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxAddPlayer = new System.Windows.Forms.ComboBox();
            this.listBoxAddedPlayers = new System.Windows.Forms.ListBox();
            this.txtBoxMoney = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxAddPlayer
            // 
            this.comboBoxAddPlayer.FormattingEnabled = true;
            this.comboBoxAddPlayer.Items.AddRange(new object[] {
            "Human",
            "Computer"});
            this.comboBoxAddPlayer.Location = new System.Drawing.Point(28, 12);
            this.comboBoxAddPlayer.Name = "comboBoxAddPlayer";
            this.comboBoxAddPlayer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAddPlayer.TabIndex = 1;
            this.comboBoxAddPlayer.Text = "Add Player";
            // 
            // listBoxAddedPlayers
            // 
            this.listBoxAddedPlayers.FormattingEnabled = true;
            this.listBoxAddedPlayers.Location = new System.Drawing.Point(28, 120);
            this.listBoxAddedPlayers.Name = "listBoxAddedPlayers";
            this.listBoxAddedPlayers.Size = new System.Drawing.Size(120, 95);
            this.listBoxAddedPlayers.TabIndex = 6;
            // 
            // txtBoxMoney
            // 
            this.txtBoxMoney.Location = new System.Drawing.Point(39, 65);
            this.txtBoxMoney.Name = "txtBoxMoney";
            this.txtBoxMoney.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMoney.TabIndex = 3;
            this.txtBoxMoney.Text = "Money";
            this.txtBoxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxMoney.Enter += new System.EventHandler(this.txtBoxMoney_Enter);
            this.txtBoxMoney.Leave += new System.EventHandler(this.txtBoxMoney_Leave);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(93, 91);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(52, 221);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 5;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(39, 39);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 2;
            this.txtBoxName.Text = "Name";
            this.txtBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxName.Enter += new System.EventHandler(this.txtBoxName_Enter);
            this.txtBoxName.Leave += new System.EventHandler(this.txtBoxName_Leave);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(181, 254);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtBoxMoney);
            this.Controls.Add(this.listBoxAddedPlayers);
            this.Controls.Add(this.comboBoxAddPlayer);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Jack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBoxAddPlayer;
        private System.Windows.Forms.ListBox listBoxAddedPlayers;
        private System.Windows.Forms.TextBox txtBoxMoney;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TextBox txtBoxName;
    }
}