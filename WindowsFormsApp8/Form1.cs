using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Drawing;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private int counter;
        int IDK = 0;
        int forsec = 1;
        int click = 0;
        int forclick = 1;
        int money = 0;
        int price = 5;
        int Time = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeTimer()
        {
            counter = 0;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.White;
        }

        public void button2_Click(object sender, EventArgs e)
        {
                money = money + forclick;
                click++;
                textBox1.Text = "Клики: " + click;
                textBox4.Text = "Деньги: " + money;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (money >= price)
            {
                forclick = forclick * 2;
                money = money - price;
                price = price * 3;
                textBox3.Text = "Цена: " + price;
                textBox2.Text = "За клик: " + forclick;
                textBox4.Text = "Деньги: " + money;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = System.Drawing.Color.LightGray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.White;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = System.Drawing.Color.LightGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.White;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = System.Drawing.Color.LightGray;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.Color.White;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyData == Keys.Control)
                {
                MessageBox.Show("Test");
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
