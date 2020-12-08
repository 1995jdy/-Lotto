using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int coin = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void insert1000_Click(object sender, EventArgs e)
        {
            coin += 1000;
            money.Text = coin.ToString();
            
        }

        private void insert5000_Click(object sender, EventArgs e)
        {
            coin += 5000;
            money.Text = coin.ToString();
        }

        private void insert10000_Click(object sender, EventArgs e)
        {
            coin += 10000;
            money.Text = coin.ToString();
        }

        private void outbut_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void po_Click(object sender, EventArgs e)
        {
            if (coin < 1000)
            {
                MessageBox.Show("잔액이 부족합니다.");

            }
            else
            {
                pictureBox1.Image = Properties.Resources.포카리;
                coin -= 1000;
                money.Text = coin.ToString();
            }
        }

        private void fan_Click(object sender, EventArgs e)
        {
            if (coin < 1500)
            {
                MessageBox.Show("잔액이 부족합니다.");

            }
            else
            {
                pictureBox1.Image = Properties.Resources.환타;
                coin -= 1500;
                money.Text = coin.ToString();
            }
        }

        private void power_Click(object sender, EventArgs e)
        {
            if (coin < 1700)
            {
                MessageBox.Show("잔액이 부족합니다.");

            }
            else
            {
                pictureBox1.Image = Properties.Resources.파워에이드;
                coin -= 1700;
                money.Text = coin.ToString();
            }
        }

        private void coke_Click(object sender, EventArgs e)
        {
            if (coin < 900)
            {
                MessageBox.Show("잔액이 부족합니다.");

            }
            else
            {
                pictureBox1.Image = Properties.Resources.콜라;
                coin -= 900;
                money.Text = coin.ToString();
            }
        }

        private void cider_Click(object sender, EventArgs e)
        {
            if (coin < 1200)
            {
                MessageBox.Show("잔액이 부족합니다.");

            }
            else
            {
                pictureBox1.Image = Properties.Resources.사이다;
                coin -= 1200;
                money.Text = coin.ToString();
            }
        }
    }
}
