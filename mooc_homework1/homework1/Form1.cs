using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1
{
    public partial class Form1 : Form
    {
        public List<string> wordsList = new List<string>();
        public List<string> defList = new List<string>();
        Random rnd = new Random();
        Random rndcolor = new Random();

        int correct = 0;
        int incorrect = 0;
        int curr = 0; // current index we are on
        int flag = 0; // starting flag

        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Simple Quiz";
            instance = this;
            curr = rnd.Next(0, wordsList.Count);
            if (wordsList.Count > 0) lblWord.Text = wordsList[curr];
            // MessageBox.Show("请先按Help来理解这个应用");
        }


        private void checkGame(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (flag == 0) {
                    curr = rnd.Next(0, defList.Count);
                    if (wordsList.Count > 0)
                    {
                        flag = 1;
                        lblWord.Text = defList[curr];
                        txtCheck.Text = null;
                        return;
                    }
                    MessageBox.Show("现在列表里没字，请按Default Words或Add Words");
                    return;
                }
                if(txtCheck.Text == wordsList[curr])
                {
                    lblAns.Text = "";
                    correct++;
                    curr = rnd.Next(0, wordsList.Count);
                    if (wordsList.Count>0) lblWord.Text = defList[curr];
                    txtCheck.Text = null;
                }
                else
                {
                    incorrect++;
                    lblAns.Text = "The word was " + wordsList[curr];
                    curr = rnd.Next(0, wordsList.Count);
                    if (wordsList.Count > 0) lblWord.Text = defList[curr];
                    txtCheck.Text = null;
                }
                lblcrct.Text = "Correct: " + correct;
                lblincrct.Text = "Incorrect: " + incorrect;
            }
            
        }

        private void btnTxtColor_Click(object sender, EventArgs e)
        {
            int x = rndcolor.Next(255);
            int y = rndcolor.Next(255);
            int z = rndcolor.Next(255);
            this.ForeColor = Color.FromArgb(x, y, z); // changes the color of the text but not the textbox text
            this.txtCheck.ForeColor = Color.FromArgb(x, y, z); // changes the color of the textbox text as well
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void btnResetScr_Click(object sender, EventArgs e)
        {
            correct = 0;
            incorrect = 0;
            lblcrct.Text = "Correct: " + correct;
            lblincrct.Text = "Incorrect: " + incorrect;
            txtCheck.Text = null;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            //找了几个GRE字与意思加进来，如果不想自己加词来试可以直接按default
            wordsList.Add("lucid");
            defList.Add("very clear and easy to understand");
            wordsList.Add("gullible");
            defList.Add("easily persuaded to believe something");
            wordsList.Add("laudable");
            defList.Add("deserving praise and commendation");
            wordsList.Add("homogenous");
            defList.Add("of the same or similar kind");
            wordsList.Add("volatile");
            defList.Add("likely to change rapidly and unpredictably");
            wordsList.Add("advocate");
            defList.Add("publicly recommend or support");
            wordsList.Add("deride");
            defList.Add("to express contempt for; ridicule");
            wordsList.Add("lethargic");
            defList.Add("lacking energy");

            curr = rnd.Next(0, defList.Count);
            flag = 1;
            lblWord.Text = defList[curr];
            txtCheck.Text = null;
        }

        private void btnResetList_Click(object sender, EventArgs e)
        {
            wordsList.Clear();
            defList.Clear();
            flag = 0;
            correct = 0;
            incorrect = 0;
            lblcrct.Text = "Correct: " + correct;
            lblincrct.Text = "Incorrect: " + incorrect;
            lblAns.Text = "";
            lblWord.Text = "Meaning";
            txtCheck.Text = null;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这是个特别简单的quiz应用，更多是为了做一种flashcard式的quiz，可用来记字。" + 
                Environment.NewLine + "主要的是由字和字的意思来组成的" +
                Environment.NewLine + "会显示某个已在列表里的意思，您就在textbox里填字" + 
                Environment.NewLine + "应用开始时，没有任何字，可以按右边的Default Words，我已经设置了几个GRE字，来试试应用" +
                Environment.NewLine + "也可以按右边的Add Words来添加字和它的意思" +
                Environment.NewLine + "直接Enter一下就可以刷新字" +
                Environment.NewLine + "这也可以用来做quiz，但是答案的话一定要和Add Words里加的答案一致，所以答案最好是一个字");
        }

        private void btnCurrWords_Click(object sender, EventArgs e)
        {
            string allWords = "";
            int isFirst = 1;
            foreach (string word in wordsList)
            {
                if (isFirst == 1)
                {
                    allWords += word;
                    isFirst = 0;
                }
                else {
                    allWords = allWords + ", " + word;
                }
            }
            MessageBox.Show("Current word list:" + Environment.NewLine + allWords);
                
            
        }
    }
}
