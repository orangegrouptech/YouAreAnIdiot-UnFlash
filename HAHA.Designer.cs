namespace YouAreAnIdiot_UnFlash
{
    partial class HAHA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HAHA));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MovingWindow = new System.Windows.Forms.Timer(this.components);
            this.X = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.MoveX = new System.Windows.Forms.Label();
            this.MoveY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MovingWindow
            // 
            this.MovingWindow.Interval = 1;
            this.MovingWindow.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(12, 606);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(18, 20);
            this.X.TabIndex = 1;
            this.X.Text = "0";
            this.X.Visible = false;
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(55, 606);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(18, 20);
            this.Y.TabIndex = 2;
            this.Y.Text = "0";
            // 
            // MoveX
            // 
            this.MoveX.AutoSize = true;
            this.MoveX.Location = new System.Drawing.Point(91, 606);
            this.MoveX.Name = "MoveX";
            this.MoveX.Size = new System.Drawing.Size(18, 20);
            this.MoveX.TabIndex = 3;
            this.MoveX.Text = "0";
            // 
            // MoveY
            // 
            this.MoveY.AutoSize = true;
            this.MoveY.Location = new System.Drawing.Point(129, 606);
            this.MoveY.Name = "MoveY";
            this.MoveY.Size = new System.Drawing.Size(18, 20);
            this.MoveY.TabIndex = 4;
            this.MoveY.Text = "0";
            // 
            // HAHA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 310);
            this.Controls.Add(this.MoveY);
            this.Controls.Add(this.MoveX);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HAHA";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HAHA_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer MovingWindow;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label MoveX;
        private System.Windows.Forms.Label MoveY;
    }
}