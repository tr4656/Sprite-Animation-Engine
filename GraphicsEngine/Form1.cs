using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Threading;

namespace GraphicsEngine
{
    public partial class Form1 : Form
    {
        
        Image[] dude = new Image[3];
        
        static int renderpoint = 0;

        bool beginrendering = false;

        int lastimage = 0; int speed = 10;
        static double FPS = 10;

        long ticks1 = 0;
        long ticks2 = 0;
        

        public Form1()
        {
           this.DoubleBuffered = true;

            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MainLoop();
        }

        private void MainLoop()
        {

            double interval = (double)Stopwatch.Frequency / FPS;
                ticks2 = Stopwatch.GetTimestamp();
                if (ticks2 >= ticks1 + interval)
                {
                    ticks1 = Stopwatch.GetTimestamp();

                    if (beginrendering == true)
                    {
                        MoveGraphics();
                        this.Refresh();
                    }
                }

                 
                
            
        }

        void MoveGraphics()
        {
            if (renderpoint > 950)
            {
                renderpoint = 0;
            }

            else
            {
                renderpoint += speed;
            }
        }

        private void pboxPlayground_Paint(object sender, PaintEventArgs e)
        {

            if (beginrendering == true)
            {
                Graphics g = e.Graphics;
                Rectangle rect = new Rectangle(renderpoint, 0, (dude[0].Width * 2), (dude[0].Height * 2));
                Color lowcolor = Color.FromArgb(0, 128, 64);
                Color highcolor = Color.FromArgb(0, 128, 64);

                ImageAttributes imageAttr = new ImageAttributes();
                imageAttr.SetColorKey(lowcolor, highcolor);

                g.DrawImage(dude[0], rect, 0, 0, 100, 100, GraphicsUnit.Pixel, imageAttr);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadAnim_Click(object sender, EventArgs e)
        {
            string path = txtboxAnimPath.Text;
            txtboxAnimPath.Clear();

            dude[0] = new Bitmap(path);
            pboxPlayground.Show();
            beginrendering = true;
            tmrRender.Start();
        }

        private void btnRemAnim_Click(object sender, EventArgs e)
        {
            beginrendering = false;
            dude[0] = null;
            pboxPlayground.Hide();
        }

        private void btnUseSet_Click(object sender, EventArgs e)
        {
            speed = Convert.ToInt32(txtbooxSpeed.Text);
            FPS = Convert.ToInt32(txtboxFPS.Text);
        }

        private void tmrRender_Tick(object sender, EventArgs e)
        {
            MainLoop();
        }
    }
}
