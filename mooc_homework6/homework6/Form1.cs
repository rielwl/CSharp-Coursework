using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework6
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadFile();
            //lblWord.Text = chinese[1];
            setUp();

        }
        int total = 0;
        int wordIndex = 0;
        int timerSpeed = 5000;
        bool spdButtons = false; // show the buttons to change speed when true, hide when false
        bool timerOn = false; // boolean to check if the timer is switched on yet
        List<string> english = new List<string>();
        List<string> chinese = new List<string>();

        // set up the background, color, various settings
        void setUp()
        {
            this.TopMost = true;
            this.Text = "Simple Flashcards!";
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#C1E0F7");
            this.BackColor = col;
            label1.BackColor = col;
            col = System.Drawing.ColorTranslator.FromHtml("#A4DEF9");
            lblMeaning.BackColor = col;
            col = System.Drawing.ColorTranslator.FromHtml("#97F9F9");
            lblWord.BackColor = col;
            col = System.Drawing.ColorTranslator.FromHtml("#CFBAE1");
            btnEnter.BackColor = col;
            btnPauseStart.BackColor = col;
            btnProgress.BackColor = col;
            btnSpeedChange.BackColor = col;
            
            printWords();
        }

        // read College_Grade4.txt and store in respective lists
        void ReadFile()
        {
            StreamReader sw = new StreamReader(@"..\..\..\College_Grade4.txt", Encoding.Default);
            string content = sw.ReadToEnd();
            string[] lines = content.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Trim().Split('\t');
                if (words.Length < 2) continue;
                english.Add(words[0]);
                chinese.Add(words[1]);
                total++;
            }
            sw.Close();
        }

        // Just a function to make printing words easier
        void printWords() {
            lblWord.Text = english[wordIndex];
            lblMeaning.Text = chinese[wordIndex];
        }

        // Timer tick changes
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerOn){
                printWords();
                wordIndex++;
            }
        }

        // Saves current progress in Progress.txt when closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string fname = @"..\..\..\Progress.txt";
            StreamWriter writer = new StreamWriter(fname, false, System.Text.Encoding.Default);
            writer.WriteLine(wordIndex.ToString());
            //MessageBox.Show("word"+wordIndex);
            writer.Close();

        }

        // pause and start timer
        private void btnPauseStart_Click(object sender, EventArgs e)
        {
            if(timerOn == false)
            {
                timer1.Interval = timerSpeed;
                timerOn = true;
                btnPauseStart.Text = "停止";
                timer1.Start();
            }
            else
            {
                timerOn = false;
                btnPauseStart.Text = "开始";
                timer1.Stop();
            }
        }

        // Load in previous progress
        private void btnProgress_Click(object sender, EventArgs e)
        {
            if (timerOn)
            {
                MessageBox.Show("Please stop timer before loading previous progress");
            }
            else 
            {
                StreamReader reader = new StreamReader(@"..\..\..\Progress.txt", Encoding.Default);
                int x = 0;
                string content = reader.ReadLine();
                if (String.IsNullOrEmpty(content))
                {
                    x = 0;
                }
                else
                {
                    x = int.Parse(content);
                }
                wordIndex = x;
                MessageBox.Show("Previous Progress = " + x + "/" + total);
                reader.Close();
                printWords();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }
        // override
        // left, right to navigate words
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if(keyData == Keys.Left)
            {
                wordIndex--;
                printWords();
                return false;
            }
            else if (keyData == Keys.Right)
            {
                wordIndex++;
                printWords();
                return false;
            }
            return base.ProcessDialogKey(keyData);
            
        }

        // show the various buttons to change the speeds
        private void btnSpeedChange_Click(object sender, EventArgs e)
        {
            if (spdButtons == false)
            {
                spdButtons = true;
                txtSpeed.Visible = true;
                btnEnter.Visible = true;
            }
            else
            {
                spdButtons = false;
                txtSpeed.Visible = false;
                btnEnter.Visible = false;
            }

        }
        // enter the new speed
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (timerOn)
            {
                MessageBox.Show("请先停止Timer!");
            }
            else
            {
                string strTimerSpeed = txtSpeed.Text;
                if (String.IsNullOrEmpty(strTimerSpeed))
                {
                    MessageBox.Show("请输入您要的速度");
                }
                else
                {
                    timerSpeed = (int.Parse(strTimerSpeed));
                    txtSpeed.Text = "";
                    MessageBox.Show("当前速度: " + timerSpeed + "ms");
                    btnEnter.Visible = false;
                    txtSpeed.Visible = false;
                }
            }

        }

        
        
        
            

    }
}