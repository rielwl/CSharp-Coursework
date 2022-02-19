using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace homework9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "验证";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string idpattern = @"^\d{17}(?:d|X)$"; //first part is the 17 digits, second is the last digit in the ID
            int[] weights = { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
            string[] lastDigit = { "1", "0", "X", "9", "8", "7", "6", "5", "4", "3", "2" };
            int sum = 0; 
            if(id.Length != 18)
            {
                MessageBox.Show("身份证长度不对！");
                return;
            }
            

            
            if(Regex.IsMatch(id, idpattern))
            {
                for (int i = 0; i < 17; i++)
                {
                    sum += weights[i] * int.Parse(id[i].ToString());
                }
                int result = sum % 11;
                if (lastDigit[result] == id[17].ToString())
                {
                    MessageBox.Show("身份证格式正确！");
                }
                else
                {
                    MessageBox.Show("最后一位有错误！");
                }
            }
            else
            {
                MessageBox.Show("身份证格式错误!");
            }
            txtID.Text = "";
        }
    }
}
