using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack.Players;

namespace WinBlack_Jack
{
    public partial class MainMenu : Form
    {
        private List<IPlayer> _playerList;

        public MainMenu()
        {
            InitializeComponent();
            _playerList = new List<IPlayer>();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            var main = new MainForm();
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
            switch (comboBoxAddPlayer.Text)
            {
                case "Human":
                    _playerList.Add(new Dealer()); // TODO Implement human player
                    break;
                case "Computer":
                    _playerList.Add(new ComputerPlayer());
                    break;
                default:
                    break;
            }
            listBoxAddedPlayers.Items.Add(comboBoxAddPlayer.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _playerList.RemoveAt(listBoxAddedPlayers.SelectedIndex);
            listBoxAddedPlayers.Items.RemoveAt(listBoxAddedPlayers.SelectedIndex);
        }
    }
}
