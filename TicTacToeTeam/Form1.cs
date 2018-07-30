using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TicTacToeTeam
{

    public partial class Form1 : Form
    {
        //Initializing variables
        private SoundPlayer sound = new SoundPlayer("winner.wav");
        bool onePlayer = false;
        public bool easy = false;
        public bool intermediate = false;
        bool thereIsWinner = false;
        bool a2 = false, b1 = false , c3 = false, b3 = false;
        int counterX = 0;
        int counterO = 0;
        int counterTurn = 0;
        int scoreX = 0;
        int scoreO = 0;
        int rounds = 2;
        public Form1()
        {
            InitializeComponent();
        }

    //Limiting inputs
    //Maximum size is 10 characters
        private void Form1_Load(object sender, EventArgs e)
        {
            playerOneTextBox.MaxLength = 10;
            playerTwoTextBox.MaxLength = 10;
        }
    //No spaces
        private void playerOneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }
    //No spaces
        private void playerTwoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }
     //Sound
        private void soundPanel_MouseClick(object sender, MouseEventArgs e)
        {
            soundOffPanel.Visible = true;
        }

        private void soundOffPanel_Click(object sender, EventArgs e)
        {
            soundOffPanel.Visible = false;
        }

        private void soundPanel_MouseHover(object sender, EventArgs e)
        {
            soundLabel.Text = "Sound On";
            soundLabel.Visible = true;
        }

        private void soundPanel_MouseLeave(object sender, EventArgs e)
        {
            soundLabel.Visible = false;
        }

        private void soundOffPanel_MouseHover(object sender, EventArgs e)
        {
            soundLabel.Text = "Sound Off";
            soundLabel.Visible = true;
        }

        private void soundOffPanel_MouseLeave(object sender, EventArgs e)
        {
            soundLabel.Visible = false;
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soundLabel.Text = "Sound On";
            soundOffPanel.Visible = false;
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soundLabel.Text = "Sound Off";
            soundOffPanel.Visible = true;
        }

    //Exiting the app
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    //Activates One Player Mode
        private void onePlayerButton_Click(object sender, EventArgs e)
        {
            firstPlayerLabel.Text = "Player's name";
            MainPanel.Visible = false;
            computerPanel.Visible = true;
            onePlayer = true;
        }
    //Acitvates Two Players Mode
        private void twoPlayersButton_Click(object sender, EventArgs e)
        {
            onePlayer = false;
            MainPanel.Visible = false;
            computerPanel.Visible = false;
            firstPlayerLabel.Text = "First Player";
        }

    //Leads to X/O panel & setting everything to default.
        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;

            playerOneTextBox.Text = "";
            playerTwoTextBox.Text = "";

            oPlayerOneRadioButton.Checked = false;
            xPlayerOneRadioButton.Checked = false;
            xPlayerTwoRadioButton.Checked = false;
            oPlayerTwoRadioButton.Checked = false;

            playerOneOrange.Text = "";
            playerOneGray.Text = "";
            playerOneHotPink.Text = "";
            playerOneLightGreen.Text = "";

            playerTwoOrange.Text = "";
            playerTwoGray.Text = "";
            playerTwoHotPink.Text = "";
            playerTwoLightGreen.Text = "";

            intermediate = false;
            easy = false;

            intermediateModeButton.BackColor = Color.FromArgb(64, 64, 64);
            easyModeButton.BackColor = Color.FromArgb(64, 64, 64);

            roundComboBox.Text = "3";
        }

        private void backToNamePanel_Click(object sender, EventArgs e)
        {
            namePanel.Visible = true;
            if (onePlayer == true)
                computerPanel.Visible = true;
            
            scoreX = 0;
            scoreO = 0;
            scorePlayerOne.Text = "0";
            scorePlayerTwo.Text = "0";
            redo();
        }
//Change fi el-color  3ala 7sb el-arqam el-red green blue
        private void easyModeButton_Click(object sender, EventArgs e)
        {
            easy = true;
            intermediate = false;
            intermediateModeButton.BackColor = Color.FromArgb(64,64,64); //rgb stands for red, green, blue.
            easyModeButton.BackColor = Color.LightPink;
        }

        private void intermediateMode_Click(object sender, EventArgs e)
        {
            intermediate = true;
            easy = false;
            easyModeButton.BackColor = Color.FromArgb(64, 64, 64);
            intermediateModeButton.BackColor = Color.LightPink;
        }

