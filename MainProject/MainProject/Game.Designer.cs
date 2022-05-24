﻿
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.plantCounter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.treePic = new System.Windows.Forms.PictureBox();
            this.adamaPic = new System.Windows.Forms.PictureBox();
            this.ChickenPic = new System.Windows.Forms.PictureBox();
            this.CowPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adamaPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChickenPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CowPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // animalCounter
            // 
            this.animalCounter.AutoSize = true;
            this.animalCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalCounter.Location = new System.Drawing.Point(11, 404);
            this.animalCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.animalCounter.Name = "animalCounter";
            this.animalCounter.Size = new System.Drawing.Size(82, 20);
            this.animalCounter.TabIndex = 2;
            this.animalCounter.Text = "Animals: 0";
            // 
            // animal
            // 
            this.animal.AutoSize = true;
            this.animal.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animal.Location = new System.Drawing.Point(723, -1);
            this.animal.Name = "animal";
            this.animal.Size = new System.Drawing.Size(70, 21);
            this.animal.TabIndex = 6;
            this.animal.Text = "Animals";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label1.Location = new System.Drawing.Point(728, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Plants";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(142, 424);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(92, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // Savebtn
            // 
            this.Savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.Location = new System.Drawing.Point(724, 280);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(67, 30);
            this.Savebtn.TabIndex = 13;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loadbtn
            // 
            this.Loadbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Loadbtn.Location = new System.Drawing.Point(724, 316);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(67, 29);
            this.Loadbtn.TabIndex = 14;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // plantCounter
            // 
            this.plantCounter.AutoSize = true;
            this.plantCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plantCounter.Location = new System.Drawing.Point(12, 424);
            this.plantCounter.Name = "plantCounter";
            this.plantCounter.Size = new System.Drawing.Size(70, 20);
            this.plantCounter.TabIndex = 15;
            this.plantCounter.Text = "Plants: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(171, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Milk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(262, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Eggs";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(240, 424);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(92, 23);
            this.progressBar2.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(567, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Corns";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(549, 424);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(92, 23);
            this.progressBar3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(469, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Apples";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(451, 424);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(92, 23);
            this.progressBar4.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // treePic
            // 
            this.treePic.BackColor = System.Drawing.Color.Transparent;
            this.treePic.Image = global::MainProject.Properties.Resources.tree_removebg_preview;
            this.treePic.Location = new System.Drawing.Point(732, 167);
            this.treePic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treePic.Name = "treePic";
            this.treePic.Size = new System.Drawing.Size(47, 39);
            this.treePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treePic.TabIndex = 9;
            this.treePic.TabStop = false;
            this.treePic.Click += new System.EventHandler(this.treePic_Click);
            // 
            // adamaPic
            // 
            this.adamaPic.BackColor = System.Drawing.Color.Transparent;
            this.adamaPic.Image = global::MainProject.Properties.Resources.adama_removebg_preview1;
            this.adamaPic.Location = new System.Drawing.Point(732, 224);
            this.adamaPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adamaPic.Name = "adamaPic";
            this.adamaPic.Size = new System.Drawing.Size(47, 39);
            this.adamaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adamaPic.TabIndex = 8;
            this.adamaPic.TabStop = false;
            this.adamaPic.Click += new System.EventHandler(this.adamaPic_Click);
            // 
            // ChickenPic
            // 
            this.ChickenPic.BackColor = System.Drawing.Color.Transparent;
            this.ChickenPic.Image = global::MainProject.Properties.Resources.chicken2_removebg_preview1;
            this.ChickenPic.Location = new System.Drawing.Point(732, 80);
            this.ChickenPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChickenPic.Name = "ChickenPic";
            this.ChickenPic.Size = new System.Drawing.Size(47, 42);
            this.ChickenPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChickenPic.TabIndex = 4;
            this.ChickenPic.TabStop = false;
            this.ChickenPic.Click += new System.EventHandler(this.ChickenPic_Click);
            // 
            // CowPic
            // 
            this.CowPic.BackColor = System.Drawing.Color.Transparent;
            this.CowPic.Image = global::MainProject.Properties.Resources.cow2_removebg_preview1;
            this.CowPic.Location = new System.Drawing.Point(732, 23);
            this.CowPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CowPic.Name = "CowPic";
            this.CowPic.Size = new System.Drawing.Size(47, 44);
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
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(709, 400);
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
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plantCounter);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.treePic);
            this.Controls.Add(this.adamaPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.animal);
            this.Controls.Add(this.ChickenPic);
            this.Controls.Add(this.CowPic);
            this.Controls.Add(this.animalCounter);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.treePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adamaPic)).EndInit();
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
        private System.Windows.Forms.PictureBox adamaPic;
        private System.Windows.Forms.PictureBox treePic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Label plantCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}