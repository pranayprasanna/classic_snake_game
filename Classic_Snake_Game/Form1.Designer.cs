namespace Classic_Snake_Game
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
            this.snapButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.desertButton = new System.Windows.Forms.Button();
            this.jungleButton = new System.Windows.Forms.Button();
            this.waterButton = new System.Windows.Forms.Button();
            this.slowButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.fastButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // snapButton
            // 
            this.snapButton.BackColor = System.Drawing.Color.Tomato;
            this.snapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snapButton.Location = new System.Drawing.Point(598, 87);
            this.snapButton.Name = "snapButton";
            this.snapButton.Size = new System.Drawing.Size(142, 69);
            this.snapButton.TabIndex = 0;
            this.snapButton.Text = "Snap";
            this.snapButton.UseVisualStyleBackColor = false;
            this.snapButton.Click += new System.EventHandler(this.TakeSnapShot);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LimeGreen;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(598, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(142, 69);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartGame);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.Silver;
            this.picCanvas.Location = new System.Drawing.Point(12, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(580, 680);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(593, 159);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(94, 25);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = "Score: 0";
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.Location = new System.Drawing.Point(593, 184);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(144, 25);
            this.txtHighScore.TabIndex = 4;
            this.txtHighScore.Text = "High Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 60;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // desertButton
            // 
            this.desertButton.BackColor = System.Drawing.Color.SandyBrown;
            this.desertButton.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desertButton.Location = new System.Drawing.Point(598, 469);
            this.desertButton.Name = "desertButton";
            this.desertButton.Size = new System.Drawing.Size(142, 69);
            this.desertButton.TabIndex = 5;
            this.desertButton.Text = "Desert Snake";
            this.desertButton.UseVisualStyleBackColor = false;
            this.desertButton.Click += new System.EventHandler(this.desert_theme);
            // 
            // jungleButton
            // 
            this.jungleButton.BackColor = System.Drawing.Color.Green;
            this.jungleButton.Font = new System.Drawing.Font("Papyrus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jungleButton.Location = new System.Drawing.Point(598, 544);
            this.jungleButton.Name = "jungleButton";
            this.jungleButton.Size = new System.Drawing.Size(142, 69);
            this.jungleButton.TabIndex = 6;
            this.jungleButton.Text = "Jungle Snake";
            this.jungleButton.UseVisualStyleBackColor = false;
            this.jungleButton.Click += new System.EventHandler(this.jungle_theme);
            // 
            // waterButton
            // 
            this.waterButton.BackColor = System.Drawing.Color.SteelBlue;
            this.waterButton.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterButton.Location = new System.Drawing.Point(598, 619);
            this.waterButton.Name = "waterButton";
            this.waterButton.Size = new System.Drawing.Size(142, 69);
            this.waterButton.TabIndex = 7;
            this.waterButton.Text = "Water Snake";
            this.waterButton.UseVisualStyleBackColor = false;
            this.waterButton.Click += new System.EventHandler(this.water_theme);
            // 
            // slowButton
            // 
            this.slowButton.BackColor = System.Drawing.Color.LightGray;
            this.slowButton.Location = new System.Drawing.Point(633, 298);
            this.slowButton.Name = "slowButton";
            this.slowButton.Size = new System.Drawing.Size(75, 23);
            this.slowButton.TabIndex = 9;
            this.slowButton.Text = "Slow";
            this.slowButton.UseVisualStyleBackColor = false;
            this.slowButton.Click += new System.EventHandler(this.slow_speed);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.Color.LightGray;
            this.mediumButton.Location = new System.Drawing.Point(633, 327);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(75, 23);
            this.mediumButton.TabIndex = 10;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.medium_speed);
            // 
            // fastButton
            // 
            this.fastButton.BackColor = System.Drawing.Color.LightGray;
            this.fastButton.Location = new System.Drawing.Point(633, 356);
            this.fastButton.Name = "fastButton";
            this.fastButton.Size = new System.Drawing.Size(75, 23);
            this.fastButton.TabIndex = 11;
            this.fastButton.Text = "Fast";
            this.fastButton.UseVisualStyleBackColor = false;
            this.fastButton.Click += new System.EventHandler(this.fast_speed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 717);
            this.Controls.Add(this.fastButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.slowButton);
            this.Controls.Add(this.waterButton);
            this.Controls.Add(this.jungleButton);
            this.Controls.Add(this.desertButton);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.snapButton);
            this.Name = "Form1";
            this.Text = "Classic Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button desertButton;
        private System.Windows.Forms.Button jungleButton;
        private System.Windows.Forms.Button waterButton;
        private System.Windows.Forms.Button slowButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button fastButton;
    }
}

