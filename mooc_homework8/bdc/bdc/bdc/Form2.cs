using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            //创建空的数据库
            string file = "MyDatabase.sqlite";
            if (!File.Exists(file))
            {
                SQLiteConnection.CreateFile(file);
            }

            //创建一个连接
            SQLiteConnection conn = new SQLiteConnection(
                "Data Source=" + file + ";Version=3;");
            conn.Open();

            //创建一个table
            string sql = "create table if not exists people (name varchar(10), age int)";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();

            //插入一些数据
            sql = "insert into people (name, age) values ('Me', 21)";
            command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();

            sql = "insert into people (name, age) values ('You', 22)";
            command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();

            sql = "insert into people (name, age) values ('She', 19)";
            command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();

            //使用DataReader
            sql = "select * from people order by age desc";
            command = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("Name: " + reader["name"]
                    + "\nAge: " + reader["age"]);

            //使用DataSet
            sql = "select * from people order by age desc";
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
            //将DataSet绑定到界面上
            dataGridView1.DataSource = dataSet.Tables[0];

            //关闭连接
            conn.Close();
        }


    }
}
