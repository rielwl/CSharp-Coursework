using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework5
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        const double PI = Math.PI;
        double th1 = 35 * Math.PI / 180;
        double th2 = 25 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        int k = 2;
        bool flag = false;
        Color orgBranch, orgLeaves;

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            //初始化颜色
            orgBranch = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            orgLeaves = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            this.AutoScaleBaseSize = new Size(6, 14);
            //this.ClientSize = new Size(400, 400);
            this.Paint += new PaintEventHandler(this.Form1_Paint);
            this.Click += new EventHandler(this.Redraw);
            

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            // 不知道这个Screen.PrimaryScreen.WorkingArea会不会在不同系统上出问题，如果出问题的话可以使用下面那行，把这个行comment掉
            drawTree(12, Screen.PrimaryScreen.WorkingArea.Bottom - 30, Screen.PrimaryScreen.WorkingArea.Height - 50, 100, -PI / 2);
            //drawTree(12, 600, 780, 100, -PI / 2);
        }
        private void Redraw(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        
        double rand()
        {
            return rnd.NextDouble();
        }

        void drawTree(int n,
                double x0, double y0, double leng, double th)
        {
            if (n == 0) return; // changed this to 2. Otherwise, it would take too long to run
            //if (leng < 5) return; // otherwise, it would take too long to run
            

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            
            double x2 = x0 + leng * k * Math.Cos(th);
            double y2 = y0 + leng * k * Math.Sin(th);

            drawLine(x0, y0, x1, y1, n);
            drawLine(x0, y0, x2, y2, n);
          

            drawTree(n - 1, x1, y1, per1 * leng * (0.5 + rand()), th + th1 * (0.5 + rand()));
            drawTree(n - 1, x2, y2, per2 * leng * (0.4 + rand()), th - th2 * (0.5 + rand()));

            if(flag == true){
                if (rand() > 0.6)
                {
                    drawTree(n - 1, x1, y1, per2 * leng * (0.4 + rand()), th - th2 * (0.5 + rand()));
                }
            }
        }

        void drawLine(double x0, double y0, double x1, double y1, int n)
        {
            int width = n / 3;
           
            if (n >= 8)
            {
                graphics.DrawLine(
                new Pen(orgBranch, (int)width),
                (int)x0, (int)y0, (int)x1, (int)y1);
            }
            else
            {
                graphics.DrawLine(
                new Pen(orgLeaves, (int)width),
               (int)x0, (int)y0, (int)x1, (int)y1);
            }
        }


        private void txtboxAngle1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                double a = double.Parse(txtboxAngle1.Text);
                txtboxAngle1.Text = "";
                th1 = a * Math.PI / 180;
            }
        }

        private void txtboxAngle2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                double b = double.Parse(txtboxAngle2.Text);
                txtboxAngle2.Text = "";
                th2 = 25 * Math.PI / 180;
            }
        }

        private void txtboxLength1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                double c = double.Parse(txtboxLength1.Text);
                txtboxLength1.Text = "";
                if (c <= 3)
                {
                    per1 = c;
                }
                else
                {
                    MessageBox.Show("请输入比3小的树，避免system overflow");
                }
                
                
            }
        }
        private void txtboxLength2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                double d = double.Parse(txtboxLength2.Text);
                txtboxLength2.Text = "";
                if (d <= 3)
                {
                    per2 = d;
                }
                else
                {
                    MessageBox.Show("请输入比3小的树，避免system overflow");
                }
            }
        }
        private void btnBranchesColor_Click(object sender, EventArgs e)
        {
            orgBranch = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void btnLeavesColor_Click(object sender, EventArgs e)
        {
            orgLeaves = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

        }

        
    }
}
