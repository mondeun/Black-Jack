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
        private List<IPlayer> _playersToAdd;
        private readonly CardGraphicsMapper _cardMapper;

        private int _currentPlayerPos;

        public MainForm(Blackjack blackjack)
        {
            InitializeComponent();
            _blackjack = blackjack;
            _playersToAdd = new List<IPlayer>();
            _cardMapper = new CardGraphicsMapper(_blackjack.GetCardStrings());
            _currentPlayerPos = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewGame();
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

        private void NewGame()
        {
            _blackjack.NewGame();
            _blackjack.InitialDeal();

            _currentPlayerPos = 0;

            lblPlayerName.Text = _blackjack.Players[_currentPlayerPos].Name;

            UpdateDealerCardPictures();
            NextPlayerTurn(_blackjack.Players[_currentPlayerPos]);
        }

        private void NewRound()
        {
            _blackjack.NewRound();
        }

        private void NextPlayerTurn(IPlayer player)
        {
            UpdatePlayerCardPictures(player);
            txtBoxHand.Text = BlackJackRules.GethandValue(player.Hand).ToString();
            txtBoxMoney.Text = Bank.GetPlayerMoney(player.Id).ToString();
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

        }

        private void btnStay_Click(object sender, EventArgs e)
        {

        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            _blackjack.GiveCardTo(_blackjack.Players[_currentPlayerPos]);
            UpdatePlayerCardPictures(_blackjack.Players[_currentPlayerPos]);
            txtBoxHand.Text = BlackJackRules.GethandValue(_blackjack.Players[_currentPlayerPos].Hand).ToString();
        }
    }
}