//Choosing Colors

    //Player One Choosing Color
        private void playerOneGray_Click(object sender, EventArgs e)
        {
            playerOneGray.Text = "✓";
            playerOneHotPink.Text = "";
            playerOneLightGreen.Text = "";
            playerOneOrange.Text = "";
        }

        private void playerOneOrange_Click(object sender, EventArgs e)
        {
            playerOneGray.Text = "";
            playerOneHotPink.Text = "";
            playerOneLightGreen.Text = "";
            playerOneOrange.Text = "✓";
        }

        private void playerOneHotPink_Click(object sender, EventArgs e)
        {
            playerOneGray.Text = "";
            playerOneHotPink.Text = "✓";
            playerOneLightGreen.Text = "";
            playerOneOrange.Text = "";
        }
        private void playerOneLightGreen_Click(object sender, EventArgs e)
        {
            playerOneGray.Text = "";
            playerOneHotPink.Text = "";
            playerOneLightGreen.Text = "✓";
            playerOneOrange.Text = "";
        }
    //Player Two Choosing Color
        private void playerTwoLightGreen_Click(object sender, EventArgs e)
        {
            playerTwoGray.Text = "";
            playerTwoHotPink.Text = "";
            playerTwoLightGreen.Text = "✓";
            playerTwoOrange.Text = "";
        }
        private void playerTwoGray_Click(object sender, EventArgs e)
        {
            playerTwoGray.Text = "✓";
            playerTwoHotPink.Text = "";
            playerTwoLightGreen.Text = "";
            playerTwoOrange.Text = "";
        }

        private void playerTwoOrange_Click(object sender, EventArgs e)
        {
            playerTwoGray.Text = "";
            playerTwoHotPink.Text = "";
            playerTwoLightGreen.Text = "";
            playerTwoOrange.Text = "✓";
        }

        private void playerTwoHotPink_Click(object sender, EventArgs e)
        {
            playerTwoGray.Text = "";
            playerTwoHotPink.Text = "✓";
            playerTwoLightGreen.Text = "";
            playerTwoOrange.Text = "";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (onePlayer) //One Player Mode
            {
                //Errors for 1 player
                if (playerOneTextBox.Text == "")
                {
                    MessageBox.Show("Please check your input!", "Sorry");
                }
                else if (oPlayerOneRadioButton.Checked == false && xPlayerOneRadioButton.Checked == false)
                {
                    MessageBox.Show("Player one must choose between 'X' and 'O' to play with.", "Sorry");
                }
                //Continue
                else
                {
                    //For round labels
                    roundLabel1.Text = roundComboBox.Text;
                    roundLabel2.Text = roundComboBox.Text;


                    //User is O - Computer is X
                    if (oPlayerOneRadioButton.Checked)
                    {
                        oLabelGame.ForeColor = playerOne_chooseColor();
                        xLabelGame.ForeColor = playerTwo_chooseColor();

                        firstPlayerName.Text  = " Aliens";
                        secondPlayerName.Text = playerOneTextBox.Text;
                    }
                    //User is X - Computer is O
                    else if (xPlayerOneRadioButton.Checked)
                    {
                        oLabelGame.ForeColor = playerTwo_chooseColor();
                        xLabelGame.ForeColor = playerOne_chooseColor();

                        firstPlayerName.Text  = playerOneTextBox.Text;
                        secondPlayerName.Text = " Aliens";
                    }
                    //firstPlayerName which is X's Name always plays first
                    whoseTurn.Text = firstPlayerName.Text + "'s turn";
                    
                    namePanel.Visible = false;
                    computerPanel.Visible = false;
                    //el 7ta di me7taga ttktb b tre2ti...
                    if (oPlayerOneRadioButton.Checked == true)
                    {

                        if (counterTurn == 0) {la1.ForeColor = playerTwo_chooseColor(); la1.Text = "X"; rounds += 2; }
                        else if (counterTurn == 1)
                        {
                            System.Threading.Thread.Sleep(1000); la3.Text = "X";
                        }
                        else if (counterTurn == 3)
                        {
                            System.Threading.Thread.Sleep(1000); lc3.Text = "X";
                        }
                        else if (counterTurn == 2)
                        {
                            System.Threading.Thread.Sleep(1000); lc1.Text = "X";
                        }
                        counterX++;
                        counterTurn++;     
                    }
                }
            }
            //Two Players Mode
            else
            {
                //Errors for 2 players
                if (playerOneTextBox.Text == "" | playerTwoTextBox.Text == "")
                {
                    MessageBox.Show("Please check your input!", "Sorry");
                }
                else if (oPlayerOneRadioButton.Checked == false && xPlayerOneRadioButton.Checked == false)
                {
                    MessageBox.Show("Player one must choose between 'X' and 'O' to play with.", "Sorry");
                }
                else if (oPlayerTwoRadioButton.Checked == false && xPlayerTwoRadioButton.Checked == false)
                {
                    MessageBox.Show("Player two must choose between 'X' and 'O' to play with.", "Sorry");
                }
                else if (oPlayerTwoRadioButton.Checked == true && oPlayerOneRadioButton.Checked == true)
                {
                    MessageBox.Show("Two players are playing with 'O'", "Sorry");
                }
                else if (xPlayerTwoRadioButton.Checked == true && xPlayerOneRadioButton.Checked == true)
                {
                    MessageBox.Show("Two players are playing with 'X'", "Sorry");
                }
                //Continue
                else
                {
                    //For round labels
                    roundLabel1.Text = roundComboBox.Text;
                    roundLabel2.Text = roundComboBox.Text;

                    //Player one is O - Player two is X
                    if (oPlayerOneRadioButton.Checked)
                    {
                        oLabelGame.ForeColor = playerOne_chooseColor();
                        xLabelGame.ForeColor = playerTwo_chooseColor();

                        firstPlayerName.Text  = playerTwoTextBox.Text;
                        secondPlayerName.Text = playerOneTextBox.Text;
                    }

                    //Player one is X - Player two is O
                    else if (xPlayerOneRadioButton.Checked)
                    {
                        oLabelGame.ForeColor = playerTwo_chooseColor();
                        xLabelGame.ForeColor = playerOne_chooseColor();

                        firstPlayerName.Text  = playerOneTextBox.Text;
                        secondPlayerName.Text = playerTwoTextBox.Text;
                    }
                    //firstPlayerName which is X's Name always plays first
                    whoseTurn.Text = firstPlayerName.Text + "'s turn";

                    namePanel.Visible = false;
                    computerPanel.Visible = false;
                }
            }
        }
        //End of preparing
