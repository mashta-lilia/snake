using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class shop : Form
    {
        private menu menu;

        public shop(menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            menu.PurcheasedBG = pictureBox4.Image;
            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            menu.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            menu.PurcheasedBG = pictureBox5.Image;
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            menu.PurcheasedBG = pictureBox6.Image;
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            menu.PurcheasedBG = pictureBox7.Image;
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            menu.PurcheasedBG = pictureBox8.Image;
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            menu.PurcheasedBG = pictureBox9.Image;
            this.Close();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            menu.PurcheasedGruha50 = true;
            this.Close();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            menu.Purcheasedvisinki10 = true;
            this.Close();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            menu.Purcheasedananas = true;
            this.Close();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            menu.Purcheasedapple = true;
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            menu.snakecolor = pictureBox10.BackColor;
            this.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            menu.snakecolor = pictureBox11.BackColor;
            this.Close();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            menu.snakecolor = pictureBox12.BackColor;
            this.Close();


        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            menu.snakecolor = pictureBox15.BackColor;
            this.Close();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            menu.snakecolor = pictureBox14.BackColor;
            this.Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            menu.snakecolor = pictureBox13.BackColor;
            this.Close();
        }
    }
}
