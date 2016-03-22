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

namespace WinBlack_Jack
{
    public partial class MainForm : Form
    {
        Blackjack _blackjack;

        public MainForm()
        {
            InitializeComponent();
            _blackjack = new Blackjack(100);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _blackjack.NewGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
