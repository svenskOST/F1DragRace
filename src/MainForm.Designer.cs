namespace F1DragRace
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            player1 = new PictureBox();
            player2 = new PictureBox();
            finishLine2 = new PictureBox();
            finishLine1 = new PictureBox();
            finishLine3 = new PictureBox();
            label2 = new Label();
            display = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            speedText1 = new Label();
            speedText2 = new Label();
            reactionText1 = new Label();
            reactionText2 = new Label();
            ((System.ComponentModel.ISupportInitialize)player1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)finishLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)finishLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)finishLine3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)display).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 16;
            timer1.Tick += RefreshGame;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 72F);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(57, 107);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(1203, 135);
            label1.TabIndex = 0;
            label1.Text = "Formula 1 Drag Race";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // player1
            // 
            player1.BackColor = Color.Transparent;
            player1.Image = (Image)resources.GetObject("player1.Image");
            player1.Location = new Point(32, 592);
            player1.Margin = new Padding(3, 4, 3, 4);
            player1.Name = "player1";
            player1.Size = new Size(200, 50);
            player1.SizeMode = PictureBoxSizeMode.AutoSize;
            player1.TabIndex = 1;
            player1.TabStop = false;
            // 
            // player2
            // 
            player2.BackColor = Color.Transparent;
            player2.Image = (Image)resources.GetObject("player2.Image");
            player2.Location = new Point(32, 787);
            player2.Margin = new Padding(3, 4, 3, 4);
            player2.Name = "player2";
            player2.Size = new Size(200, 43);
            player2.SizeMode = PictureBoxSizeMode.AutoSize;
            player2.TabIndex = 2;
            player2.TabStop = false;
            // 
            // finishLine2
            // 
            finishLine2.Image = (Image)resources.GetObject("finishLine2.Image");
            finishLine2.Location = new Point(1296, 775);
            finishLine2.Margin = new Padding(0);
            finishLine2.Name = "finishLine2";
            finishLine2.Size = new Size(46, 133);
            finishLine2.SizeMode = PictureBoxSizeMode.Zoom;
            finishLine2.TabIndex = 3;
            finishLine2.TabStop = false;
            // 
            // finishLine1
            // 
            finishLine1.Image = (Image)resources.GetObject("finishLine1.Image");
            finishLine1.Location = new Point(1296, 655);
            finishLine1.Margin = new Padding(0);
            finishLine1.Name = "finishLine1";
            finishLine1.Size = new Size(46, 133);
            finishLine1.SizeMode = PictureBoxSizeMode.Zoom;
            finishLine1.TabIndex = 4;
            finishLine1.TabStop = false;
            // 
            // finishLine3
            // 
            finishLine3.Image = (Image)resources.GetObject("finishLine3.Image");
            finishLine3.Location = new Point(1296, 521);
            finishLine3.Margin = new Padding(0);
            finishLine3.Name = "finishLine3";
            finishLine3.Size = new Size(46, 133);
            finishLine3.SizeMode = PictureBoxSizeMode.Zoom;
            finishLine3.TabIndex = 6;
            finishLine3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(431, 360);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(478, 54);
            label2.TabIndex = 7;
            label2.Text = "Press Enter to play...";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // display
            // 
            display.BackColor = Color.Black;
            display.Location = new Point(-16, 908);
            display.Margin = new Padding(3, 4, 3, 4);
            display.Name = "display";
            display.Size = new Size(1463, 267);
            display.TabIndex = 8;
            display.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(322, 929);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 217);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Microsoft Sans Serif", 32.25F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(32, 1009);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(225, 63);
            label3.TabIndex = 10;
            label3.Text = "Player 1";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Microsoft Sans Serif", 32.25F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(751, 1009);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(225, 63);
            label4.TabIndex = 11;
            label4.Text = "Player 2";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(1042, 929);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(351, 217);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // speedText1
            // 
            speedText1.BackColor = Color.Black;
            speedText1.Font = new Font("Microsoft Sans Serif", 27.75F);
            speedText1.ForeColor = Color.FromArgb(224, 224, 224);
            speedText1.Location = new Point(331, 1067);
            speedText1.Margin = new Padding(0);
            speedText1.Name = "speedText1";
            speedText1.Size = new Size(334, 59);
            speedText1.TabIndex = 13;
            speedText1.Text = "0 km/h";
            speedText1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // speedText2
            // 
            speedText2.BackColor = Color.Black;
            speedText2.Font = new Font("Microsoft Sans Serif", 27.75F);
            speedText2.ForeColor = Color.FromArgb(224, 224, 224);
            speedText2.Location = new Point(1051, 1067);
            speedText2.Margin = new Padding(0);
            speedText2.Name = "speedText2";
            speedText2.Size = new Size(334, 59);
            speedText2.TabIndex = 14;
            speedText2.Text = "0 km/h";
            speedText2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // reactionText1
            // 
            reactionText1.BackColor = Color.Black;
            reactionText1.Font = new Font("Microsoft Sans Serif", 20.25F);
            reactionText1.ForeColor = Color.FromArgb(224, 224, 224);
            reactionText1.Location = new Point(331, 945);
            reactionText1.Margin = new Padding(0);
            reactionText1.Name = "reactionText1";
            reactionText1.Size = new Size(336, 59);
            reactionText1.TabIndex = 15;
            reactionText1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // reactionText2
            // 
            reactionText2.BackColor = Color.Black;
            reactionText2.Font = new Font("Microsoft Sans Serif", 20.25F);
            reactionText2.ForeColor = Color.FromArgb(224, 224, 224);
            reactionText2.Location = new Point(1051, 945);
            reactionText2.Margin = new Padding(0);
            reactionText2.Name = "reactionText2";
            reactionText2.Size = new Size(336, 59);
            reactionText2.TabIndex = 16;
            reactionText2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1445, 1055);
            Controls.Add(reactionText2);
            Controls.Add(reactionText1);
            Controls.Add(speedText2);
            Controls.Add(speedText1);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(display);
            Controls.Add(label2);
            Controls.Add(player2);
            Controls.Add(player1);
            Controls.Add(label1);
            Controls.Add(finishLine3);
            Controls.Add(finishLine1);
            Controls.Add(finishLine2);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Formula 1 Drag Race";
            KeyDown += IsKeyDown;
            KeyUp += IsKeyUp;
            ((System.ComponentModel.ISupportInitialize)player1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2).EndInit();
            ((System.ComponentModel.ISupportInitialize)finishLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)finishLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)finishLine3).EndInit();
            ((System.ComponentModel.ISupportInitialize)display).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private PictureBox player1;
        private PictureBox player2;
        private PictureBox finishLine2;
        private PictureBox finishLine1;
        private PictureBox finishLine3;
        private Label label2;
        private PictureBox display;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label speedText1;
        private Label speedText2;
        private Label reactionText1;
        private Label reactionText2;
    }
}