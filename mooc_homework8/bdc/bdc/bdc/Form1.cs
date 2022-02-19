using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Data.SQLite;

namespace bdc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 使用Sqlite，需要安装System.Data.SQLite.Core
        // 在visual studio中，工具--NuGet包管理器--管理解决方案的NuGet程序包--浏览
        // 搜索Sqlite就可以看见System.Data.SQLite.Core，然后选安装(安装时，项目名要打勾）
        private void Form1_Load(object sender, EventArgs e)
        {
            //ReadFile(); //读文件
            ReadDatabase(); //读数据库

            this.TopMost = true;
            
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        int idx = 0;
        SortedDictionary<string, string> dict = new SortedDictionary<string, string>();
        string[] english;
        string[] chinese;
        void ReadFile()
        {
            StreamReader sw = new StreamReader(@"..\..\..\College_Grade4.txt", Encoding.Default);

            string content = sw.ReadToEnd();
            string[] lines = content.Split('\n');
            english = new string[lines.Length-1];
            chinese = new string[lines.Length-1];
            for( int i=1; i<lines.Length; i++)  //首行是标题行，忽略之
            {
                lines[i] = lines[i].Trim();
                string[] words = lines[i].Split('\t');
                if (words.Length < 2) continue;
                if (!dict.ContainsKey(words[0])) dict.Add(words[0], words[1]);
                english[i] = words[0];
                chinese[i] = words[1];
            }
        }

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
                Console.WriteLine( reader["Word"] +" " + reader["Meanings1"]);
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
            english = new string[cnt];
            chinese = new string[cnt];
            for (int i = 0; i < cnt; i++)
            {
                english[i] = dt.Rows[i]["Word"] as string;
                chinese[i] = dt.Rows[i]["Meanings1"] as string;
                string meanings2 = dt.Rows[i]["Meanings2"] as string; //有的单词有两个词义
                if(meanings2 != null)
                {
                    chinese[i] += " " + meanings2;
                }
            }


            //关闭连接
            conn.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = english[idx];
            label2.Text = chinese[idx];

            idx++;
            if (idx >= english.Length) idx = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
