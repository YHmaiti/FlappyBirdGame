namespace FlappyBirdGameFull
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
            this.Score = new System.Windows.Forms.Label();
            this.pipe2 = new System.Windows.Forms.PictureBox();
            this.BirdFly = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.pipe1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirdFly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Score.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(166, 709);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(92, 24);
            this.Score.TabIndex = 5;
            this.Score.Text = "Points : 0";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // pipe2
            // 
            this.pipe2.BackColor = System.Drawing.Color.Black;
            this.pipe2.Image = global::FlappyBirdGameFull.Properties.Resources.pipe;
            this.pipe2.Location = new System.Drawing.Point(532, 388);
            this.pipe2.Name = "pipe2";
            this.pipe2.Size = new System.Drawing.Size(100, 287);
            this.pipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe2.TabIndex = 3;
            this.pipe2.TabStop = false;
            // 
            // BirdFly
            // 
            this.BirdFly.BackColor = System.Drawing.Color.Black;
            this.BirdFly.Image = global::FlappyBirdGameFull.Properties.Resources.bird;
            this.BirdFly.Location = new System.Drawing.Point(113, 258);
            this.BirdFly.Name = "BirdFly";
            this.BirdFly.Size = new System.Drawing.Size(81, 63);
            this.BirdFly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BirdFly.TabIndex = 2;
            this.BirdFly.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.Yellow;
            this.Ground.Image = global::FlappyBirdGameFull.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(3, 672);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(796, 86);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 1;
            this.Ground.TabStop = false;
            this.Ground.Click += new System.EventHandler(this.Ground_Click);
            // 
            // pipe1
            // 
            this.pipe1.BackColor = System.Drawing.Color.Black;
            this.pipe1.Image = global::FlappyBirdGameFull.Properties.Resources.pipedown;
            this.pipe1.Location = new System.Drawing.Point(393, 0);
            this.pipe1.Name = "pipe1";
            this.pipe1.Size = new System.Drawing.Size(83, 234);
            this.pipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe1.TabIndex = 0;
            this.pipe1.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(797, 756);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.BirdFly);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.pipe1);
            this.Name = "Form1";
            this.Text = "FlappyBirdByYohan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirdFly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipe1;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox BirdFly;
        private System.Windows.Forms.PictureBox pipe2;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gameTimer;
    }
}

