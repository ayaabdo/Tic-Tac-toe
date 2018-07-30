using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeTeam
{
    public partial class Form2 : Form
    {
        public Form2(string winner, string playerOne, string playerTwo, string numRounds,string scoreX, string scoreO)
        {
            InitializeComponent();
            winnerLabel.Text = winner + " wins!!!";
            playerOneLabel.Text = playerOne;
            playerTwoLabel.Text = playerTwo;
            scoreXLabel.Text = scoreX + " / " + numRounds;
            scoreOLabel.Text = scoreO + " / " + numRounds;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
