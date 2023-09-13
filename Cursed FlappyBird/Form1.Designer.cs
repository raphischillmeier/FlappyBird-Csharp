namespace Cursed_FlappyBird
{
    partial class pipeDownOne
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pipeDownOne));
            this.bg = new System.Windows.Forms.Label();
            this.flappy = new System.Windows.Forms.PictureBox();
            this.dipeDownOne = new System.Windows.Forms.PictureBox();
            this.pipeUpOne = new System.Windows.Forms.PictureBox();
            this.pipeDownTwo = new System.Windows.Forms.PictureBox();
            this.pipeUpTwo = new System.Windows.Forms.PictureBox();
            this.pipeUpThree = new System.Windows.Forms.PictureBox();
            this.pipeDownThree = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameOverText = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipeDownOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUpOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDownTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUpTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUpThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDownThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bg
            // 
            this.bg.AutoSize = true;
            this.bg.BackColor = System.Drawing.Color.DarkRed;
            this.bg.Location = new System.Drawing.Point(0, 0);
            this.bg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(0, 16);
            this.bg.TabIndex = 0;
            // 
            // flappy
            // 
            this.flappy.Image = ((System.Drawing.Image)(resources.GetObject("flappy.Image")));
            this.flappy.Location = new System.Drawing.Point(65, 184);
            this.flappy.Margin = new System.Windows.Forms.Padding(4);
            this.flappy.Name = "flappy";
            this.flappy.Size = new System.Drawing.Size(76, 69);
            this.flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappy.TabIndex = 1;
            this.flappy.TabStop = false;
            this.flappy.DoubleClick += new System.EventHandler(this.label1_Click);
            this.flappy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.click);
            // 
            // dipeDownOne
            // 
            this.dipeDownOne.Image = ((System.Drawing.Image)(resources.GetObject("dipeDownOne.Image")));
            this.dipeDownOne.Location = new System.Drawing.Point(405, -24);
            this.dipeDownOne.Margin = new System.Windows.Forms.Padding(4);
            this.dipeDownOne.Name = "dipeDownOne";
            this.dipeDownOne.Size = new System.Drawing.Size(26, 216);
            this.dipeDownOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dipeDownOne.TabIndex = 3;
            this.dipeDownOne.TabStop = false;
            // 
            // pipeUpOne
            // 
            this.pipeUpOne.Image = ((System.Drawing.Image)(resources.GetObject("pipeUpOne.Image")));
            this.pipeUpOne.Location = new System.Drawing.Point(405, 377);
            this.pipeUpOne.Margin = new System.Windows.Forms.Padding(4);
            this.pipeUpOne.Name = "pipeUpOne";
            this.pipeUpOne.Size = new System.Drawing.Size(59, 213);
            this.pipeUpOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUpOne.TabIndex = 4;
            this.pipeUpOne.TabStop = false;
            this.pipeUpOne.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pipeDownTwo
            // 
            this.pipeDownTwo.Image = ((System.Drawing.Image)(resources.GetObject("pipeDownTwo.Image")));
            this.pipeDownTwo.Location = new System.Drawing.Point(551, -1);
            this.pipeDownTwo.Margin = new System.Windows.Forms.Padding(4);
            this.pipeDownTwo.Name = "pipeDownTwo";
            this.pipeDownTwo.Size = new System.Drawing.Size(43, 262);
            this.pipeDownTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDownTwo.TabIndex = 5;
            this.pipeDownTwo.TabStop = false;
            // 
            // pipeUpTwo
            // 
            this.pipeUpTwo.Image = ((System.Drawing.Image)(resources.GetObject("pipeUpTwo.Image")));
            this.pipeUpTwo.Location = new System.Drawing.Point(551, 435);
            this.pipeUpTwo.Margin = new System.Windows.Forms.Padding(4);
            this.pipeUpTwo.Name = "pipeUpTwo";
            this.pipeUpTwo.Size = new System.Drawing.Size(52, 142);
            this.pipeUpTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUpTwo.TabIndex = 6;
            this.pipeUpTwo.TabStop = false;
            // 
            // pipeUpThree
            // 
            this.pipeUpThree.Image = ((System.Drawing.Image)(resources.GetObject("pipeUpThree.Image")));
            this.pipeUpThree.Location = new System.Drawing.Point(745, 361);
            this.pipeUpThree.Margin = new System.Windows.Forms.Padding(4);
            this.pipeUpThree.Name = "pipeUpThree";
            this.pipeUpThree.Size = new System.Drawing.Size(41, 200);
            this.pipeUpThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUpThree.TabIndex = 7;
            this.pipeUpThree.TabStop = false;
            // 
            // pipeDownThree
            // 
            this.pipeDownThree.Image = ((System.Drawing.Image)(resources.GetObject("pipeDownThree.Image")));
            this.pipeDownThree.Location = new System.Drawing.Point(675, -1);
            this.pipeDownThree.Margin = new System.Windows.Forms.Padding(4);
            this.pipeDownThree.Name = "pipeDownThree";
            this.pipeDownThree.Size = new System.Drawing.Size(43, 230);
            this.pipeDownThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDownThree.TabIndex = 8;
            this.pipeDownThree.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 20;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // gameOverText
            // 
            this.gameOverText.AutoSize = true;
            this.gameOverText.BackColor = System.Drawing.Color.White;
            this.gameOverText.Font = new System.Drawing.Font("Lucida Sans Unicode", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverText.Location = new System.Drawing.Point(113, 257);
            this.gameOverText.MinimumSize = new System.Drawing.Size(10, 10);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(253, 53);
            this.gameOverText.TabIndex = 9;
            this.gameOverText.Text = "Game Over";
            this.gameOverText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOverText.Visible = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.White;
            this.scoreText.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(144, 322);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(90, 36);
            this.scoreText.TabIndex = 10;
            this.scoreText.Text = "Score";
            this.scoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoreText.Visible = false;
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(177, 361);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 11;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.restart_Click_1);
            this.restart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownEvent);
            this.restart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            this.restart.MouseEnter += new System.EventHandler(this.keyDownEventRestart);
            // 
            // pipeDownOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(830, 521);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.pipeDownThree);
            this.Controls.Add(this.pipeUpThree);
            this.Controls.Add(this.pipeUpTwo);
            this.Controls.Add(this.pipeDownTwo);
            this.Controls.Add(this.pipeUpOne);
            this.Controls.Add(this.dipeDownOne);
            this.Controls.Add(this.flappy);
            this.Controls.Add(this.bg);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pipeDownOne";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipeDownOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUpOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDownTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUpTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUpThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDownThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bg;
        private System.Windows.Forms.PictureBox flappy;
        private System.Windows.Forms.PictureBox dipeDownOne;
        private System.Windows.Forms.PictureBox pipeUpOne;
        private System.Windows.Forms.PictureBox pipeDownTwo;
        private System.Windows.Forms.PictureBox pipeUpTwo;
        private System.Windows.Forms.PictureBox pipeUpThree;
        private System.Windows.Forms.PictureBox pipeDownThree;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label gameOverText;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Button restart;
    }
}

