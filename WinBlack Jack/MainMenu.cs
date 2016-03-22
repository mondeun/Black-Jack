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
        private readonly List<IPlayer> _playerList;
        private readonly Bank _bank;

        public MainMenu()
        {
            InitializeComponent();
            _playerList = new List<IPlayer>();
            _bank = new Bank();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            var main = new MainForm(_playerList, _bank);
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

            if (!int.TryParse(txtBoxMoney.Text, out money))
            {
                MessageBox.Show("Please enter starting money");
                return;
            }

            IPlayer player;

            switch (comboBoxAddPlayer.Text)
            {
                case "Human":
                    player = new Dealer(); // TODO Implement human player
                    break;
                case "Computer":
                    player = new ComputerPlayer();
                    break;
                default:
                    MessageBox.Show("Select player");
                    return;
            }

            _playerList.Add(player);
            _bank.AddMoneyToPlayer(player.Id, money);
            listBoxAddedPlayers.Items.Add(comboBoxAddPlayer.Text);
            txtBoxMoney.Text = "Money";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var index = listBoxAddedPlayers.SelectedIndex;

            _bank.RemovePlayer(_playerList[index].Id);
            _playerList.RemoveAt(index);
            listBoxAddedPlayers.Items.RemoveAt(index);
        }
    }
}
