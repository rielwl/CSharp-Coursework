using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace homework6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.TopMost = true;
            this.Text = "Simple Flashcards!";
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#C1E0F7");
            this.BackColor = col;
        }

        // 老师的代码!
        private void Form2_Load(object sender, EventArgs e)
        {
            string file = @"..\..\..\College_Grade4.sqlite";

            //创建一个连接
            SQLiteConnection conn = new SQLiteConnection(
                "Data Source=" + file + ";Version=3;");
            conn.Open();

            //查询到数据
            string sql = "select * from EnglishWords";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            //将DataSet绑定到界面上
            dataGridView1.DataSource = dataSet.Tables[0];

            //关闭连接
            conn.Close();
        }
    }
}
