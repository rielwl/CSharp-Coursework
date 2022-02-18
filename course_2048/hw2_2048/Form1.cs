using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace hw2_2048
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            this.BackColor = color;
            this.Text = "2048";
            color = System.Drawing.ColorTranslator.FromHtml("#CDD1E2");
            lblHighScore.BackColor = color;
            lblScore.BackColor = color;
            resetBoard();
            randomNum();
            updateBoard();
            resetChanged();
        }
        int[,] board = new int[4, 4]; // maintain an array for the board
        bool[,] changedBoard = new bool[4, 4]; // default is false, used in changing label appearance
        bool[,] changedVal = new bool[4, 4];
        int score = 0;
        int highScore = 0;


        public void randomNum()
        {
            Random rnd = new Random();
            int position; // position of the new number
            int row;
            int col;
            int addVal = 0;
            do
            {
                position = rnd.Next(1, 17) - 1; // position of the new number
                row = position / 4;
                col = position % 4;
            } while (board[row, col] != 0);
            addVal = rnd.Next(1, 7);
            if (addVal == 5) // lower probability of this occurring
            {
                addVal = 4;
            }
            else addVal = 2;
            board[row, col] = addVal;
            changedBoard[row, col] = true;

        }
        public void resetChanged()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    changedBoard[i, j] = false;
                    changedVal[i, j] = false;
                }
            }
        }
        public bool boardFilled()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (board[i, j] == 0) return false;
                }
            }
            return true;
        }
        public void resetBoard()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    changedBoard[i, j] = true; // to redraw the board
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    board[i, j] = 0;
                }
            }
            score = 0;
        }
        
        // update the various labels
        public void updateBoard()
        {
            string labelName;
            int id;
            lblScore.Text = score.ToString();
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(changedBoard[i,j])
                    {
                        id = (i + 1) + j * 4;
                        labelName = "label" + id.ToString();
                        Control ctr = this.Controls.Find(labelName, true)[0];
                        if (board[i, j] == 0) ctr.Text = "";
                        else ctr.Text = board[i, j].ToString();
                        // color board
                        if(board[i, j] == 0)
                        {
                            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#DADDE2");
                            ctr.BackColor = color;
                        }
                        else if(board[i, j] == 2)
                        {
                            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#F7BFB4");
                            ctr.BackColor = color;
                        }
                        else if(board[i, j] == 4)
                        {
                            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#FB9BA6");
                            ctr.BackColor = color;
                        }
                        else if (board[i, j] == 8)
                        {
                            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#B589C0");
                            ctr.BackColor = color;
                        }
                        else if (board[i, j] == 16)
                        {
                            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#7686C8");
                            ctr.BackColor = color;
                        }
                        else if (board[i, j] == 32)
                        {
                            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#DB93B0");
                            ctr.BackColor = color;
                        }

                        else if (board[i, j] == 64)
                        {
                            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#B09ADB");
                            ctr.BackColor = color;
                        }
                        else if (board[i, j] == 128)
                        {
                            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#927977");
                            ctr.BackColor = color;
                        }
                        else if (board[i, j] == 256)
                        {
                            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#7DAF9C");
                            ctr.BackColor = color;
                        }
                        else if (board[i, j] == 512)
                        {
                            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#A2B355");
                            ctr.BackColor = color;
                        }
                        else if (board[i, j] == 1024)
                        {
                            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#27A58C");
                            ctr.BackColor = color;
                        }
                        else if (board[i, j] == 2048)
                        {
                            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("##DBEB89");
                            ctr.BackColor = color;
                        }
                    }
                }
            }
            resetChanged();
        }

        

        public bool moveUp() // when the up key is pressed
        {
            bool flagCheck = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = j + 1; k < 4; k++) // move through finding a not empty value
                    {
                        if (board[i, k] == 0) continue;
                        else if (board[i, k] == board[i, j])
                        {
                            if (!changedVal[i, j] && !changedVal[i, k])
                            {
                                board[i, j] *= 2;
                                changedVal[i, j] = true;
                                changedVal[i, k] = false;
                                board[i, k] = 0;
                                changedBoard[i, j] = true;
                                changedBoard[i, j] = false;
                                score += board[i, j];
                                flagCheck = true;
                            }
                           
                        }
                        else
                        {
                            if (board[i, j] != 0) // don't match, not empty, just leave it be and check the j
                            {
                                break;
                            }
                            else if (board[i, j] == 0 && board[i, k] != 0) // move to take over the empty space
                            {
                                board[i, j] = board[i, k];
                                board[i, k] = 0;
                                changedBoard[i, j] = true;
                                changedBoard[i, k] = true;
                                changedVal[i, j] = changedVal[i, k];
                                changedVal[i, k] = false;
                                flagCheck = true;
                            }
                        }
                    }
                }
            }
            return flagCheck;
        }

        public bool moveDown() // when the right key is pressed
        {
            bool flagCheck = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--) // move through finding a not empty value
                    {
                        if (board[i, k] == 0) continue;
                        else if (board[i, k] == board[i, j])
                        {
                            if (!changedVal[i, j] && !changedVal[i, k])
                            {
                                board[i, j] *= 2;
                                board[i, k] = 0;
                                changedBoard[i, j] = true;
                                changedBoard[i, k] = true;
                                changedVal[i, j] = true;
                                changedVal[i, k] = false;
                                score += board[i, j];
                                flagCheck = true;
                            }
                            
                        }
                        else
                        {
                            if (board[i, j] != 0) // don't match, not empty, just leave it be and check the j
                            {
                                break;
                            }
                            else if (board[i, j] == 0 && board[i, k] != 0) // move to take over the empty space
                            {
                                board[i, j] = board[i, k];
                                board[i, k] = 0;
                                changedBoard[i, j] = true;
                                changedBoard[i, k] = true;
                                changedVal[i, j] = changedVal[i, k];
                                changedVal[i, k] = false;
                                flagCheck = true;
                            }
                        }
                    }
                }
            }
            return flagCheck;
        }
        public bool moveLeft() // when the up key is pressed
        {
            bool flagCheck = false;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int k = i + 1; k < 4; k++) // move through finding a not empty value
                    {
                        if (board[k, j] == 0) continue;
                        else if (board[k, j] == board[i, j])
                        {
                            if (!changedVal[i, j] && !changedVal[k, j])
                            {
                                board[i, j] *= 2;
                                board[k, j] = 0;
                                changedBoard[i, j] = true;
                                changedBoard[k, j] = true;
                                changedVal[i, j] = true;
                                changedVal[k, j] = false;
                                score += board[i, j];
                                flagCheck = true;
                            }
                            
                        }
                        else
                        {
                            if (board[i, j] != 0) // don't match, not empty, just leave it be and check the j
                            {
                                break;
                            }
                            else if (board[i, j] == 0 && board[k, j] != 0) // move to take over the empty space
                            {
                                board[i, j] = board[k, j];
                                board[k, j] = 0;
                                changedBoard[i, j] = true;
                                changedBoard[k, j] = true;
                                changedVal[i, j] = changedVal[k, j];
                                changedVal[k, j] = false;
                                flagCheck = true;
                            }
                        }
                    }
                }
            }
            return flagCheck;
        }
        public bool moveRight() // when the up key is pressed
        {
            bool flagCheck = false;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 3; i >= 0; i--)
                {
                    for (int k = i - 1; k >= 0; k--) // move through finding a not empty value
                    {
                        if (board[k, j] == 0) continue;
                        else if (board[k, j] == board[i, j])
                        {
                            if (!changedVal[i, j] && !changedVal[k, j])
                            {
                                board[i, j] *= 2;
                                board[k, j] = 0;
                                changedBoard[i, j] = true;
                                changedBoard[k, j] = true;
                                changedVal[i, j] = true;
                                changedVal[k, j] = false;
                                score += board[i, j];
                                flagCheck = true;
                            }
                            
                        }
                        else
                        {
                            if (board[i, j] != 0) // don't match, not empty, just leave it be and check the j
                            {
                                break;
                            }
                            else if (board[i, j] == 0 && board[k, j] != 0) // move to take over the empty space
                            {
                                board[i, j] = board[k, j];
                                board[k, j] = 0;
                                changedBoard[i, j] = true;
                                changedBoard[k, j] = true;
                                changedVal[i, j] = changedVal[k, j];
                                changedVal[k, j] = false;
                                flagCheck = true;
                            }
                        }
                    }
                }
            }
            return flagCheck;
        }
        public bool checkUp() // booleans to check if there are still moves
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j+1] == board[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool checkDown() // when the right key is pressed
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 1; j--)
                {

                    if (board[i, j - 1] == board[i, j])
                    {
                        return true;
                    }
                        
                }
            }
            return false;
        }
        public bool checkLeft() // when the up key is pressed
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (board[i + 1, j] == board[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool checkRight() // when the up key is pressed
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 3; i >= 1; i--)
                {

                    if (board[i - 1, j] == board[i, j])
                    {
                        return true;

                    }
                        
                }
            }
            return false ;
        }
        public bool gameNotEnded() // return true if the game has yet to end
        {
            if (boardFilled())
            {
                if (checkDown()) return true;
                if (checkUp()) return true;
                if (checkLeft()) return true;
                if (checkRight()) return true;
                return false;
            }
            return true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
            {
                if (moveDown())
                {
                    randomNum();
                    updateBoard();
                }
                
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (moveUp())
                {
                    randomNum();
                    updateBoard();
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (moveLeft())
                {
                    randomNum();
                    updateBoard();
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (moveRight())
                {
                    randomNum();
                    updateBoard();
                }
            }
            else if(e.KeyCode == Keys.R)
            {
                resetBoard();
                updateBoard();
                resetChanged();
                randomNum();
                updateBoard();
                if (highScore < score)
                {
                    highScore = score;
                    lblHighScore.Text = highScore.ToString();
                }
                lblHighScore.Text = score.ToString();
            }

            if (!gameNotEnded())
            {
                MessageBox.Show("Game over! Press R to reset the board!");
            }
            
        }

        
    }

}
