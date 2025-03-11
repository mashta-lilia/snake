
namespace snake
{
    partial class play
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.ananas5 = new System.Windows.Forms.PictureBox();
            this.ananas10 = new System.Windows.Forms.PictureBox();
            this.gruha = new System.Windows.Forms.PictureBox();
            this.visinki = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Bonus = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ananas5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ananas10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visinki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 43);
            this.label1.TabIndex = 15;
            this.label1.Text = "  ";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Orange;
            this.player.Location = new System.Drawing.Point(467, 315);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(20, 20);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Interval = 5000;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::snake.Properties.Resources.apricot_PNG12656;
            this.pictureBox3.Location = new System.Drawing.Point(116, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "enemy";
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox20.Image = global::snake.Properties.Resources.apricot_PNG12656;
            this.pictureBox20.Location = new System.Drawing.Point(503, 635);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(35, 35);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 8;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "enemy";
            // 
            // ananas5
            // 
            this.ananas5.BackColor = System.Drawing.Color.Transparent;
            this.ananas5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ananas5.Image = global::snake.Properties.Resources.загружено_removebg_preview;
            this.ananas5.Location = new System.Drawing.Point(233, 262);
            this.ananas5.Name = "ananas5";
            this.ananas5.Size = new System.Drawing.Size(54, 84);
            this.ananas5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ananas5.TabIndex = 16;
            this.ananas5.TabStop = false;
            this.ananas5.Tag = "enemy";
            this.ananas5.Visible = false;
            // 
            // ananas10
            // 
            this.ananas10.BackColor = System.Drawing.Color.Transparent;
            this.ananas10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ananas10.Image = global::snake.Properties.Resources.png_clipart_apple_desktop_fruit_apple_juice_food_fruit_removebg_preview;
            this.ananas10.Location = new System.Drawing.Point(590, 528);
            this.ananas10.Name = "ananas10";
            this.ananas10.Size = new System.Drawing.Size(119, 84);
            this.ananas10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ananas10.TabIndex = 17;
            this.ananas10.TabStop = false;
            this.ananas10.Tag = "enemy";
            this.ananas10.Visible = false;
            // 
            // gruha
            // 
            this.gruha.BackColor = System.Drawing.Color.Transparent;
            this.gruha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gruha.Image = global::snake.Properties.Resources.grusha;
            this.gruha.Location = new System.Drawing.Point(828, 512);
            this.gruha.Name = "gruha";
            this.gruha.Size = new System.Drawing.Size(61, 70);
            this.gruha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gruha.TabIndex = 18;
            this.gruha.TabStop = false;
            this.gruha.Tag = "enemy";
            this.gruha.Visible = false;
            // 
            // visinki
            // 
            this.visinki.BackColor = System.Drawing.Color.Transparent;
            this.visinki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.visinki.Image = global::snake.Properties.Resources._0dfdfaa60987b81d017026c3348dbe7c;
            this.visinki.Location = new System.Drawing.Point(382, 497);
            this.visinki.Name = "visinki";
            this.visinki.Size = new System.Drawing.Size(61, 101);
            this.visinki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.visinki.TabIndex = 19;
            this.visinki.TabStop = false;
            this.visinki.Tag = "enemy";
            this.visinki.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::snake.Properties.Resources.apricot_PNG12656;
            this.pictureBox1.Location = new System.Drawing.Point(844, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "enemy";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::snake.Properties.Resources.apricot_PNG12656;
            this.pictureBox2.Location = new System.Drawing.Point(473, 342);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "enemy";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Image = global::snake.Properties.Resources.apricot_PNG12656;
            this.pictureBox4.Location = new System.Drawing.Point(60, 577);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "enemy";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Image = global::snake.Properties.Resources.apricot_PNG12656;
            this.pictureBox5.Location = new System.Drawing.Point(514, 69);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "enemy";
            // 
            // Bonus
            // 
            this.Bonus.Interval = 1000;
            this.Bonus.Tick += new System.EventHandler(this.Bonus_Tick);
            // 
            // play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::snake.Properties.Resources._1614135185_11_p_fon_dlya_igri_zmeika_12;
            this.ClientSize = new System.Drawing.Size(981, 718);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.visinki);
            this.Controls.Add(this.gruha);
            this.Controls.Add(this.ananas10);
            this.Controls.Add(this.ananas5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.player);
            this.Name = "play";
            this.Text = "play";
            this.Load += new System.EventHandler(this.play_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.play_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ananas5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ananas10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visinki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Random;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox ananas5;
        private System.Windows.Forms.PictureBox ananas10;
        private System.Windows.Forms.PictureBox gruha;
        private System.Windows.Forms.PictureBox visinki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer Bonus;
    }
}