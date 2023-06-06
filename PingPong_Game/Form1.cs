using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer3.Enabled = true;
            timer5.Enabled = true;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = lblOyuncu1.Location.X;
            int y = lblOyuncu1.Location.Y;

            if(e.KeyCode==Keys.W)
            {
                y = y - 20;
                lblOyuncu1.Location = new Point(x, y);

            }
            if(e.KeyCode==Keys.S)
            {
                y = y + 20;
                lblOyuncu1.Location = new Point(x, y);
            }//Birinci oyuncu hareketi


            int u = lblOyuncu2.Location.X;
            int ı = lblOyuncu2.Location.Y;

            if(e.KeyCode==Keys.Up)
            {
                ı = ı - 20;
                lblOyuncu2.Location = new Point(u, ı);
            }
            if(e.KeyCode==Keys.Down)
            {
                ı = ı + 20;
                lblOyuncu2.Location = new Point(u, ı);
            }
            //İkinci oyuncu hareketi
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int top1 = r.Next(10, 15);
            pictureBox1.Left = pictureBox1.Left + top1;

            if(lblOyuncu2.Bottom >= pictureBox1.Top && lblOyuncu2.Top <= pictureBox1.Bottom && lblOyuncu2.Right >= pictureBox1.Left && lblOyuncu2.Left <= pictureBox1.Right)
            {
                timer1.Enabled = false; timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int top1 = r.Next(10, 15);
            pictureBox1.Left = pictureBox1.Left + top1;

            if(lblOyuncu1.Top <= pictureBox1.Bottom && lblOyuncu1.Bottom >= pictureBox1.Top && lblOyuncu1.Left <= pictureBox1.Right && lblOyuncu1.Right >= pictureBox1.Left)
            {
                timer2.Enabled = false; timer1.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int top1 = r.Next(10, 15);
            pictureBox1.Top = pictureBox1.Top + top1;

            if(pictureBox1.Bottom > lblAlt.Top)
            {
                timer3.Enabled = false; timer4.Enabled = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int top1 = r.Next(10, 15);
            pictureBox1.Top = pictureBox1.Top - top1;

            if (pictureBox1.Top < lblUst.Bottom)
            {
                timer4.Enabled = false; timer3.Enabled = true;
            }
                
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left <= lblSol.Right)
            {
                timer5.Enabled = false;
                pictureBox1.Visible = false;
                MessageBox.Show("2. oyuncu kazandı");
            }
            if(pictureBox1.Right >= lblSag.Left)
            {
                timer5.Enabled = false;
                pictureBox1.Visible = false;
                MessageBox.Show("1.oyuncu kazandı");

            }
        }
    }
}
