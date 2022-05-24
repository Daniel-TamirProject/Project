
namespace MainProject
{
    partial class Game
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
            this.animalCounter = new System.Windows.Forms.Label();
            this.animal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.milkBar = new System.Windows.Forms.ProgressBar();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.plantCounter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eggsBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.cornBar = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.appleBar = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.treePic = new System.Windows.Forms.PictureBox();
            this.cornPic = new System.Windows.Forms.PictureBox();
            this.ChickenPic = new System.Windows.Forms.PictureBox();
            this.CowPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.coins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.treePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cornPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChickenPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CowPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // animalCounter
            // 
            this.animalCounter.AutoSize = true;
            this.animalCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalCounter.Location = new System.Drawing.Point(15, 497);
            this.animalCounter.Name = "animalCounter";
            this.animalCounter.Size = new System.Drawing.Size(104, 25);
            this.animalCounter.TabIndex = 2;
            this.animalCounter.Text = "Animals: 0";
            // 
            // animal
            // 
            this.animal.AutoSize = true;
            this.animal.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animal.Location = new System.Drawing.Point(964, -1);
            this.animal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.animal.Name = "animal";
            this.animal.Size = new System.Drawing.Size(87, 27);
            this.animal.TabIndex = 6;
            this.animal.Text = "Animals";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label1.Location = new System.Drawing.Point(971, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Plants";
            // 
            // milkBar
            // 
            this.milkBar.Location = new System.Drawing.Point(189, 522);
            this.milkBar.Margin = new System.Windows.Forms.Padding(4);
            this.milkBar.Name = "milkBar";
            this.milkBar.Size = new System.Drawing.Size(123, 28);
            this.milkBar.TabIndex = 11;
            // 
            // Savebtn
            // 
            this.Savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.Location = new System.Drawing.Point(965, 345);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(89, 37);
            this.Savebtn.TabIndex = 13;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loadbtn
            // 
            this.Loadbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Loadbtn.Location = new System.Drawing.Point(965, 389);
            this.Loadbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(89, 36);
            this.Loadbtn.TabIndex = 14;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // plantCounter
            // 
            this.plantCounter.AutoSize = true;
            this.plantCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plantCounter.Location = new System.Drawing.Point(16, 522);
            this.plantCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plantCounter.Name = "plantCounter";
            this.plantCounter.Size = new System.Drawing.Size(88, 25);
            this.plantCounter.TabIndex = 15;
            this.plantCounter.Text = "Plants: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(228, 494);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Milk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(349, 494);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Eggs";
            // 
            // eggsBar
            // 
            this.eggsBar.Location = new System.Drawing.Point(320, 522);
            this.eggsBar.Margin = new System.Windows.Forms.Padding(4);
            this.eggsBar.Name = "eggsBar";
            this.eggsBar.Size = new System.Drawing.Size(123, 28);
            this.eggsBar.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(756, 497);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Corns";
            // 
            // cornBar
            // 
            this.cornBar.Location = new System.Drawing.Point(732, 522);
            this.cornBar.Margin = new System.Windows.Forms.Padding(4);
            this.cornBar.Name = "cornBar";
            this.cornBar.Size = new System.Drawing.Size(123, 28);
            this.cornBar.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(625, 497);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Apples";
            // 
            // appleBar
            // 
            this.appleBar.Location = new System.Drawing.Point(601, 522);
            this.appleBar.Margin = new System.Windows.Forms.Padding(4);
            this.appleBar.Name = "appleBar";
            this.appleBar.Size = new System.Drawing.Size(123, 28);
            this.appleBar.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(951, 511);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 23;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // treePic
            // 
            this.treePic.BackColor = System.Drawing.Color.Transparent;
            this.treePic.Image = global::MainProject.Properties.Resources.tree_removebg_preview;
            this.treePic.Location = new System.Drawing.Point(976, 206);
            this.treePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treePic.Name = "treePic";
            this.treePic.Size = new System.Drawing.Size(63, 48);
            this.treePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treePic.TabIndex = 9;
            this.treePic.TabStop = false;
            this.treePic.Click += new System.EventHandler(this.treePic_Click);
            // 
            // cornPic
            // 
            this.cornPic.BackColor = System.Drawing.Color.Transparent;
            this.cornPic.Image = global::MainProject.Properties.Resources.adama_removebg_preview1;
            this.cornPic.Location = new System.Drawing.Point(976, 276);
            this.cornPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cornPic.Name = "cornPic";
            this.cornPic.Size = new System.Drawing.Size(63, 48);
            this.cornPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cornPic.TabIndex = 8;
            this.cornPic.TabStop = false;
            this.cornPic.Click += new System.EventHandler(this.cornPic_Click_1);
            // 
            // ChickenPic
            // 
            this.ChickenPic.BackColor = System.Drawing.Color.Transparent;
            this.ChickenPic.Image = global::MainProject.Properties.Resources.chicken2_removebg_preview1;
            this.ChickenPic.Location = new System.Drawing.Point(976, 98);
            this.ChickenPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChickenPic.Name = "ChickenPic";
            this.ChickenPic.Size = new System.Drawing.Size(63, 52);
            this.ChickenPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChickenPic.TabIndex = 4;
            this.ChickenPic.TabStop = false;
            this.ChickenPic.Click += new System.EventHandler(this.ChickenPic_Click);
            // 
            // CowPic
            // 
            this.CowPic.BackColor = System.Drawing.Color.Transparent;
            this.CowPic.Image = global::MainProject.Properties.Resources.cow2_removebg_preview1;
            this.CowPic.Location = new System.Drawing.Point(976, 28);
            this.CowPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CowPic.Name = "CowPic";
            this.CowPic.Size = new System.Drawing.Size(63, 54);
            this.CowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CowPic.TabIndex = 3;
            this.CowPic.TabStop = false;
            this.CowPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::MainProject.Properties.Resources.backGround2;
            this.pictureBox1.Image = global::MainProject.Properties.Resources.backGround2;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(945, 492);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // coins
            // 
            this.coins.AutoSize = true;
            this.coins.Location = new System.Drawing.Point(523, 522);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(16, 17);
            this.coins.TabIndex = 24;
            this.coins.Text = "0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.coins);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cornBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.appleBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eggsBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plantCounter);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.milkBar);
            this.Controls.Add(this.treePic);
            this.Controls.Add(this.cornPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.animal);
            this.Controls.Add(this.ChickenPic);
            this.Controls.Add(this.CowPic);
            this.Controls.Add(this.animalCounter);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.treePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cornPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChickenPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CowPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label animalCounter;
        private System.Windows.Forms.PictureBox CowPic;
        private System.Windows.Forms.PictureBox ChickenPic;
        private System.Windows.Forms.Label animal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox cornPic;
        private System.Windows.Forms.PictureBox treePic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar milkBar;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Label plantCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar eggsBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar cornBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar appleBar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label coins;
    }
}