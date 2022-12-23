namespace Formula_1_Drag_Race
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.finishLine2 = new System.Windows.Forms.PictureBox();
            this.finishLine1 = new System.Windows.Forms.PictureBox();
            this.finishLine3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishLine3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.RefreshGame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(50, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1170, 115);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formula 1 Drag Race";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Image = ((System.Drawing.Image)(resources.GetObject("player1.Image")));
            this.player1.Location = new System.Drawing.Point(28, 444);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(200, 50);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player1.TabIndex = 1;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.Image = ((System.Drawing.Image)(resources.GetObject("player2.Image")));
            this.player2.Location = new System.Drawing.Point(28, 590);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(200, 43);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player2.TabIndex = 2;
            this.player2.TabStop = false;
            // 
            // finishLine2
            // 
            this.finishLine2.Image = ((System.Drawing.Image)(resources.GetObject("finishLine2.Image")));
            this.finishLine2.Location = new System.Drawing.Point(1134, 581);
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
            this.finishLine1.Location = new System.Drawing.Point(1134, 491);
            this.finishLine1.Margin = new System.Windows.Forms.Padding(0);
            this.finishLine1.Name = "finishLine1";
            this.finishLine1.Size = new System.Drawing.Size(40, 100);
            this.finishLine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finishLine1.TabIndex = 4;
            this.finishLine1.TabStop = false;
            // 
            // finishLine3
            // 
            this.finishLine3.Image = ((System.Drawing.Image)(resources.GetObject("finishLine3.Image")));
            this.finishLine3.Location = new System.Drawing.Point(1134, 391);
            this.finishLine3.Margin = new System.Windows.Forms.Padding(0);
            this.finishLine3.Name = "finishLine3";
            this.finishLine3.Size = new System.Drawing.Size(40, 100);
            this.finishLine3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finishLine3.TabIndex = 6;
            this.finishLine3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(377, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "Press Enter to play...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finishLine3);
            this.Controls.Add(this.finishLine1);
            this.Controls.Add(this.finishLine2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "GameForm";
            this.Text = "Formula 1 Drag Race";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IsKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishLine3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}