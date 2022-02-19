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
using System.Data.SQLite;

namespace homework6
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadDatabase();
            //ReadFile();
            //lblWord.Text = chinese[1];
            setUp();

        }
        int total = 0;
        int wordIndex = 0;
        int timerSpeed = 5000;
        bool spdButtons = false; // show the buttons to change speed when true, hide when false
        bool timerOn = false; // boolean to check if the timer is switched on yet
        //List<string> english = new List<string>();
        //List<string> chinese = new List<string>();

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
            btnViewAll.BackColor = col;
            
            printWords();
        }
        string[] english;
        string[] chinese;
        int idx = 0;
        SortedDictionary<string, string> dict = new SortedDictionary<string, string>();

        
        // 老师的代码
        void ReadDatabase()
        {
            string file = @"..\..\..\College_Grade4.sqlite";

            //创建一个连接
            SQLiteConnection conn = new SQLiteConnection(
                "Data Source=" + file + ";Version=3;");
            conn.Open();



            //使用DataReader
            string sql = "select * from EnglishWords";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Word"] + " " + reader["Meanings1"]);
            }

            //也可以使用DataSet
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            foreach (DataTable dataTable in dataSet.Tables)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (DataColumn col in dataTable.Columns)
                    {
                        Console.WriteLine(row[col.ColumnName]);
                    }
                }
            }
            //为了与文件的数据相容，这里将数据放入数组中。实际上，可以直接使用DataTable
            DataTable dt = dataSet.Tables[0];
            int cnt = dt.Rows.Count;
            total = dt.Rows.Count;
            english = new string[cnt];
            chinese = new string[cnt];
            for (int i = 0; i < cnt; i++)
            {
                english[i] = dt.Rows[i]["Word"] as string;
                chinese[i] = dt.Rows[i]["Meanings1"] as string;
                string meanings2 = dt.Rows[i]["Meanings2"] as string; //有的单词有两个词义
                if (meanings2 != null)
                {
                    chinese[i] += " " + meanings2;
                }
            }


            //关闭连接
            conn.Close();

        }
        /*
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
        */
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

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}