using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1dice
{
    public partial class Form1 : Form
    {
        int times, val;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            label2.Text = "2 :";
            label3.Text = "3 :";
            label4.Text = "4 :";
            label5.Text = "5 :";
            label6.Text = "6 :";
            label7.Text = "7 :";
            label8.Text = "8 :";
            label9.Text = "9 :";
            label10.Text = "10:";
            label11.Text = "11:";
            label12.Text = "12:";
            this.Text = "投色字";
        }

        private void btnTryIt_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("简单的投色字winform。只需要输入想要投几次色子按Submit就会生成一个图形（是两个色子加起来的数）。" + Environment.NewLine
                + "图形中显示每个数字被投的次数，而也会在每个数字的旁边显示被投的次数" + Environment.NewLine
                + "也可以按Try It!来试着自己投色子。");
        }

        private void btnSubmitTimes_Click(object sender, EventArgs e)
        {
            times = Convert.ToInt32(txtNumTimes.Text);
            int[] arr = new int[20];
            for (int i = times; i > 0; i--)
            {
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                val = dice1 + dice2;
                arr[val]++;
            }
            label2.Text = "2 : " + arr[2];
            label3.Text = "3 : " + arr[3];
            label4.Text = "4 : " + arr[4];
            label5.Text = "5 : " + arr[5];
            label6.Text = "6 : " + arr[6];
            label7.Text = "7 : " + arr[7];
            label8.Text = "8 : " + arr[8];
            label9.Text = "9 : " + arr[9];
            label10.Text = "10: " + arr[10];
            label11.Text = "11: "+ arr[11];
            label12.Text = "12: "+ arr[12];
            Graphics g = this.CreateGraphics();
            g.Clear(BackColor);
            g.DrawRectangle(Pens.Black, 83, 80, arr[2], 24); // draw 2
            g.DrawRectangle(Pens.Black, 83, 104, arr[3], 24); // draw 3
            g.DrawRectangle(Pens.Black, 83, 128, arr[4], 24); // draw 4
            g.DrawRectangle(Pens.Black, 83, 152, arr[5], 24); // draw 5
            g.DrawRectangle(Pens.Black, 83, 176, arr[6], 24); // draw 6
            g.DrawRectangle(Pens.Black, 83, 200, arr[7], 24); // draw 7
            g.DrawRectangle(Pens.Black, 83, 224, arr[8], 24); // draw 8
            g.DrawRectangle(Pens.Black, 83, 248, arr[9], 24); // draw 9
            g.DrawRectangle(Pens.Black, 83, 272, arr[10], 24); // draw 10
            g.DrawRectangle(Pens.Black, 83, 296, arr[11], 24); // draw 11
            g.DrawRectangle(Pens.Black, 83, 320, arr[12], 24); // draw 12


        }
    }
}