//________________________________________________________________________________________________________
        //Start of Playing
        private void panel_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            foreach (Control l in p.Controls)
            {
                if (onePlayer && xPlayerOneRadioButton.Checked == true)
                {
                    l.ForeColor = playerOne_chooseColor();
                    l.Text = "X";

                    counterX++;
                    counterTurn++;
                    check_winner();
                    if (!thereIsWinner)
                    {
                        if (intermediate)
                        {
                            moveO();
                            counterO++;
                            counterTurn++;
                            check_winner();
                        }    
                        else
                        {
                            EasyMoveO();
                            counterO++;
                            counterTurn++;
                            check_winner();
                        }    
                    }                    
                }
                else if (onePlayer && oPlayerOneRadioButton.Checked == true)
                {
                    l.ForeColor = playerOne_chooseColor();
                    l.Text = "O";
                    counterO++;
                    counterTurn++;
                    check_winner();
                    if (!thereIsWinner)
                    {
                        if (intermediate)
                        {
                            moveX1();
                            counterX++;
                            counterTurn++;
                            check_winner();
                        }

                        else
                        {
                            EasyMoveX();
                            counterX++;
                            counterTurn++;
                            check_winner();
                        }
                    }

                }
                if (!onePlayer)
                {
                    if (counterX == counterO && l.Text == "")
                    {
                        //Player one is O - Player two is X
                        //Setting playerTwo color to X
                        if (oPlayerOneRadioButton.Checked)
                        {
                            l.ForeColor = playerTwo_chooseColor();
                        }

                        //Player one is X - Player two is O
                        //Setting playerOne color to X
                        else if (xPlayerOneRadioButton.Checked)
                        {
                            l.ForeColor = playerOne_chooseColor();
                        }
                        l.Text = "X";

                        counterX++;
                        counterTurn++;
                        check_winner();
                    }
                    else if (counterX > counterO && l.Text == "")
                    {
                        //Player one is O - Player two is X
                        //Setting playerOne color to O
                        if (oPlayerOneRadioButton.Checked)
                        {
                            l.ForeColor = playerOne_chooseColor();
                        }

                        //Player one is X - Player two is O
                        //Setting playerTwo color to O
                        else if (xPlayerOneRadioButton.Checked)
                        {
                            l.ForeColor = playerTwo_chooseColor();
                        }
                        //End of change
                        l.Text = "O";
                        counterO++;
                        counterTurn++;
                        check_winner();
                    }
                }


                if (!thereIsWinner)
                {
                    if (counterX == counterO)
                    {
                        whoseTurn.Text = firstPlayerName.Text + "'s turn";
                    }
                    else if (counterX > counterO)
                    {
                        whoseTurn.Text = secondPlayerName.Text + "'s turn";
                    }
                }

            }
        }
        private void RedoButton_Click(object sender, EventArgs e)
        {
            //When a round is completed "New Game" must be selected from the toolstrip
            if(scorePlayerOne.Text!= roundLabel1.Text && scorePlayerTwo.Text != roundLabel1.Text)
                redo();
        }
        //Tool Strip Menu Items
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redo();
            scoreX = 0;
            scoreO = 0;
            scorePlayerOne.Text = "0";
            scorePlayerTwo.Text = "0";
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic-Tac-Toe is an old game that can be palyed between two players X/O .There is a winner in case someone get three following X or O whether horizontal,vertical or diagonal ", "Made by aliens ");
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



