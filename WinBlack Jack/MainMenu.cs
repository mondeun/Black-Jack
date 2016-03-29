using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack;
using BlackJack.Players;

namespace WinBlack_Jack
{
    public partial class MainMenu : Form
    {
        private Blackjack _blackjack;

        public MainMenu()
        {
            InitializeComponent();

            _blackjack = new Blackjack();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (_blackjack.Players.Count == 0)
            {
                MessageBox.Show("Please add player(s)");
                return;
            }

            var main = new MainForm(_blackjack);
            main.Show();
            Hide();
        }

        private void txtBoxMoney_Enter(object sender, EventArgs e)
        {
            if(txtBoxMoney.Text == "Money")
                txtBoxMoney.Text = string.Empty;
        }

        private void txtBoxMoney_Leave(object sender, EventArgs e)
        {
            if (txtBoxMoney.Text.Length == 0)
                txtBoxMoney.Text = "Money";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var money = 0;

            if (txtBoxName.Text == "Name")
            {
                MessageBox.Show("Enter a name please");
                return;
            }

            if (!int.TryParse(txtBoxMoney.Text, out money))
            {
                MessageBox.Show("Please enter starting money");
                return;
            }

            IPlayer player;

            switch (comboBoxAddPlayer.Text)
            {
                case "Human":
                    player = new HumanPlayer(txtBoxName.Text, money);
                    break;
                case "Computer":
                    player = new ComputerPlayer(txtBoxName.Text, money);
                    break;
                default:
                    MessageBox.Show("Select player");
                    return;
            }

            _blackjack.AddPlayer(player);
            listBoxAddedPlayers.Items.Add(txtBoxName.Text + " : " + comboBoxAddPlayer.Text);
            txtBoxName.Text = "Name";
            txtBoxMoney.Text = "Money";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var index = listBoxAddedPlayers.SelectedIndex;

            _blackjack.RemovePlayer(_blackjack.Players[index]);
            listBoxAddedPlayers.Items.RemoveAt(index);
        }

        private void txtBoxName_Enter(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "Name")
                txtBoxName.Text = string.Empty;
        }

        private void txtBoxName_Leave(object sender, EventArgs e)
        {
            if (txtBoxName.Text.Length == 0)
                txtBoxName.Text = "Name";
        }
    }
}
