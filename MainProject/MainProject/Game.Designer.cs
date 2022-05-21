
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
            this.treePic = new System.Windows.Forms.PictureBox();
            this.grassPic = new System.Windows.Forms.PictureBox();
            this.adamaPic = new System.Windows.Forms.PictureBox();
            this.shipPic = new System.Windows.Forms.PictureBox();
            this.DuckPic = new System.Windows.Forms.PictureBox();
            this.CowPic = new System.Windows.Forms.PictureBox();
            this.backgroundpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.treePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grassPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adamaPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DuckPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CowPic)).BeginInit();
            this.SuspendLayout();
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Location = new System.Drawing.Point(20, 419);
            this.counter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(40, 13);
            this.counter.TabIndex = 2;
            this.counter.Text = "count :";
            // 
            // animal
            // 
            this.animal.AutoSize = true;
            this.animal.Location = new System.Drawing.Point(745, 9);
            this.animal.Name = "animal";
            this.animal.Size = new System.Drawing.Size(43, 13);
            this.animal.TabIndex = 6;
            this.animal.Text = "Animals";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(745, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "plants";
            // 
            // treePic
            // 
            this.treePic.BackColor = System.Drawing.Color.Transparent;
            this.treePic.Image = global::MainProject.Properties.Resources.tree_removebg_preview;
            this.treePic.Location = new System.Drawing.Point(742, 313);
            this.treePic.Margin = new System.Windows.Forms.Padding(2);
            this.treePic.Name = "treePic";
            this.treePic.Size = new System.Drawing.Size(47, 39);
            this.treePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treePic.TabIndex = 9;
            this.treePic.TabStop = false;
            // 
            // grassPic
            // 
            this.grassPic.BackColor = System.Drawing.Color.Transparent;
            this.grassPic.Image = global::MainProject.Properties.Resources.grass_removebg_preview1;
            this.grassPic.Location = new System.Drawing.Point(742, 265);
            this.grassPic.Margin = new System.Windows.Forms.Padding(2);
            this.grassPic.Name = "grassPic";
            this.grassPic.Size = new System.Drawing.Size(47, 35);
            this.grassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grassPic.TabIndex = 9;
            this.grassPic.TabStop = false;
            // 
            // adamaPic
            // 
            this.adamaPic.BackColor = System.Drawing.Color.Transparent;
            this.adamaPic.Image = global::MainProject.Properties.Resources.adama_removebg_preview1;
            this.adamaPic.Location = new System.Drawing.Point(742, 212);
            this.adamaPic.Margin = new System.Windows.Forms.Padding(2);
            this.adamaPic.Name = "adamaPic";
            this.adamaPic.Size = new System.Drawing.Size(47, 39);
            this.adamaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adamaPic.TabIndex = 8;
            this.adamaPic.TabStop = false;
            this.adamaPic.Click += new System.EventHandler(this.adamaPic_Click);
            // 
            // shipPic
            // 
            this.shipPic.BackColor = System.Drawing.Color.Transparent;
            this.shipPic.Image = global::MainProject.Properties.Resources.ship_removebg_preview;
            this.shipPic.Location = new System.Drawing.Point(742, 137);
            this.shipPic.Margin = new System.Windows.Forms.Padding(2);
            this.shipPic.Name = "shipPic";
            this.shipPic.Size = new System.Drawing.Size(47, 49);
            this.shipPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shipPic.TabIndex = 5;
            this.shipPic.TabStop = false;
            this.shipPic.Click += new System.EventHandler(this.shipPic_Click);
            // 
            // DuckPic
            // 
            this.DuckPic.BackColor = System.Drawing.Color.Transparent;
            this.DuckPic.Image = global::MainProject.Properties.Resources.duck_removebg_preview;
            this.DuckPic.Location = new System.Drawing.Point(742, 81);
            this.DuckPic.Margin = new System.Windows.Forms.Padding(2);
            this.DuckPic.Name = "DuckPic";
            this.DuckPic.Size = new System.Drawing.Size(47, 42);
            this.DuckPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DuckPic.TabIndex = 4;
            this.DuckPic.TabStop = false;
            // 
            // CowPic
            // 
            this.CowPic.BackColor = System.Drawing.Color.Transparent;
            this.CowPic.Image = global::MainProject.Properties.Resources.cow2_removebg_preview;
            this.CowPic.Location = new System.Drawing.Point(742, 24);
            this.CowPic.Margin = new System.Windows.Forms.Padding(2);
            this.CowPic.Name = "CowPic";
            this.CowPic.Size = new System.Drawing.Size(47, 42);
            this.CowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CowPic.TabIndex = 3;
            this.CowPic.TabStop = false;
            this.CowPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // backgroundpanel
            // 
            this.backgroundpanel.BackColor = System.Drawing.Color.Transparent;
            this.backgroundpanel.BackgroundImage = global::MainProject.Properties.Resources.grassBackground2;
            this.backgroundpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundpanel.Location = new System.Drawing.Point(2, 2);
            this.backgroundpanel.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundpanel.Name = "backgroundpanel";
            this.backgroundpanel.Size = new System.Drawing.Size(730, 394);
            this.backgroundpanel.TabIndex = 0;
            this.backgroundpanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backgroundpanel_MouseClick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treePic);
            this.Controls.Add(this.grassPic);
            this.Controls.Add(this.adamaPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.animal);
            this.Controls.Add(this.shipPic);
            this.Controls.Add(this.DuckPic);
            this.Controls.Add(this.CowPic);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.backgroundpanel);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grassPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adamaPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DuckPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CowPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel backgroundpanel;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.PictureBox CowPic;
        private System.Windows.Forms.PictureBox DuckPic;
        private System.Windows.Forms.PictureBox shipPic;
        private System.Windows.Forms.Label animal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox adamaPic;
        private System.Windows.Forms.PictureBox grassPic;
        private System.Windows.Forms.PictureBox treePic;
    }
}