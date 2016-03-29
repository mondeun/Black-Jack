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
            NewRound();
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

            lblPlayerName.Text = GetPlayer(_currentPlayerPos).Name;

            UpdateDealerCardPictures();
            NextPlayerTurn(GetPlayer(_currentPlayerPos));
        }

        private void NextPlayerTurn(IPlayer player)
        {
            UpdatePlayerCardPictures(player);
            txtBoxHand.Text = BlackJackRules.GethandValue(player.Hand).ToString();
            lblPlayerName.Text = player.Name;
            txtBoxMoney.Text = player.Balance.ToString();
        }

        private void UpdatePlayerCardPictures(IPlayer player)
        {
            var nrOfCards = player.Hand.Cards.Count;

            picBoxPlayer1.Image = nrOfCards >= 1 ? _cardMapper.GetCardBitmap(player.Hand.Cards[0].ToString()) : null;
            picBoxPlayer2.Image = nrOfCards >= 2 ? _cardMapper.GetCardBitmap(player.Hand.Cards[1].ToString()) : null;
            picBoxPlayer3.Image = nrOfCards >= 3 ? _cardMapper.GetCardBitmap(player.Hand.Cards[2].ToString()) : null;
            picBoxPlayer4.Image = nrOfCards >= 4 ? _cardMapper.GetCardBitmap(player.Hand.Cards[3].ToString()) : null;
            picBoxPlayer5.Image = nrOfCards >= 5 ? _cardMapper.GetCardBitmap(player.Hand.Cards[4].ToString()) : null;
            picBoxPlayer6.Image = nrOfCards >= 6 ? _cardMapper.GetCardBitmap(player.Hand.Cards[5].ToString()) : null;
        }

        private void UpdateDealerCardPictures()
        {
            var nrOfCards = _blackjack.Dealer.Hand.Cards.Count;

            picBoxDealer1.Image = nrOfCards >= 1 ? _cardMapper.GetCardBitmap(_blackjack.Dealer.Hand.Cards[0].ToString()) : null;
            picBoxDealer2.Image = nrOfCards >= 2 ? _cardMapper.GetCardBitmap(_blackjack.Dealer.Hand.Cards[1].ToString()) : null;
            picBoxDealer3.Image = nrOfCards >= 3 ? _cardMapper.GetCardBitmap(_blackjack.Dealer.Hand.Cards[2].ToString()) : null;
            picBoxDealer4.Image = nrOfCards >= 4 ? _cardMapper.GetCardBitmap(_blackjack.Dealer.Hand.Cards[3].ToString()) : null;
            picBoxDealer5.Image = nrOfCards >= 5 ? _cardMapper.GetCardBitmap(_blackjack.Dealer.Hand.Cards[4].ToString()) : null;
            picBoxDealer6.Image = nrOfCards >= 6 ? _cardMapper.GetCardBitmap(_blackjack.Dealer.Hand.Cards[5].ToString()) : null;
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
