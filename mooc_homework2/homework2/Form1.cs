using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework2
{
    public partial class Form1 : Form
    {
        int digitOne, digitTwo, opid;
        string op;
        int ans;
        int correct = 0, incorrect = 0;
        int timerSpeed = 5000;
        double score = 0;
        bool timerFlag = false; // use it to take note of if the timer has started
        double highScore = 0;
        Random rnd = new Random();
        System.Drawing.Color colorWrong = System.Drawing.ColorTranslator.FromHtml("#f0a8a3");
        System.Drawing.Color colorRight = System.Drawing.ColorTranslator.FromHtml("#d4edca");
        System.Drawing.Color colorNorm = System.Drawing.ColorTranslator.FromHtml("");
        private void newQn()
        {
            digitOne = rnd.Next(998) + 1;
            digitTwo = rnd.Next(998) + 1;
            if (digitTwo > digitOne)
            {
                int tmp = digitOne;
                digitOne = digitTwo;
                digitTwo = tmp;
            }
            opid = rnd.Next(4);
            switch (opid)
            {
                case 0:
                    op = "+";
                    ans = digitOne + digitTwo;
                    break;
                case 1:
                    op = "-";
                    ans = digitOne - digitTwo;
                    break;
                case 2:
                    op = "*";
                    ans = digitOne * digitTwo;
                    break;
                case 3:
                    op = "/";
                    ans = digitOne / digitTwo;
                    break;
            }
            lblDigit1.Text = digitOne.ToString();
            lblDigit2.Text = digitTwo.ToString();
            lblOpr.Text = op;
        }
        public Form1()
        {
            InitializeComponent();
            newQn();
        }
        
        
        private int chkAns()
        {
            string strAns = txtAns.Text; // Getting the value from the textbox
            if (String.IsNullOrEmpty(strAns))
            {
                incorrect++;
                lblIncorr.Text = "Incorrect: " + incorrect;
                this.BackColor = colorWrong;
                lblCorrAns.Text = "上一道题的答案是： " + ans;
                txtAns.Text = "";
                return 0; // 若不对，返回0
            }
            int x = int.Parse(strAns);
            if (x == ans)
            {
                correct++;
                lblCorr.Text = "Correct:  " + correct;
                this.BackColor = colorRight;
                txtAns.Text = "";
                return 1; // 若对，返回1
            }
            else
            {
                incorrect++;
                lblIncorr.Text = "Incorrect: " + incorrect;
                this.BackColor = colorWrong;
                lblCorrAns.Text = "上一道题的答案是： " + ans;
                txtAns.Text = "";
                return 0; // 若不对，返回0
            }
            
        }
        private void currScore()
        {
            double pt;
            // calculate number of digits for each value
            double place1 = Math.Floor(Math.Log10(digitOne) + 1);
            double place2 = Math.Floor(Math.Log10(digitTwo) + 1);
            // insert current score calculation code here
            if (opid == 0 || opid == 1) // if it's addition or subtraction
            {
                pt = place1 + place2;
                score += pt;
                lblScore.Text = "Score: " + score;
            }
            else // if it's multiplication or division
            {
                pt = place1 * place2;
                if (pt <= 4) pt += 1;
                score += pt;
                lblScore.Text = "Score: " + score;
            }
        }

        private void resetGame()
        {
            // enter reset game code here
            if(score > highScore)
            {
                highScore = score;
                
            }
            lblHighScore.Text = "High Score: " + highScore;
            txtAns.Text = "";
            correct = 0;
            incorrect = 0;
            score = 0;
            lblCorr.Text = "Correct: " + correct;
            lblIncorr.Text = "Incorrect: " + incorrect;
            lblScore.Text = "Score: " + score;
        }

        private void txtAns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (timerFlag == false)
                {
                    MessageBox.Show("请先按'计时开始'！！");
                    txtAns.Text = "";
                }
                else if (chkAns() == 1)
                {
                    currScore();
                }
                newQn();
                
            }
        }

        private void btnSpd_Click(object sender, EventArgs e)
        {
            // changing speed, show the labels, show current speed etc
            btnSubmitSpd.Visible = true;
            txtSpd.Visible = true;
            lblMS.Text = "速度为ms";
            lblCurrSpd.Text = "当前速度： " + timerSpeed;
        }

        private void btnSubmitSpd_Click(object sender, EventArgs e)
        {
            string strTimerSpeed = txtSpd.Text;
            if (String.IsNullOrEmpty(strTimerSpeed))
            {
                MessageBox.Show("请输入您要的速度");
            }
            else
            {
                timerSpeed = Convert.ToInt32(strTimerSpeed);
                btnSubmitSpd.Visible = false;
                txtSpd.Visible = false;
                lblMS.Text = "";
                lblCurrSpd.Text = "";
                MessageBox.Show("当前速度已经改成" + timerSpeed + "ms");
            }
        }

        private void btnTimerStart_Click(object sender, EventArgs e)
        {
            // Start timer
            if (timerFlag == false) // no timer running currently
            {
                timer1.Interval = timerSpeed;
                MessageBox.Show("Timer Started!");
                timerFlag = true; // timer started
                timer1.Start();
            }


        }

        private void btnTimerStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerFlag = false;
            MessageBox.Show("Timer Stopped!");
            resetGame();
        }

        private void btnScoringCalc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("计分标准是若是+或-，直接将两个数字的位数加起来" + Environment.NewLine
                + "若是*或/，乘两个数字的位数，若是少于等于4就加一" + Environment.NewLine
                + "（纯粹因为认为乘除比加减难）");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkAns() == 1) {
                currScore();
            }
            newQn();
        }

        

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (timerFlag == false)
            {
                MessageBox.Show("请先按'计时开始'！！");
            }
            else if (chkAns() == 1)
            {
                currScore();
            }
            newQn();
            
        }
    }
}
