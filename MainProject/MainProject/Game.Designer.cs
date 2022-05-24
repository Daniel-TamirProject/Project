
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
            this.counter = new System.Windows.Forms.Label();
            this.animal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treePic = new System.Windows.Forms.PictureBox();
            this.grassPic = new System.Windows.Forms.PictureBox();
            this.adamaPic = new System.Windows.Forms.PictureBox();
            this.shipPic = new System.Windows.Forms.PictureBox();
            this.ChickenPic = new System.Windows.Forms.PictureBox();
            this.CowPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grassPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adamaPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChickenPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CowPic)).BeginInit();
            this.SuspendLayout();
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Location = new System.Drawing.Point(27, 516);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(62, 17);
            this.counter.TabIndex = 2;
            this.counter.Text = "Counter:";
            // 
            // animal
            // 
            this.animal.AutoSize = true;
            this.animal.Location = new System.Drawing.Point(993, 11);
            this.animal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.animal.Name = "animal";
            this.animal.Size = new System.Drawing.Size(57, 17);
            this.animal.TabIndex = 6;
            this.animal.Text = "Animals";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(993, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "plants";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainProject.Properties.Resources.backGround2;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(968, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // treePic
            // 
            this.treePic.BackColor = System.Drawing.Color.Transparent;
            this.treePic.Image = global::MainProject.Properties.Resources.tree_removebg_preview;
            this.treePic.Location = new System.Drawing.Point(989, 385);
            this.treePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treePic.Name = "treePic";
            this.treePic.Size = new System.Drawing.Size(63, 48);
            this.treePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treePic.TabIndex = 9;
            this.treePic.TabStop = false;
            // 
            // grassPic
            // 
            this.grassPic.BackColor = System.Drawing.Color.Transparent;
            this.grassPic.Image = global::MainProject.Properties.Resources.grass_removebg_preview1;
            this.grassPic.Location = new System.Drawing.Point(989, 326);
            this.grassPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grassPic.Name = "grassPic";
            this.grassPic.Size = new System.Drawing.Size(63, 43);
            this.grassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grassPic.TabIndex = 9;
            this.grassPic.TabStop = false;
            // 
            // adamaPic
            // 
            this.adamaPic.BackColor = System.Drawing.Color.Transparent;
            this.adamaPic.Image = global::MainProject.Properties.Resources.adama_removebg_preview1;
            this.adamaPic.Location = new System.Drawing.Point(989, 261);
            this.adamaPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adamaPic.Name = "adamaPic";
            this.adamaPic.Size = new System.Drawing.Size(63, 48);
            this.adamaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adamaPic.TabIndex = 8;
            this.adamaPic.TabStop = false;
            // 
            // shipPic
            // 
            this.shipPic.BackColor = System.Drawing.Color.Transparent;
            this.shipPic.Image = global::MainProject.Properties.Resources.ship_removebg_preview1;
            this.shipPic.Location = new System.Drawing.Point(989, 169);
            this.shipPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shipPic.Name = "shipPic";
            this.shipPic.Size = new System.Drawing.Size(63, 60);
            this.shipPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shipPic.TabIndex = 5;
            this.shipPic.TabStop = false;
            this.shipPic.Click += new System.EventHandler(this.shipPic_Click);
            // 
            // ChickenPic
            // 
            this.ChickenPic.BackColor = System.Drawing.Color.Transparent;
            this.ChickenPic.Image = global::MainProject.Properties.Resources.chicken2_removebg_preview1;
            this.ChickenPic.Location = new System.Drawing.Point(989, 100);
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
            this.CowPic.Location = new System.Drawing.Point(989, 30);
            this.CowPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CowPic.Name = "CowPic";
            this.CowPic.Size = new System.Drawing.Size(63, 54);
            this.CowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CowPic.TabIndex = 3;
            this.CowPic.TabStop = false;
            this.CowPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treePic);
            this.Controls.Add(this.grassPic);
            this.Controls.Add(this.adamaPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.animal);
            this.Controls.Add(this.shipPic);
            this.Controls.Add(this.ChickenPic);
            this.Controls.Add(this.CowPic);
            this.Controls.Add(this.counter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grassPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adamaPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChickenPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CowPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.PictureBox CowPic;
        private System.Windows.Forms.PictureBox ChickenPic;
        private System.Windows.Forms.PictureBox shipPic;
        private System.Windows.Forms.Label animal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox adamaPic;
        private System.Windows.Forms.PictureBox grassPic;
        private System.Windows.Forms.PictureBox treePic;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}