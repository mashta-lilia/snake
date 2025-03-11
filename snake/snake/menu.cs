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
    public partial class menu : Form
    {
        public Image PurcheasedBG;
        internal bool PurcheasedGruha50;
        internal bool Purcheasedvisinki10;
        internal bool Purcheasedananas;
        internal bool Purcheasedapple;
        internal Color snakecolor = Color.Lime;

        public menu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            play play = new play(this);
            play.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {


            this.Visible = false;

            rules Rules = new rules(this);
            Rules.Show();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            shop shop = new shop(this);
            shop.Show();
        }
    }
}
