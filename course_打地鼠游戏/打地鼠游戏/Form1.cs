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
        int RandomBox;
        int HitTimes = 0;
        int[] changed = new int[25] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };//用以指标图片是否改变,相当于bool值
        Bitmap bm1 = (Bitmap)Image.FromFile(@"c1.gif");
        Bitmap bm2 = (Bitmap)Image.FromFile(@"c2.gif");

        private void Form1_Load(object sender, EventArgs e)
        {

            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            for (int x1 = 0; x1 < 25; x1++)
            {
                // images[2] is the soil one without any mole popping out
                map[x1].Image = imageList1.Images[2];//加载背景图片
            }


        }
        
        public void StartTimers()
        {
            timerMoleAppear.Start();
            timerMoleReturn.Start();
        }
        public void StopTimers()
        {
            timerMoleAppear.Stop();
            timerMoleReturn.Stop();
        }
        public void SetTimers(int x)
        {
            timerMoleAppear.Interval = x;
            timerMoleReturn.Interval = x;
        }
        private void labelStart_Click(object sender, EventArgs e)
        {
            SetTimers(1000);
            StartTimers(); //触发timer,游戏开始
            if (HitTimes >= 10 && HitTimes < 20)
            {
                SetTimers(500);
                StartTimers();
                if (HitTimes >= 20 && HitTimes < 30)
                {
                    StopTimers();
                    SetTimers(100);
                    StartTimers();
                    if (HitTimes >= 30)
                    {
                        StopTimers();
                        SetTimers(10);
                        StartTimers();
                    }
                }
            }
        }

        // for the mole to appear
        private void timerMoleAppear_Tick(object sender, EventArgs e)
        {
            Cursor = new Cursor(@"c1.cur");//娈换鼠标指针
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            Random rnd = new Random();
            RandomBox = rnd.Next(25);
            map[RandomBox].Image = imageList1.Images[3];
            changed[RandomBox] = 1;//批示图片已变
            labelLevel.Text = "第" + (HitTimes - HitTimes % 10) / 10 + "关";
        }

        // for the mole to return back to the hole
        private void timerMoleReturn_Tick(object sender, EventArgs e)
        {
            
            PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            // Images[2] is the soil
            map[RandomBox].Image = imageList1.Images[2];
            changed[RandomBox] = 0;
        }
        public void MoleClicked(int BoxNumber)
        {
            try
            {
                Cursor = new Cursor(bm2.GetHicon());
                PictureBox[] map = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
                if (changed[RandomBox] == 1 && RandomBox == BoxNumber)
                {
                    map[RandomBox].Image = imageList1.Images[4];
                    HitTimes++;
                    labelHitTimes.Text = HitTimes.ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.ToString());
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(0);
            
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(1);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(2);
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(3);
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(4);
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(5);
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(6);
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(7);
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(8);
        }

        private void pictureBox10_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(9);
        }

        private void pictureBox11_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(10);
        }

        private void pictureBox12_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(11);
        }

        private void pictureBox13_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(12);
        }

        private void pictureBox14_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(13);
        }

        private void pictureBox15_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(14);
        }

        private void pictureBox16_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(15);
        }

        private void pictureBox17_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(16);
        }

        private void pictureBox18_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(17);
        }
        private void pictureBox19_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(18);
        }

        private void pictureBox20_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(19);
        }

        
        private void pictureBox21_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(20);
        }

        private void pictureBox22_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(21);
        }

        private void pictureBox23_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(22);
        }

        private void pictureBox24_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(23);
        }

        private void pictureBox25_MouseDown(object sender, MouseEventArgs e)
        {
            MoleClicked(24);
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

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}