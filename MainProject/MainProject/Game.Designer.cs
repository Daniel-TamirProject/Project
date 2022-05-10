
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
            this.backgroundpanel = new System.Windows.Forms.Panel();
            this.counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundpanel
            // 
            this.backgroundpanel.BackColor = System.Drawing.Color.Transparent;
            this.backgroundpanel.Location = new System.Drawing.Point(3, 3);
            this.backgroundpanel.Name = "backgroundpanel";
            this.backgroundpanel.Size = new System.Drawing.Size(1061, 495);
            this.backgroundpanel.TabIndex = 0;
            this.backgroundpanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backgroundpanel_MouseClick);
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Location = new System.Drawing.Point(791, 524);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(51, 17);
            this.counter.TabIndex = 2;
            this.counter.Text = "count :";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainProject.Properties.Resources.grassBackground2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.backgroundpanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel backgroundpanel;
        private System.Windows.Forms.Label counter;
    }
}