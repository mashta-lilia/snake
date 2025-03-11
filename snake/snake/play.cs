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
    public partial class play : Form
    {
        public play(menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            playerTop = ClientSize.Height / 2;
            playerLeft = ClientSize.Width  / 2;
            if (menu.PurcheasedBG != null )
            {
                this.BackgroundImage = menu.PurcheasedBG;
                Bonus.Start();
            }
            if (menu.PurcheasedGruha50  == true)
            {

                gruha.Visible = true;
                Bonus.Start();
            }
            if (menu.Purcheasedapple == true)
            {
                ananas10.Visible = true;

                Bonus.Start();
            }
            if (menu.Purcheasedananas == true)
            {
                ananas5.Visible = true;
                Bonus.Start();
            }
            if (menu.Purcheasedvisinki10 == true)
            {
                visinki.Visible = true;
                Bonus.Start();
            }
        } 

        Random rnd = new Random();
        private menu menu;
        List<PictureBox> snakeTail = new List<PictureBox>();
        int snakeLengs = 12;

        bool moveUp = true;
        bool moveDown = false;
        bool moveLeft = false;
        bool moveRight = false;
        int speed = 22;
        int score = 0;
        int time = 0;
        int playerTop = 0;
        int playerLeft = 0;
        int Bonustimer = 1;
        private void play_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        

        

        private void play_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && moveRight == false)
            {
                
                
                
                moveLeft = true;
                moveUp = false;
                moveDown = false;                
                moveRight = false;


            }
            if (e.KeyCode == Keys.Right && moveLeft == false )
            {
                moveRight = true;
                moveUp = false;
                moveDown = false;
                moveLeft = false;
                
            }
            if (e.KeyCode == Keys.Up && moveDown == false )
            {
                moveUp = true;                
                moveDown = false;
                moveLeft = false;
                moveRight = false;
            }
            if (e.KeyCode == Keys.Down && moveUp == false)
            {
                moveDown = true;
                moveUp = false;                
                moveLeft = false;
                moveRight = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            if (moveUp == true && playerTop > 0)
            {
                playerTop -= speed;


            }
            if (moveDown == true && playerTop < this.ClientSize.Height - player.Height)
            {
                playerTop += speed;
            }
            if (moveLeft == true && playerLeft > 0)
            {
                playerLeft -= speed;
            }
            if (moveRight == true && playerLeft < this.ClientSize.Width - player.Width)
            {
                playerLeft += speed;
            }
            bool enemyhit = false;
            player.Left = playerLeft;
            player.Top = playerTop;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        //speed += 1;
                        
                        score++;
                        

                        enemyhit = true;

                        snakeLengs += 1;

                        if (x.Name == "ananas5")
                        {                           
                            snakeLengs -= 5;                            
                        }
                        if (x.Name == "ananas10")
                        {
                            snakeLengs -= 10;
                        }
                        if (x.Name == "gruha")
                        {
                            score += 50;
                        }
                        if (x.Name == "visinki")
                        {
                            score += 10;
                        }
                        label1.Text = "Score : " + score.ToString();
                        break;
                    }
                    
                }
                if (playerLeft > this.ClientSize.Width || playerLeft <= 0
                || playerTop > this.ClientSize.Height || playerTop <= 0 )
                {
                    timer1.Stop();

                    Lost lost = new Lost();
                    lost.Show();
                    
                    this.Close();
                    break;
                    
                }
                if (x is PictureBox && x.Tag == "snh")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {


                        timer1.Stop();

                        Lost lost = new Lost();
                        lost.Show();

                        this.Close();
                        break;


                    }

                }







            }
            if (enemyhit == true)
            {
                PictureBox enemy = new PictureBox();
                enemy.Image = Properties.Resources.apricot_PNG12656;
                enemy.Left = rnd.Next(90, this.ClientSize.Width - 90);
                enemy.Top = rnd.Next(90, this.ClientSize.Height - 90);
                enemy.Width = 35;
                enemy.Height = 35;
                enemy.Tag = "enemy";
                enemy.SizeMode = PictureBoxSizeMode.StretchImage;
                enemy.BackColor = System.Drawing.Color.Transparent;
                this.Controls.Add(enemy);
            }
            
            PictureBox snh = new PictureBox();

            snh.BackColor = menu.snakecolor ;
            snh.Left = playerLeft ;
            snh.Top = playerTop ;
            snh.Width = 20;
            snh.Height = 20;
            snh.Tag = "snh";
            snh.SizeMode = PictureBoxSizeMode.StretchImage;
            //snh.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(snh);
            snakeTail.Add(snh);

            if (snakeTail.Count >= snakeLengs )
            {
                var tail = snakeTail.Take(snakeTail.Count - snakeLengs);

                foreach (var item in tail)
                {
                    this.Controls.Remove(item);
                }

               
                snakeTail.RemoveAll( x => tail.Contains(x));
                

            }

        }


        private void Random_Tick(object sender, EventArgs e)
        {                        
            PictureBox enemy = new PictureBox();
            enemy.Image = Properties.Resources.apricot_PNG12656;
            enemy.Left = rnd.Next(90, this.ClientSize.Width - 90);
            enemy.Top  = rnd.Next(90, this.ClientSize.Height - 90);
            enemy.Width = 35;
            enemy.Height = 35;
            enemy.Tag = "enemy";
            enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(enemy);

                

            
            
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.menu.Visible = true;
        }

        private void Bonus_Tick(object sender, EventArgs e)
        {
            if (menu.Purcheasedapple == true && (Bonustimer % 10==0))
            { 
                ananas10.Visible = true;
                ananas10.Left = rnd.Next(70, this.ClientSize.Width - 70);
                ananas10.Top = rnd.Next(50, this.ClientSize.Height - 50);
            }

            if (menu.Purcheasedananas == true && (Bonustimer % 12 == 0))
            { 
                ananas5.Visible = true;
                ananas5.Left = rnd.Next(70, this.ClientSize.Width - 70);
                ananas5.Top = rnd.Next(50, this.ClientSize.Height - 50);           
            }
            if (menu.PurcheasedGruha50 == true && (Bonustimer % 5 == 0))
            {
                gruha.Visible = true;
                gruha.Left = rnd.Next(70, this.ClientSize.Width - 70);
                gruha.Top = rnd.Next(50, this.ClientSize.Height - 50);
            }
            if (menu.Purcheasedvisinki10 == true && (Bonustimer % 7 == 0))
            {
                visinki.Visible = true;
                visinki.Left = rnd.Next(70, this.ClientSize.Width - 70);
                visinki.Top = rnd.Next(50, this.ClientSize.Height - 50);
            }
            Bonustimer++;



        }
    }
}