//__________________________________________________________________________________________________________
        //Created Functions
        private Color playerOne_chooseColor()
        {
            Color c;
            if (playerOneGray.Text =="✓")
                c = Color.Gray;
            else if (playerOneHotPink.Text == "✓")
                c = Color.HotPink;
            else if (playerOneOrange.Text == "✓")
                c = Color.Orange;
            else if (playerOneLightGreen.Text == "✓")
                c = Color.LightGreen;
            else
                c = Color.Red;
            return c;
        }
        private Color playerTwo_chooseColor()
        {
            Color c;
            if (playerTwoGray.Text == "✓")
                c = Color.Gray;
            else if (playerTwoHotPink.Text == "✓")
                c = Color.HotPink;
            else if (playerTwoOrange.Text == "✓")
                c = Color.Orange;
            else if (playerTwoLightGreen.Text == "✓")
                c = Color.LightGreen;
            else
                c = Color.Blue;
            return c;
        }

        private void check_winner()
        {
            //Horizontal Check
            //First Row a1,a2,a3
            if ((la1.Text == la2.Text) && (la2.Text == la3.Text))
            {
                if(la1.Text !="")
                {
                    thereIsWinner = true;
                    weHaveWinner();
                }
            }
            //Second Row b1,b2,b3
            if ((lb1.Text == lb2.Text) && (lb2.Text == lb3.Text))
            {
                if(lb1.Text !="")
                {
                    thereIsWinner = true;
                    weHaveWinner();
                }
            }
            //Third Row c1,c2,c3
            if ((lc1.Text == lc2.Text) && (lc2.Text == lc3.Text))
            {
                if(lc1.Text !="")
                {
                    thereIsWinner = true;
                    weHaveWinner();
                }
            }

            //Vertical Check
            //First Column a1,b1,c1
            if ((la1.Text == lb1.Text) && (lb1.Text == lc1.Text))
            {
                if(la1.Text != "")
                {
                    thereIsWinner = true;
                    weHaveWinner();
                }
            }
            //Second Column a2,b2,c2
            if ((la2.Text == lb2.Text) && (lb2.Text == lc2.Text))
            {
                if(la2.Text != "")
                {
                    thereIsWinner = true;
                    weHaveWinner();

                }
            }
            //Third Column a3,b3,c3
            if ((la3.Text == lb3.Text) && (lb3.Text == lc3.Text))
            {
                if(la3.Text != "")
                {
                    thereIsWinner = true;
                    weHaveWinner();
                }
            }

            //Diagnal Check
            //First Diagonal a1,b2,c3
            if ((la1.Text == lb2.Text) && (lb2.Text == lc3.Text))
            {
                if(la1.Text != "")
                {
                    thereIsWinner = true;
                    weHaveWinner();
                }
            }
            //Second Diagonal a3,b2,c1
            if ((la3.Text == lb2.Text) && (lb2.Text == lc1.Text))
            {
                if(la3.Text != "")
                {
                    thereIsWinner = true;
                    weHaveWinner();
                }
            }
            //In case of draw
            if (counterTurn == 9 && !thereIsWinner)
                MessageBox.Show("It's a draw");
        }
        private void weHaveWinner()
        {
            if (counterX > counterO)
            {
                //Incrementing X score
                scoreX++;
                scorePlayerOne.Text = scoreX.ToString();
            }
            else
            {
                //Incrementing O score
                scoreO++;
                scorePlayerTwo.Text = scoreO.ToString();
            }
            if (scorePlayerOne.Text == roundLabel1.Text)
            {
                if (soundLabel.Text == "Sound On")
                    sound.Play();
                Form2 f2 = new Form2(firstPlayerName.Text,firstPlayerName.Text, secondPlayerName.Text, roundLabel1.Text,scorePlayerOne.Text, scorePlayerTwo.Text);
                f2.ShowDialog();

            }
            else if(scorePlayerTwo.Text == roundLabel1.Text)
            {
                if (soundLabel.Text == "Sound On")
                    sound.Play();
                Form2 f2 = new Form2(secondPlayerName.Text, firstPlayerName.Text, secondPlayerName.Text, roundLabel1.Text, scorePlayerOne.Text, scorePlayerTwo.Text);
                f2.ShowDialog();

            }
            disable();
        }

        //Disable panels from being clicked in case of winning.
        private void disable()
        {
            foreach (Control p in Controls)
            {
                if (p is Panel)
                {
                    foreach(Control l in p.Controls)
                    {
                        if(l is Label && (l.Text == "" || l.Text == "X" || l.Text == "O"))
                        {
                            p.Enabled = false;
                        }

                    }
                   
                }
            }
        }
        private void redo()
        {
            foreach (Control p in Controls)
            {
                if (p is Panel)
                {
                    p.Enabled = true;
                    foreach(Control l in p.Controls)
                    {
                        if(l is Label && (l.Text == "X" || l.Text == "O"))
                        {
                            l.Text = "";
                        }

                    }
                   
                }
            }
            counterX = 0;
            counterO = 0;
            counterTurn = 0;
            thereIsWinner = false;
            a2 = false; b3 = false; b1 = false; c3 = false;

                //firstPlayerName = who plays with X
                //secondPlayerName = who plays with O
            //Player one is O - Player two is X - Computer is X
            if (oPlayerOneRadioButton.Checked)
            {
                oLabelGame.ForeColor = playerOne_chooseColor();
                xLabelGame.ForeColor = playerTwo_chooseColor();

                secondPlayerName.Text = playerOneTextBox.Text;

                if (onePlayer)
                {
                    firstPlayerName.Text = "Aliens";
                    rounds += 2;
                    if (rounds % 8 == 0) { lc3.Text = "X"; lc3.ForeColor = playerTwo_chooseColor();}
                    else if(rounds % 6 == 0) {lc1.Text = "X"; lc1.ForeColor = playerTwo_chooseColor();}
                    else if(rounds % 4 == 0) { la3.Text = "X"; la3.ForeColor = playerTwo_chooseColor();}
                    else if (rounds %2 == 0) {la1.Text = "X"; la1.ForeColor = playerTwo_chooseColor();}
                    counterX++;
                    counterTurn++;
                    whoseTurn.Text = secondPlayerName.Text + "'s turn";

                }
                else
                {
                    //firstPlayerName which is X's Name always plays first
                    whoseTurn.Text = firstPlayerName.Text + "'s turn";
                    firstPlayerName.Text = playerTwoTextBox.Text;

                }
            }

            //Player one is X - Player two is O - Computer is O
            else if (xPlayerOneRadioButton.Checked)
            {
                oLabelGame.ForeColor = playerTwo_chooseColor();
                xLabelGame.ForeColor = playerOne_chooseColor();

                firstPlayerName.Text = playerOneTextBox.Text;

                if (onePlayer)
                    secondPlayerName.Text = "Aliens";
                else
                    secondPlayerName.Text = playerTwoTextBox.Text;
                whoseTurn.Text = firstPlayerName.Text + "'s turn";

            }
        }

