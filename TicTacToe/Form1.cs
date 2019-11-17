using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int playerScore = 0;
        int compScore = 0;
        int tieScore = 0;
        bool PlayerButton = false;
        string ctName = "";
        string arg1, arg2;
        string winningSymbol = "";
        About aboutWindow = new About();
        public static string[,] board = new string[3, 3] { { "", "", "" }, { "", "", "" }, { "", "", "" } };
        //defining boardvalue, higher value means better choice, numbers represent that how many winning combinations the actual tile is part of
        int[,] boardValue = new int[3, 3] { { 3, 2, 3 }, { 2, 4, 2 }, { 3, 2, 3 } };
        //win combinations and their indexes
        string[] win1 = new string[] { board[0, 0], board[0, 1], board[0, 2] };
        string[] win1_index = new string[] { "00", "01", "02" };
        string[] win2 = new string[] { board[1, 0], board[1, 1], board[1, 2] };
        string[] win2_index = new string[] { "10", "11", "12" };
        string[] win3 = new string[] { board[2, 0], board[2, 1], board[2, 2] };
        string[] win3_index = new string[] { "20", "21", "22" };
        string[] win4 = new string[] { board[0, 0], board[1, 0], board[2, 0] };
        string[] win4_index = new string[] { "00", "10", "20" };
        string[] win5 = new string[] { board[0, 1], board[1, 1], board[2, 1] };
        string[] win5_index = new string[] { "01", "11", "21" };
        string[] win6 = new string[] { board[0, 2], board[1, 2], board[2, 2] };
        string[] win6_index = new string[] { "02", "12", "22" };
        string[] win7 = new string[] { board[0, 0], board[1, 1], board[2, 2] };
        string[] win7_index = new string[] { "00", "11", "22" };
        string[] win8 = new string[] { board[2, 0], board[1, 1], board[0, 2] };
        string[] win8_index = new string[] { "20", "11", "02" };
        //symbol
        Image xImage = TicTacToe.Properties.Resources.X;
        Image oImage = TicTacToe.Properties.Resources.O;
        public Form1()
        {

            InitializeComponent();

        }
        
        private void tile00_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus(); //throws focus onto label so the tiles are not highlighted
            //when player puts down a symbol then decrease the value of every tile that is affected (every tile that is part of the same winning combinations as the player symbol and zero out the actual tile)
            boardValue[0, 0] = -5;
            boardValue[0, 1]--;
            boardValue[0, 2]--;
            boardValue[1, 0]--;
            boardValue[2, 0]--;
            boardValue[1, 1]--;
            boardValue[2, 2]--;
            //decides what symbol to use as a player (when player button is false -> the player is X)
            if (!PlayerButton)
            {
                tile00.BackgroundImage = xImage;
                board[0, 0] = "X"; //sets array to track
            }
            else
            { 
                tile00.BackgroundImage = oImage;
                board[0, 0] = "O";
            }
            tile00.Enabled = false; //disable tile after symbol
            playerSwitch.Enabled = false; //disable the switch where you select what symbol to play with
            WhoWins(CheckWin()); //checks is there is a winning
            if(winningSymbol=="")
            {
                Computer(); //calls Computer() to play
            }
           
        }
        private void tile01_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
            boardValue[0, 1] = -5;
            boardValue[0, 0]--;
            boardValue[1, 1]--;
            boardValue[0, 2]--;
            boardValue[2, 1]--;
            if (!PlayerButton)
            {
                tile01.BackgroundImage = xImage;
                board[0, 1] = "X";
            }
            else
            {
                board[0, 1] = "O";
                tile01.BackgroundImage = oImage;
            }
            tile01.Enabled = false;
            playerSwitch.Enabled = false;
            WhoWins(CheckWin());
            if (winningSymbol == "")
            {
                Computer(); //calls Computer() to play
            }

        }
        private void tile02_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
            boardValue[0, 2] = -5;
            boardValue[0, 1]--;
            boardValue[0, 0]--;
            boardValue[1, 1]--;
            boardValue[2, 0]--;
            boardValue[1, 2]--;
            boardValue[2, 2]--;

            if (!PlayerButton)
            {
                tile02.BackgroundImage = xImage;
                board[0, 2] = "X";
            }
            else
            {
                board[0, 2] = "O";
                tile02.BackgroundImage = oImage;
            }
            tile02.Enabled = false;
            playerSwitch.Enabled = false;
            WhoWins(CheckWin());
            if (winningSymbol == "")
            {
                Computer(); //calls Computer() to play
            }

        }
        private void tile10_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
            boardValue[1, 0] = -5;
            boardValue[0, 0]--;
            boardValue[1, 1]--;
            boardValue[2, 0]--;
            boardValue[1, 2]--;
            if (!PlayerButton)
            {
                tile10.BackgroundImage = xImage;
                board[1, 0] = "X";
            }
            else
            {
                board[1, 0] = "O";
                tile10.BackgroundImage = oImage;
            }
            tile10.Enabled = false;
            playerSwitch.Enabled = false;
            WhoWins(CheckWin());
            if (winningSymbol == "")
            {
                Computer(); //calls Computer() to play
            }

        }
        private void tile11_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
            boardValue[1, 1] = -5;
            boardValue[0, 0]--;
            boardValue[0, 1]--;
            boardValue[0, 2]--;
            boardValue[1, 2]--;
            boardValue[2, 2]--;
            boardValue[2, 1]--;
            boardValue[2, 0]--;
            boardValue[1, 0]--;

            if (!PlayerButton)
            {
                tile11.BackgroundImage = xImage;
                board[1, 1] = "X";
            }
            else
            {
                board[1, 1] = "O";
                tile11.BackgroundImage = oImage;
            }
            tile11.Enabled = false;
            playerSwitch.Enabled = false;
            WhoWins(CheckWin());
            if (winningSymbol == "")
            {
                Computer(); //calls Computer() to play
            }

        }
        private void tile12_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
            boardValue[1, 2] = -5;
            boardValue[0, 2]--;
            boardValue[1, 1]--;
            boardValue[2, 2]--;
            boardValue[1, 0]--;
            if (!PlayerButton)
            {
                tile12.BackgroundImage = xImage;
                board[1, 2] = "X";
            }
            else
            {
                board[1, 2] = "O";
                tile12.BackgroundImage = oImage;
            }
            tile12.Enabled = false;
            playerSwitch.Enabled = false;
            WhoWins(CheckWin());
            if (winningSymbol == "")
            {
                Computer(); //calls Computer() to play
            }

        }
        private void tile20_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
            boardValue[2, 0] = -5;
            boardValue[1, 0]--;
            boardValue[1, 1]--;
            boardValue[2, 1]--;
            boardValue[0, 0]--;
            boardValue[0, 2]--;
            boardValue[2, 2]--;
            if (!PlayerButton)
            {
                tile20.BackgroundImage = xImage;
                board[2, 0] = "X";
            }
            else
            {
                board[2, 0] = "O";
                tile20.BackgroundImage = oImage;
            }
            tile20.Enabled = false;
            playerSwitch.Enabled = false;
            WhoWins(CheckWin());
            if (winningSymbol == "")
            {
                Computer(); //calls Computer() to play
            }

        }
        private void tile21_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
            boardValue[2, 1] = -5;
            boardValue[2, 0]--;
            boardValue[1, 1]--;
            boardValue[2, 2]--;
            boardValue[0, 1]--;
            if (!PlayerButton)
            {
                tile21.BackgroundImage = xImage;
                board[2, 1] = "X";
            }
            else
            {
                board[2, 1] = "O";
                tile21.BackgroundImage = oImage;
            }
            tile21.Enabled = false;
            playerSwitch.Enabled = false;
            WhoWins(CheckWin());
            if (winningSymbol == "")
            {
                Computer(); //calls Computer() to play
            }

        }
        private void tile22_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
            boardValue[2, 2] = -5;
            boardValue[1, 2]--;
            boardValue[1, 1]--;
            boardValue[2, 1]--;
            boardValue[2, 0]--;
            boardValue[0, 0]--;
            boardValue[0, 2]--;
            if (!PlayerButton)
            {
                tile22.BackgroundImage = xImage;
                board[2, 2] = "X";
            }
            else
            {
                board[2, 2] = "O";
                tile22.BackgroundImage = oImage;
            }
            tile22.Enabled = false;
            playerSwitch.Enabled = false;
            WhoWins(CheckWin());
            if (winningSymbol == "")
            {
                Computer(); //calls Computer() to play
            }

        }
        private void playerSwitch_Click(object sender, EventArgs e) //player symbol select
        {
            if (!PlayerButton)
            {
                PlayerButton = true;
                label1.Text = "O";
                label3.Text = "X";
            }
            else
            {
                PlayerButton = false;
                label1.Text = "X";
                label3.Text = "O";
            }


        }
        private void reset_Click(object sender, EventArgs e) //score reset
        {
            compScore = 0;
            playerScore = 0;
            tieScore = 0;
            scoreboxPlayer.Text = playerScore.ToString();
            tieBox.Text = tieScore.ToString();
            scoreboxComp.Text = compScore.ToString();

        }
        public void NewGame()
        {
            //reset all tiles 
            tile00.BackgroundImage = null;
            tile01.BackgroundImage = null;
            tile02.BackgroundImage = null;
            tile10.BackgroundImage = null;
            tile11.BackgroundImage = null;
            tile12.BackgroundImage = null;
            tile20.BackgroundImage = null;
            tile21.BackgroundImage = null;
            tile22.BackgroundImage = null;
            //reset all arrays to defaul
            board = new string[3, 3] { { "", "", "" }, { "", "", "" }, { "", "", "" } };
            boardValue = new int[3, 3] { { 3, 2, 3 }, { 2, 4, 2 }, { 3, 2, 3 } };
            ButtonOnAll(); //enables tiles and buttons
        }
        private void newgameMenu_Click(object sender, EventArgs e) //new game
        {
            NewGame();


        }
        private void exitMenu_Click(object sender, EventArgs e)  //Exit
        {
            Application.Exit();
        }
        public string CheckWin() //checks if there is a win and returns the winning symbol or returns if TIE

        {
            

            if (board[0, 0] + board[0, 1] + board[0, 2] == "XXX" || board[0, 0] + board[0, 1] + board[0, 2] == "OOO")
            {
                winningSymbol = board[0, 0];
                return winningSymbol;
            }
            else if (board[1, 0] + board[1, 1] + board[1, 2] == "XXX" || board[1, 0] + board[1, 1] + board[1, 2] == "OOO")
            {
                winningSymbol = board[1, 0];
                return winningSymbol;
            }
            else if (board[2, 0] + board[2, 1] + board[2, 2] == "XXX" || board[2, 0] + board[2, 1] + board[2, 2] == "OOO")
            {
                winningSymbol = board[2, 0];
                return winningSymbol;
            }
            else if (board[0, 0] + board[1, 0] + board[2, 0] == "XXX" || board[0, 0] + board[1, 0] + board[2, 0] == "OOO")
            {
                winningSymbol = board[0, 0];
                return winningSymbol;
            }
            else if (board[0, 1] + board[1, 1] + board[2, 1] == "XXX" || board[0, 1] + board[1, 1] + board[2, 1] == "OOO")
            {
                winningSymbol = board[0, 1];
                return winningSymbol;
            }
            else if (board[0, 2] + board[1, 2] + board[2, 2] == "XXX" || board[0, 2] + board[1, 2] + board[2, 2] == "OOO")
            {
                winningSymbol = board[0, 2];
                return winningSymbol;
            }
            else if (board[0, 0] + board[1, 1] + board[2, 2] == "XXX" || board[0, 0] + board[1, 1] + board[2, 2] == "OOO")
            {
                winningSymbol = board[0, 0];
                return winningSymbol;
            }
            else if (board[2, 0] + board[1, 1] + board[0, 2] == "XXX" || board[2, 0] + board[1, 1] + board[0, 2] == "OOO")
            {
                winningSymbol = board[2, 0];
                return winningSymbol;
            }
           else if (IsFilled())
            {
                winningSymbol = "TIE";
                return winningSymbol;
            }
            winningSymbol = "";
            return winningSymbol;
        }

        public void ButtonOffAll() //disables tiles
        {
            tile00.Enabled = false;
            tile01.Enabled = false;
            tile02.Enabled = false;
            tile10.Enabled = false;
            tile11.Enabled = false;
            tile12.Enabled = false;
            tile20.Enabled = false;
            tile21.Enabled = false;
            tile22.Enabled = false;
        }
        public void ButtonOnAll() //enables tiles and player symbol select button when starting new game
        {
            tile00.Enabled = true;
            tile01.Enabled = true;
            tile02.Enabled = true;
            tile10.Enabled = true;
            tile11.Enabled = true;
            tile12.Enabled = true;
            tile20.Enabled = true;
            tile21.Enabled = true;
            tile22.Enabled = true;
            playerSwitch.Enabled = true;
        }



        public bool IsFilled() //function to check if all the tiles are used, thats when to decide if the game is a TIE
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == "")
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void WhoWins(string s) //based on the winningsymbol from CheckWin, it shows a dialogbox with the winner on it or tie, also increments scores
        {

            if (s == "X" && label1.Text == "X" || s == "O" && label1.Text == "O")
            {
                playerScore++;
                scoreboxPlayer.Text = playerScore.ToString();
                if(MessageBox.Show("Player Wins!") == DialogResult.OK)
                {
                    NewGame();
                }
                   // ButtonOffAll();
            }
            else if (s == "X" && label3.Text == "X" || s == "O" && label3.Text == "O")
            {
                compScore++;
                scoreboxComp.Text = compScore.ToString();
                if (MessageBox.Show("Computer Wins!") == DialogResult.OK)
                {
                    NewGame();
                }
               // ButtonOffAll();
            }
            else
            {
                if (IsFilled())
                {
                    tieScore++;
                    tieBox.Text = tieScore.ToString();
                    if (MessageBox.Show("Game is Tie!") == DialogResult.OK)
                    {
                        NewGame();
                    }
                   // ButtonOffAll();
                }
            }
        }

        public int[] Max() //finding max value tile(the best choice) and returning its indexes in an array
        {
            //finding max
            int max = -10;
            int MaxI = 0;
            int MaxJ = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (boardValue[i, j] >= max)
                    {
                        max = boardValue[i, j];
                        MaxI = i;
                        MaxJ = j;
                    }
                }
            }
            int[] retArr = new int[] { max, MaxI, MaxJ };
            return retArr;
        }
        public void setTile(string s, string a, string b) //after computer decides whats the best tile to use it calls this function which sets it also sets arrays
        {
            int x = Int32.Parse(a);
            int y = Int32.Parse(b);
            Control ct = Controls[s];
            
            if (label3.Text == "O")
            {
                ct.BackgroundImage = oImage;
                ct.Enabled = false;
                board[x, y] = "O";
                boardValue[x, y] = -5;
               


            }
            else
            {
                ct.BackgroundImage = xImage;
                ct.Enabled = false;
                board[x, y] = "X";
                boardValue[x, y] = -5;
             

            }

            
            win1 = new string[] { board[0, 0], board[0, 1], board[0, 2] };
            win2 = new string[] { board[1, 0], board[1, 1], board[1, 2] };
            win3 = new string[] { board[2, 0], board[2, 1], board[2, 2] };
            win4 = new string[] { board[0, 0], board[1, 0], board[2, 0] };
            win5 = new string[] { board[0, 1], board[1, 1], board[2, 1] };
            win6 = new string[] { board[0, 2], board[1, 2], board[2, 2] };
            win7 = new string[] { board[0, 0], board[1, 1], board[2, 2] };
            win8 = new string[] { board[2, 0], board[1, 1], board[0, 2] };
            WhoWins(CheckWin());

        }
      
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutWindow.ShowDialog();

        }



        public void Computer()

        {       //refreshing array to make it up to date
            
            win1 = new string[] { board[0, 0], board[0, 1], board[0, 2] };
            win2 = new string[] { board[1, 0], board[1, 1], board[1, 2] };
            win3 = new string[] { board[2, 0], board[2, 1], board[2, 2] };
            win4 = new string[] { board[0, 0], board[1, 0], board[2, 0] };
            win5 = new string[] { board[0, 1], board[1, 1], board[2, 1] };
            win6 = new string[] { board[0, 2], board[1, 2], board[2, 2] };
            win7 = new string[] { board[0, 0], board[1, 1], board[2, 2] };
            win8 = new string[] { board[2, 0], board[1, 1], board[0, 2] };

            string playerWinStr = label1.Text + label1.Text; //2 symbols next to eachother 
            string computerStr = label3.Text + label3.Text;
            Max();
           
            if (win1[0] + win1[1] + win1[2] == computerStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win1[i] == "") // if two symbols are next to eachother look for the empty tile
                    {
                        ctName = "tile" + win1_index[i]; //tile that needs to be set
                        // indexes to set arrays
                        arg1 = win1_index[i][0].ToString(); 
                        arg2 = win1_index[i][1].ToString();
                    }
                }
            }
            else if (win2[0] + win2[1] + win2[2] == computerStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win2[i] == "")
                    {
                        ctName = "tile" + win2_index[i];
                        arg1 = win2_index[i][0].ToString();
                        arg2 = win2_index[i][1].ToString();

                    }
                }
            }
            else if (win3[0] + win3[1] + win3[2] == computerStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win3[i] == "")
                    {
                        ctName = "tile" + win3_index[i];
                        arg1 = win3_index[i][0].ToString();
                        arg2 = win3_index[i][1].ToString();
                    }
                }
            }
            else if (win4[0] + win4[1] + win4[2] == computerStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win4[i] == "")
                    {
                        ctName = "tile" + win4_index[i];
                        arg1 = win4_index[i][0].ToString();
                        arg2 = win4_index[i][1].ToString();
                    }
                }
            }
            else if ( win5[0] + win5[1] + win5[2] == computerStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win5[i] == "")
                    {
                        ctName = "tile" + win5_index[i];
                        arg1 = win5_index[i][0].ToString();
                        arg2 = win5_index[i][1].ToString();
                    }
                }
            }
            else if ( win6[0] + win6[1] + win6[2] == computerStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win6[i] == "")
                    {
                        ctName = "tile" + win6_index[i];
                        arg1 = win6_index[i][0].ToString();
                        arg2 = win6_index[i][1].ToString();
                    }
                }
            }
            else if (win7[0] + win7[1] + win7[2] == computerStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win7[i] == "")
                    {
                        ctName = "tile" + win7_index[i];
                        arg1 = win7_index[i][0].ToString();
                        arg2 = win7_index[i][1].ToString();
                    }
                }
            }
            else if (win8[0] + win8[1] + win8[2] == computerStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win8[i] == "")
                    {
                        ctName = "tile" + win8_index[i];
                        arg1 = win8_index[i][0].ToString();
                        arg2 = win8_index[i][1].ToString();
                    }
                }
            }
            else if (win1[0] + win1[1] + win1[2] == playerWinStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win1[i] == "") // if two symbols are next to eachother look for the empty tile
                    {
                        ctName = "tile" + win1_index[i]; //tile that needs to be set
                        // indexes to set arrays
                        arg1 = win1_index[i][0].ToString();
                        arg2 = win1_index[i][1].ToString();
                    }
                }
            }
            else if (win2[0] + win2[1] + win2[2] == playerWinStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win2[i] == "")
                    {
                        ctName = "tile" + win2_index[i];
                        arg1 = win2_index[i][0].ToString();
                        arg2 = win2_index[i][1].ToString();

                    }
                }
            }
            else if (win3[0] + win3[1] + win3[2] == playerWinStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win3[i] == "")
                    {
                        ctName = "tile" + win3_index[i];
                        arg1 = win3_index[i][0].ToString();
                        arg2 = win3_index[i][1].ToString();
                    }
                }
            }
            else if (win4[0] + win4[1] + win4[2] == playerWinStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win4[i] == "")
                    {
                        ctName = "tile" + win4_index[i];
                        arg1 = win4_index[i][0].ToString();
                        arg2 = win4_index[i][1].ToString();
                    }
                }
            }
            else if (win5[0] + win5[1] + win5[2] == playerWinStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win5[i] == "")
                    {
                        ctName = "tile" + win5_index[i];
                        arg1 = win5_index[i][0].ToString();
                        arg2 = win5_index[i][1].ToString();
                    }
                }
            }
            else if (win6[0] + win6[1] + win6[2] == playerWinStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win6[i] == "")
                    {
                        ctName = "tile" + win6_index[i];
                        arg1 = win6_index[i][0].ToString();
                        arg2 = win6_index[i][1].ToString();
                    }
                }
            }
            else if (win7[0] + win7[1] + win7[2] == playerWinStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win7[i] == "")
                    {
                        ctName = "tile" + win7_index[i];
                        arg1 = win7_index[i][0].ToString();
                        arg2 = win7_index[i][1].ToString();
                    }
                }
            }
            else if (win8[0] + win8[1] + win8[2] == playerWinStr)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (win8[i] == "")
                    {
                        ctName = "tile" + win8_index[i];
                        arg1 = win8_index[i][0].ToString();
                        arg2 = win8_index[i][1].ToString();
                    }
                }
            }
            else 
            {
                if(board[1,1]==label1.Text && board[2, 2] == label1.Text && board[0,2]=="") // adding a special condition to make it unbeatable
                {
                    ctName = "tile02";
                    arg1 = "0";
                    arg2 = "2";
                }else if(board[0, 0] == label1.Text && board[1, 1] == label1.Text && board[2,0] == "")
                {
                    ctName = "tile20";
                    arg1 = "2";
                    arg2 = "0";
                }

                else //Adding some extra condition to make it unbeatable if non of these are true, just choose the best tile with Max();
                {
                    
                    if (board[1, 1] == label3.Text)
                    {
                        if (board[0, 0] + board[2, 2] == playerWinStr)
                        {
                            if (board[1, 0] == "")
                            {
                                ctName = "tile10";
                                arg1 = "1";
                                arg2 = "0";
                            }
                            if (board[0, 1] == "")
                            {
                                ctName = "tile01";
                                arg1 = "0";
                                arg2 = "1";
                            }
                            if (board[1, 2] == "")
                            {
                                ctName = "tile12";
                                arg1 = "1";
                                arg2 = "2";
                            }
                            if (board[2, 1] == "")
                            {
                                ctName = "tile21";
                                arg1 = "2";
                                arg2 = "1";
                            }
                        }
                        else if (board[0, 2] + board[2, 0] == playerWinStr)
                        {
                            if (board[1, 0] == "")
                            {
                                ctName = "tile10";
                                arg1 = "1";
                                arg2 = "0";
                            }
                            if (board[0, 1] == "")
                            {
                                ctName = "tile01";
                                arg1 = "0";
                                arg2 = "1";
                            }
                            if (board[1, 2] == "")
                            {
                                ctName = "tile12";
                                arg1 = "1";
                                arg2 = "2";
                            }
                            if (board[2, 1] == "")
                            {
                                ctName = "tile21";
                                arg1 = "2";
                                arg2 = "1";
                            }
                        }
                        else
                        {
                           
                            if (board[Max()[1], Max()[2]] == "")
                            {
                                ctName = "tile" + Max()[1].ToString() + Max()[2].ToString();
                                arg1 = Max()[1].ToString();
                                arg2 = Max()[2].ToString();
                            }
                        }

                    }
                    
                   else if (board[Max()[1], Max()[2]] == "")
                    {
                        
                        ctName = "tile" + Max()[1].ToString() + Max()[2].ToString();
                        arg1 = Max()[1].ToString();
                        arg2 = Max()[2].ToString();
                        
                    }
                }

               
            }

            
             setTile(ctName, arg1, arg2); //and finally make that step
            
        }

    }

    }

        
    

