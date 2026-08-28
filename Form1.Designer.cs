namespace Snake_Game
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.pbApple = new System.Windows.Forms.PictureBox();
            this.pbRestart = new System.Windows.Forms.PictureBox();
            this.pbStop = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackgroundImage = global::Snake_Game.Properties.Resources.wood;
            this.topPanel.Controls.Add(this.lblScore);
            this.topPanel.Controls.Add(this.pbApple);
            this.topPanel.Controls.Add(this.pbRestart);
            this.topPanel.Controls.Add(this.pbStop);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(960, 67);
            this.topPanel.TabIndex = 0;
            // 
            // pbApple
            // 
            this.pbApple.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbApple.BackColor = System.Drawing.Color.Transparent;
            this.pbApple.Image = global::Snake_Game.Properties.Resources.apple;
            this.pbApple.Location = new System.Drawing.Point(12, 0);
            this.pbApple.Name = "pbApple";
            this.pbApple.Size = new System.Drawing.Size(77, 67);
            this.pbApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApple.TabIndex = 2;
            this.pbApple.TabStop = false;
            // 
            // pbRestart
            // 
            this.pbRestart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbRestart.BackColor = System.Drawing.Color.Transparent;
            this.pbRestart.Image = global::Snake_Game.Properties.Resources.restart;
            this.pbRestart.Location = new System.Drawing.Point(757, 3);
            this.pbRestart.Name = "pbRestart";
            this.pbRestart.Size = new System.Drawing.Size(89, 61);
            this.pbRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRestart.TabIndex = 1;
            this.pbRestart.TabStop = false;
            // 
            // pbStop
            // 
            this.pbStop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbStop.BackColor = System.Drawing.Color.Transparent;
            this.pbStop.Image = global::Snake_Game.Properties.Resources.play;
            this.pbStop.Location = new System.Drawing.Point(859, 3);
            this.pbStop.Name = "pbStop";
            this.pbStop.Size = new System.Drawing.Size(89, 61);
            this.pbStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStop.TabIndex = 0;
            this.pbStop.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Goudy Stout", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(95, 14);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(45, 44);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Snake_Game.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 569);
            this.Controls.Add(this.topPanel);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pbApple;
        private System.Windows.Forms.PictureBox pbRestart;
        private System.Windows.Forms.PictureBox pbStop;
        private System.Windows.Forms.Label lblScore;
    }
}