//___________________________________________________________________________________________________________________
     //Computer Functions
        //Computer is O intermediate
        private void moveO()
        {
            Label text = null;
            text = win_Block("O"); // look for 2 Os in sequence to win
            if (text == null)
            {
                text = win_Block("X"); // look for 2 Xs in sequence to block
                if (text == null)
                {
                    text = find_corner("X"); //Play at a corner oposite to X
                    if (text == null)
                    {
                        any_space("O"); //Any space
                    }
                }
            }
            foreach (Control p in Controls)
            {
                if (p is Panel && p.Enabled == true)
                {
                    foreach (Control l in p.Controls)
                    {
                        if (l == text)
                        {
                            l.ForeColor = playerTwo_chooseColor();
                            l.Text = "O";
                            whoseTurn.Text = firstPlayerName.Text + "'s turn";
                            break;
                        }
                    }
                }

            }
        }

        private void any_space(string m)
        {
            bool move = false;

            foreach (Control p in Controls)
            {
                if (p is Panel && !move)
                {
                    foreach (Control c in p.Controls)
                    {
                        if (c is Label)
                            if (c.Text == "")
                            {
                                c.Text = m;
                                c.ForeColor = playerTwo_chooseColor();
                                move = true;
                            }
                    }
                }
            }
        }
        private Label find_corner(string m)
        {
            if (la1.Text == m && lc3.Text == "")
                return lc3;
            else if (lc3.Text == m && la1.Text == "")
                return la1;
            else if (lc1.Text == m && la3.Text == "")
                return la3;
            else if (la3.Text == m && lc1.Text == "")
                return lc1;
            else if (la1.Text == "" && la3.Text == "" && lc1.Text == "" && lc3.Text == "")
            {
                return la1;
            }

            return null;
        }

        private Label win_Block(string m) //win or block
        {
            if (la1.Text == "" && la2.Text == m && la3.Text == m)
                return la1;
            else if (la1.Text == m && la2.Text == "" && la3.Text == m)
                return la2;
            else if (la1.Text == m && la2.Text == m && la3.Text == "")
                return la3;

            if (lb1.Text == "" && lb2.Text == m && lb3.Text == m)
                return lb1;
            else if (lb1.Text == m && lb2.Text == "" && lb3.Text == m)
                return lb2;
            else if (lb1.Text == m && lb2.Text == m && lb3.Text == "")
                return lb3;

            if (lc1.Text == "" && lc2.Text == m && lc3.Text == m)
                return lc1;
            else if (lc1.Text == m && lc2.Text == "" && lc3.Text == m)
                return lc2;
            else if (lc1.Text == m && lc2.Text == m && lc3.Text == "")
                return lc3;

            //Vertical
            if (la1.Text == "" && lb1.Text == m && lc1.Text == m)
                return la1;
            else if (la1.Text == m && lb1.Text == "" && lc1.Text == m)
                return lb1;
            else if (la1.Text == m && lb1.Text == m && lc1.Text == "")
                return lc1;

            if (la2.Text == "" && lb2.Text == m && lc2.Text == m)
                return la2;
            else if (la2.Text == m && lb2.Text == "" && lc2.Text == m)
                return lb2;
            else if (la2.Text == m && lb2.Text == m && lc2.Text == "")
                return lc2;

            if (la3.Text == "" && lb3.Text == m && lb3.Text == m)
                return la3;
            else if (la3.Text == m && lb3.Text == "" && lc3.Text == m)
                return lb3;
            else if (la3.Text == m && lb3.Text == m && lc3.Text == "")
                return lc3;

            //Diagonal
            if (la1.Text == "" && lb2.Text == m && lc3.Text == m)
                return la1;
            else if (la1.Text == m && lb2.Text == "" && lc3.Text == m)
                return lb2;
            else if (la1.Text == m && lb2.Text == m && lc3.Text == "")
                return lc3;

            if (la3.Text == "" && lb2.Text == m && lc1.Text == m)
                return la3;
            else if (la3.Text == m && lb2.Text == "" && lc1.Text == m)
                return lb2;
            else if (la3.Text == m && lb2.Text == m && lc1.Text == "")
                return lc1;
            return null;
        }

