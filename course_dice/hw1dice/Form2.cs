using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hw1dice
{
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        int dice1 = 0;
        int dice2 = 0;
        int total = 0;
        int[] arr = new int[20];
        public Form2()
        {
            InitializeComponent();
            this.Text = "Try It!";
        }

        public void updateTable()
        {
            lblVal2.Text = Convert.ToString(arr[2]);
            lblVal3.Text = Convert.ToString(arr[3]);
            lblVal4.Text = Convert.ToString(arr[4]);
            lblVal5.Text = Convert.ToString(arr[5]);
            lblVal6.Text = Convert.ToString(arr[6]);
            lblVal7.Text = Convert.ToString(arr[7]);
            lblVal8.Text = Convert.ToString(arr[8]);
            lblVal9.Text = Convert.ToString(arr[9]);
            lblVal10.Text = Convert.ToString(arr[10]);
            lblVal11.Text = Convert.ToString(arr[11]);
            lblVal12.Text = Convert.ToString(arr[12]);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            dice1 = rnd.Next(1, 7);
            dice2 = rnd.Next(1, 7);
            lblDiceOne.Text = Convert.ToString(dice1);
            lblDiceTwo.Text = Convert.ToString(dice2);
            total = dice1 + dice2;
            arr[total]++;
            updateTable();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                arr[i] = 0;
            }
            updateTable();
            lblDiceOne.Text = "0";
            lblDiceTwo.Text = "0";
        }
    }
}
