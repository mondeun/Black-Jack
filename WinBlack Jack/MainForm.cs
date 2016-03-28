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
    public partial class MainForm : Form
    {
        private Blackjack _blackjack;
        private List<IPlayer> _playersToAdd; // Add new players at the end of round
        private CardGraphicsMapper _cardMapper;

        public MainForm(List<IPlayer> playerList, Bank bank)
        {
            InitializeComponent();
            _blackjack = new Blackjack(playerList, bank);
            _playersToAdd = new List<IPlayer>();
            _cardMapper = new CardGraphicsMapper();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            picBoxDealer1.Image = _cardMapper.GetBitmap("7♥");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _blackjack.NewGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