//________________________________________________________________________________________________________________________________________
        //Computer is X easy
        private void EasyMoveX()
        {

            bool lol = true;
            Random rnd = new Random();

            while (lol)
            {
                int number = rnd.Next(1, 10);
                if (number == 1 && la1.Text == "") { la1.Text = "X"; lol = false; la1.ForeColor = playerTwo_chooseColor(); }
                if (number == 2 && la2.Text == "") { la2.Text = "X"; lol = false; la2.ForeColor = playerTwo_chooseColor(); }
                if (number == 3 && la3.Text == "") { la3.Text = "X"; lol = false; la3.ForeColor = playerTwo_chooseColor(); }
                if (number == 4 && lb1.Text == "") { lb1.Text = "X"; lol = false; lb1.ForeColor = playerTwo_chooseColor(); }
                if (number == 5 && lb2.Text == "") { lb2.Text = "X"; lol = false; lb2.ForeColor = playerTwo_chooseColor(); }
                if (number == 6 && lb3.Text == "") { lb3.Text = "X"; lol = false; lb3.ForeColor = playerTwo_chooseColor(); }
                if (number == 7 && lc1.Text == "") { lc1.Text = "X"; lol = false; lc1.ForeColor = playerTwo_chooseColor(); }
                if (number == 8 && lc2.Text == "") { lc2.Text = "X"; lol = false; lc2.ForeColor = playerTwo_chooseColor(); }
                if (number == 9 && lc3.Text == "") { lc3.Text = "X"; lol = false; lc3.ForeColor = playerTwo_chooseColor(); }
            }


        }
        //_________________________________________________________________________________________________________________________
        //computer is O easy
        private void EasyMoveO()
        {
            bool lol = true;

            while (lol && counterO < 4)
            {


                Random rnd = new Random();

                int number = rnd.Next(1, 10);

                if (number == 1 && la1.Text == "") { la1.Text = "O"; lol = false; la1.ForeColor = playerTwo_chooseColor(); }
                if (number == 2 && la2.Text == "") { la2.Text = "O"; lol = false; la2.ForeColor = playerTwo_chooseColor(); }
                if (number == 3 && la3.Text == "") { la3.Text = "O"; lol = false; la3.ForeColor = playerTwo_chooseColor(); }
                if (number == 4 && lb1.Text == "") { lb1.Text = "O"; lol = false; lb1.ForeColor = playerTwo_chooseColor(); }
                if (number == 5 && lb2.Text == "") { lb2.Text = "O"; lol = false; lb2.ForeColor = playerTwo_chooseColor(); }
                if (number == 6 && lb3.Text == "") { lb3.Text = "O"; lol = false; lb3.ForeColor = playerTwo_chooseColor(); }
                if (number == 7 && lc1.Text == "") { lc1.Text = "O"; lol = false; lc1.ForeColor = playerTwo_chooseColor(); }
                if (number == 8 && lc2.Text == "") { lc2.Text = "O"; lol = false; lc2.ForeColor = playerTwo_chooseColor(); }
                if (number == 9 && lc3.Text == "") { lc3.Text = "O"; lol = false; lc3.ForeColor = playerTwo_chooseColor(); }


            }

        }
        //____________________________________________________________________________________________________________________________________
        //computer x intermediate
        private void moveX1()
        {
            Label text = null;
            text = win_Block("X"); //Win
            if (text == null)
            {
                text = win_Block("O"); //Block
                if (text == null)
                {
                    text = find_corner("O");
                    if (text == null)
                    {
                        any_space("X");
                    }
                }
            }
            foreach (Control p in Controls)
            {
                if (p is Panel && p.Enabled == true)
                {
                    foreach (Control l in p.Controls)
                    {
                        if (l == text)
                        {
                            l.ForeColor = playerTwo_chooseColor();
                            l.Text = "X";
                            whoseTurn.Text = secondPlayerName.Text + "'s turn";
                            break;
                        }
                    }
                }

            }

        }

        //Empty Functions
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }



































    }
}
