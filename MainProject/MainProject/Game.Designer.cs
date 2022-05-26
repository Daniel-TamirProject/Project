
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.coins = new System.Windows.Forms.Label();
            this.LeftBorder = new System.Windows.Forms.PictureBox();
            this.RightBorder = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.treePic = new System.Windows.Forms.PictureBox();
            this.cornPic = new System.Windows.Forms.PictureBox();
            this.ChickenPic = new System.Windows.Forms.PictureBox();
            this.CowPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cornPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChickenPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CowPic)).BeginInit();
            this.SuspendLayout();
            // 
            // animalCounter
            // 
            this.animalCounter.AutoSize = true;
            this.animalCounter.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.animalCounter.Location = new System.Drawing.Point(11, 404);
            this.animalCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.animalCounter.Name = "animalCounter";
            this.animalCounter.Size = new System.Drawing.Size(92, 29);
            this.animalCounter.TabIndex = 2;
            this.animalCounter.Text = "Animals: 0";
            // 
            // animal
            // 
            this.animal.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.animal.Location = new System.Drawing.Point(719, 0);
            this.animal.Name = "animal";
            this.animal.Size = new System.Drawing.Size(75, 21);
            this.animal.TabIndex = 6;
            this.animal.Text = "Animals";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(728, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Plants";
            // 
            // milkBar
            // 
            this.milkBar.Location = new System.Drawing.Point(142, 424);
            this.milkBar.Name = "milkBar";
            this.milkBar.Size = new System.Drawing.Size(92, 23);
            this.milkBar.TabIndex = 11;
            // 
            // Savebtn
            // 
            this.Savebtn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
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
            this.Loadbtn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
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
            this.plantCounter.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.plantCounter.Location = new System.Drawing.Point(12, 424);
            this.plantCounter.Name = "plantCounter";
            this.plantCounter.Size = new System.Drawing.Size(77, 29);
            this.plantCounter.TabIndex = 15;
            this.plantCounter.Text = "Plants: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(166, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Milk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(262, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Eggs";
            // 
            // eggsBar
            // 
            this.eggsBar.Location = new System.Drawing.Point(240, 424);
            this.eggsBar.Name = "eggsBar";
            this.eggsBar.Size = new System.Drawing.Size(92, 23);
            this.eggsBar.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(567, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Corns";
            // 
            // cornBar
            // 
            this.cornBar.Location = new System.Drawing.Point(549, 424);
            this.cornBar.Name = "cornBar";
            this.cornBar.Size = new System.Drawing.Size(92, 23);
            this.cornBar.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(469, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Apples";
            // 
            // appleBar
            // 
            this.appleBar.Location = new System.Drawing.Point(451, 424);
            this.appleBar.Name = "appleBar";
            this.appleBar.Size = new System.Drawing.Size(92, 23);
            this.appleBar.TabIndex = 19;
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
            this.coins.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.coins.Location = new System.Drawing.Point(402, 418);
            this.coins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(22, 29);
            this.coins.TabIndex = 24;
            this.coins.Text = "0";
            // 
            // LeftBorder
            // 
            this.LeftBorder.Image = global::MainProject.Properties.Resources.backGround2crop2_0;
            this.LeftBorder.Location = new System.Drawing.Point(2, 247);
            this.LeftBorder.Name = "LeftBorder";
            this.LeftBorder.Size = new System.Drawing.Size(88, 156);
            this.LeftBorder.TabIndex = 29;
            this.LeftBorder.TabStop = false;
            // 
            // RightBorder
            // 
            this.RightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(189)))), ((int)(((byte)(134)))));
            this.RightBorder.Image = global::MainProject.Properties.Resources.backGround2Crop;
            this.RightBorder.Location = new System.Drawing.Point(615, 1);
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(96, 400);
            this.RightBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightBorder.TabIndex = 28;
            this.RightBorder.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(189)))), ((int)(((byte)(134)))));
            this.pictureBox1.Image = global::MainProject.Properties.Resources.backGround2;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(365, 412);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // treePic
            // 
            this.treePic.BackColor = System.Drawing.Color.Transparent;
            this.treePic.Image = global::MainProject.Properties.Resources.appleTree;
            this.treePic.Location = new System.Drawing.Point(732, 167);
            this.treePic.Margin = new System.Windows.Forms.Padding(2);
            this.treePic.Name = "treePic";
            this.treePic.Size = new System.Drawing.Size(47, 39);
            this.treePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.treePic.TabIndex = 9;
            this.treePic.TabStop = false;
            this.treePic.Click += new System.EventHandler(this.treePic_Click);
            // 
            // cornPic
            // 
            this.cornPic.BackColor = System.Drawing.Color.Transparent;
            this.cornPic.Image = global::MainProject.Properties.Resources.cornField;
            this.cornPic.Location = new System.Drawing.Point(732, 224);
            this.cornPic.Margin = new System.Windows.Forms.Padding(2);
            this.cornPic.Name = "cornPic";
            this.cornPic.Size = new System.Drawing.Size(47, 39);
            this.cornPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cornPic.TabIndex = 8;
            this.cornPic.TabStop = false;
            this.cornPic.Click += new System.EventHandler(this.cornPic_Click_1);
            // 
            // ChickenPic
            // 
            this.ChickenPic.BackColor = System.Drawing.Color.Transparent;
            this.ChickenPic.Image = global::MainProject.Properties.Resources.chicken2_removebg_preview1;
            this.ChickenPic.Location = new System.Drawing.Point(732, 80);
            this.ChickenPic.Margin = new System.Windows.Forms.Padding(2);
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
            this.CowPic.Margin = new System.Windows.Forms.Padding(2);
            this.CowPic.Name = "CowPic";
            this.CowPic.Size = new System.Drawing.Size(47, 44);
            this.CowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CowPic.TabIndex = 3;
            this.CowPic.TabStop = false;
            this.CowPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(189)))), ((int)(((byte)(134)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 459);
            this.Controls.Add(this.LeftBorder);
            this.Controls.Add(this.RightBorder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cornBar);
            this.Controls.Add(this.appleBar);
            this.Controls.Add(this.eggsBar);
            this.Controls.Add(this.milkBar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.coins);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plantCounter);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.treePic);
            this.Controls.Add(this.cornPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.animal);
            this.Controls.Add(this.ChickenPic);
            this.Controls.Add(this.CowPic);
            this.Controls.Add(this.animalCounter);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cornPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChickenPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CowPic)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label coins;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox RightBorder;
        private System.Windows.Forms.PictureBox LeftBorder;
    }
}