using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 打地鼠游戏
{
    public partial class Form1 : Form
    {
            public Form1()
        {
            InitializeComponent();
        }

        static PictureBox[] map = new PictureBox[25];
        int i1;
        int i2 = 0;
        int[] bian = new int[25] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};//用以指标图片是否改变,相当于bool值
        Bitmap bm1 = (Bitmap)Image.FromFile(@"c1.gif");
        Bitmap bm2 = (Bitmap)Image.FromFile(@"c2.gif");

        private void Form1_Load(object sender, EventArgs e)
        {
                       
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };           
            for (int x1 = 0; x1<25; x1++)
            {
                map[x1].Image = imageList1.Images[2];//加载背景图片
            }

                
        }

        private void label5_Click(object sender, EventArgs e)
        {

            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer1.Start();//触发timer,游戏开始
            timer2.Start(); 
           // label3.Text = "第" + (i2 - i2 % 10) / 10 + "关";
            if (i2 >= 10 && i2 < 20)
            {
                timer1.Interval = 500;//
                timer2.Interval = 500;
                timer1.Start();
                timer2.Start();
                if (i2 >= 20 && i2 < 30)
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer1.Interval = 100;
                    timer2.Interval = 100;
                    timer1.Start();
                    timer2.Start();

                    if (i2 >= 30)
                    {
                        timer1.Stop();
                        timer2.Stop();
                        timer1.Interval = 10;
                        timer2.Interval = 10;
                        timer1.Start();
                        timer2.Start();

                    }
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor = new Cursor(@"c1.cur");//娈换鼠标指针
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };           
            Random i = new Random();
            i1 = i.Next(25);
            map[i1].Image = imageList1.Images[3];
            bian[i1] = 1;//批示图片已变
            label3.Text = "第" + (i2 - i2 % 10) / 10 + "关";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            map[i1].Image = imageList1.Images[2];
            bian[i1] = 0;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1&&i1==0)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
            
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 1)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 2)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 3)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 4)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 5)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 6)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 7)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 8)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox10_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 9)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox11_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 10)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox12_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 11)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox13_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 12)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox14_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 13)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox15_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 14)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox16_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 15)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox17_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 16)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox18_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 17)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox20_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 19)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox19_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 18)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox21_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 20)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox22_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 21)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox23_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 22)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox24_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon()); 
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 23)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox25_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm2.GetHicon());
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            if (bian[i1] == 1 && i1 == 24)
            {
                map[i1].Image = imageList1.Images[4];
                i2++;
                label2.Text = i2.ToString();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox9_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox10_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox11_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox12_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox13_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox14_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox15_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox16_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox17_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox18_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox19_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox20_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox21_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox22_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox23_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox24_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void pictureBox25_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(bm1.GetHicon());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        

       

      



     

 
    }
}