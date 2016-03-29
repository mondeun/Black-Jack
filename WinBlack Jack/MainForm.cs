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
        private readonly CardGraphicsMapper _cardMapper;

        private int _currentPlayerPos;

        public MainForm(Blackjack blackjack)
        {
            InitializeComponent();
            _blackjack = blackjack;
            _cardMapper = new CardGraphicsMapper(_blackjack.GetCardStrings());
            _currentPlayerPos = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewRound();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _blackjack.NewRound();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NewRound()
        {
            _blackjack.NewRound();
            _blackjack.InitialDeal();

            _currentPlayerPos = 0;

            lblPlayerName.Text = _blackjack.Players[_currentPlayerPos].Name;

            UpdateDealerCardPictures();
            NextPlayerTurn(_blackjack.Players[_currentPlayerPos]);
        }

        private void NextPlayerTurn(IPlayer player)
        {
            UpdatePlayerCardPictures(player);
            txtBoxHand.Text = BlackJackRules.GethandValue(player.Hand).ToString();
            txtBoxMoney.Text = player.Balance.ToString();
        }

        private void UpdatePlayerCardPictures(IPlayer player)
        {
            picBoxPlayer1.Image = _cardMapper.GetCardBitmap(player.Hand.Cards[0].ToString());
            picBoxPlayer2.Image = _cardMapper.GetCardBitmap(player.Hand.Cards[1].ToString());

            var nrOfCards = player.Hand.Cards.Count;

            if (nrOfCards >= 3)
                picBoxPlayer3.Image = _cardMapper.GetCardBitmap(player.Hand.Cards[2].ToString());
            if (nrOfCards >= 4)
                picBoxPlayer4.Image = _cardMapper.GetCardBitmap(player.Hand.Cards[3].ToString());
            if (nrOfCards >= 5)
                picBoxPlayer5.Image = _cardMapper.GetCardBitmap(player.Hand.Cards[4].ToString());
            if (nrOfCards >= 6)
                picBoxPlayer6.Image = _cardMapper.GetCardBitmap(player.Hand.Cards[5].ToString());
        }

        private void UpdateDealerCardPictures()
        {
            picBoxDealer1.Image = _cardMapper.GetCardBitmap(_blackjack.Dealer.Hand.Cards[0].ToString());
            picBoxDealer2.Image = _cardMapper.GetCardBitmap(_blackjack.Dealer.Hand.Cards[1].ToString());

            var nrOfCards = _blackjack.Dealer.Hand.Cards.Count;

            if(nrOfCards >= 3)
                picBoxDealer3.Image = _cardMapper.GetCardBitmap(_blackjack.Dealer.Hand.Cards[2].ToString());
            if (nrOfCards >= 4)
                picBoxDealer4.Image = _cardMapper.GetCardBitmap(_blackjack.Dealer.Hand.Cards[3].ToString());
            if (nrOfCards >= 5)
                picBoxDealer5.Image = _cardMapper.GetCardBitmap(_blackjack.Dealer.Hand.Cards[4].ToString());
            if (nrOfCards >= 6)
                picBoxDealer6.Image = _cardMapper.GetCardBitmap(_blackjack.Dealer.Hand.Cards[5].ToString());
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            var player = GetPlayer(_currentPlayerPos);

            _blackjack.PlaceBet(player, player.MakeBet(int.Parse(txtBoxBet.Text)));

            txtBoxMoney.Text = player.Balance.ToString();
            txtBoxBet.ReadOnly = true;
            btnStay.Enabled = true;
            btnHit.Enabled = true;
            btnBet.Enabled = false;
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            NextPlayer();
            NextPlayerTurn(GetPlayer(_currentPlayerPos));
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            _blackjack.GiveCardTo(GetPlayer(_currentPlayerPos));
            UpdatePlayerCardPictures(GetPlayer(_currentPlayerPos));
            txtBoxHand.Text = BlackJackRules.GethandValue(GetPlayer(_currentPlayerPos).Hand).ToString();
        }

        private IPlayer GetPlayer(int index)
        {
            return _blackjack.Players[_currentPlayerPos];
        }

        private void NextPlayer()
        {
            _currentPlayerPos = (_currentPlayerPos + 1) % _blackjack.Players.Count;
        }
    }
}
