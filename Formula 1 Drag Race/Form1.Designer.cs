namespace Formula_1_Drag_Race
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.opponent = new System.Windows.Forms.PictureBox();
            this.finishLine2 = new System.Windows.Forms.PictureBox();
            this.finishLine1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishLine1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(50, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1170, 115);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formula 1 Drag Race";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Crimson;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(28, 374);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(200, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // opponent
            // 
            this.opponent.Image = ((System.Drawing.Image)(resources.GetObject("opponent.Image")));
            this.opponent.Location = new System.Drawing.Point(28, 485);
            this.opponent.Name = "opponent";
            this.opponent.Size = new System.Drawing.Size(200, 43);
            this.opponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.opponent.TabIndex = 2;
            this.opponent.TabStop = false;
            // 
            // finishLine2
            // 
            this.finishLine2.Image = ((System.Drawing.Image)(resources.GetObject("finishLine2.Image")));
            this.finishLine2.Location = new System.Drawing.Point(1134, 455);
            this.finishLine2.Margin = new System.Windows.Forms.Padding(0);
            this.finishLine2.Name = "finishLine2";
            this.finishLine2.Size = new System.Drawing.Size(40, 100);
            this.finishLine2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finishLine2.TabIndex = 3;
            this.finishLine2.TabStop = false;
            // 
            // finishLine1
            // 
            this.finishLine1.Image = ((System.Drawing.Image)(resources.GetObject("finishLine1.Image")));
            this.finishLine1.Location = new System.Drawing.Point(1134, 365);
            this.finishLine1.Margin = new System.Windows.Forms.Padding(0);
            this.finishLine1.Name = "finishLine1";
            this.finishLine1.Size = new System.Drawing.Size(40, 100);
            this.finishLine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finishLine1.TabIndex = 4;
            this.finishLine1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.OnTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.finishLine1);
            this.Controls.Add(this.finishLine2);
            this.Controls.Add(this.opponent);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Formula 1 Drag Race";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KD);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KU);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishLine1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox player;
        private PictureBox opponent;
        private PictureBox finishLine2;
        private PictureBox finishLine1;
        private System.Windows.Forms.Timer timer1;
    }
}