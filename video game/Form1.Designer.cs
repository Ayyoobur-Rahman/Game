namespace class_video_game
{
    partial class Form1
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
            this.player = new System.Windows.Forms.PictureBox();
            this.platform = new System.Windows.Forms.PictureBox();
            this.VerticalPlatform = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtscore = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.enemyone = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Door2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door2)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::class_video_game.Properties.Resources.rigby__rrw_;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(135, 390);
            this.player.Margin = new System.Windows.Forms.Padding(2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(59, 61);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.Transparent;
            this.platform.BackgroundImage = global::class_video_game.Properties.Resources.grass1;
            this.platform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.platform.Location = new System.Drawing.Point(342, 298);
            this.platform.Margin = new System.Windows.Forms.Padding(2);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(181, 64);
            this.platform.TabIndex = 1;
            this.platform.TabStop = false;
            this.platform.Tag = "platform";
            // 
            // VerticalPlatform
            // 
            this.VerticalPlatform.BackColor = System.Drawing.Color.Transparent;
            this.VerticalPlatform.BackgroundImage = global::class_video_game.Properties.Resources.grass2;
            this.VerticalPlatform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VerticalPlatform.Location = new System.Drawing.Point(583, 312);
            this.VerticalPlatform.Margin = new System.Windows.Forms.Padding(2);
            this.VerticalPlatform.Name = "VerticalPlatform";
            this.VerticalPlatform.Size = new System.Drawing.Size(149, 50);
            this.VerticalPlatform.TabIndex = 2;
            this.VerticalPlatform.TabStop = false;
            this.VerticalPlatform.Tag = "platform";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::class_video_game.Properties.Resources.game_platform_grass_icon_flat_style_vector_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::class_video_game.Properties.Resources.grass1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 457);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(841, 97);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.Location = new System.Drawing.Point(817, 35);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(35, 13);
            this.txtscore.TabIndex = 4;
            this.txtscore.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::class_video_game.Properties.Resources.coin_1_removebg_preview1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(364, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "coin";
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.Transparent;
            this.door.BackgroundImage = global::class_video_game.Properties.Resources.j_g_quintel_regular_show_tv_tropes_television_show_human_body_television_fan_art_finger_fiction_organ_removebg_preview;
            this.door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door.Location = new System.Drawing.Point(830, 77);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(84, 100);
            this.door.TabIndex = 6;
            this.door.TabStop = false;
            // 
            // enemyone
            // 
            this.enemyone.BackColor = System.Drawing.Color.Transparent;
            this.enemyone.BackgroundImage = global::class_video_game.Properties.Resources.images_removebg_preview;
            this.enemyone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemyone.Location = new System.Drawing.Point(-2, 417);
            this.enemyone.Name = "enemyone";
            this.enemyone.Size = new System.Drawing.Size(55, 34);
            this.enemyone.TabIndex = 7;
            this.enemyone.TabStop = false;
            this.enemyone.Tag = "enemy";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(597, 239);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "coinmultipler";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox4.Location = new System.Drawing.Point(217, 417);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 34);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "speedboost";
            // 
            // Door2
            // 
            this.Door2.BackColor = System.Drawing.Color.Transparent;
            this.Door2.BackgroundImage = global::class_video_game.Properties.Resources.muscleman_removebg_preview;
            this.Door2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Door2.Location = new System.Drawing.Point(734, 339);
            this.Door2.Name = "Door2";
            this.Door2.Size = new System.Drawing.Size(180, 112);
            this.Door2.TabIndex = 10;
            this.Door2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::class_video_game.Properties.Resources.park_pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1318, 555);
            this.Controls.Add(this.Door2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.enemyone);
            this.Controls.Add(this.door);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VerticalPlatform);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.player);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.PictureBox VerticalPlatform;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox enemyone;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Door2;
    }
}

