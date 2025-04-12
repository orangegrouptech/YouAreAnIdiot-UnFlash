using System.Drawing;

namespace YouAreAnIdiot_UnFlash
{
    partial class Question
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label_Question = new System.Windows.Forms.Label();
            this.FontColour = new System.Windows.Forms.Timer(this.components);
            this.Timer_FT = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.Button();
            this.None = new System.Windows.Forms.Button();
            this.Yes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(925, 694);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Label_Question
            // 
            this.Label_Question.AutoSize = true;
            this.Label_Question.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Question.Location = new System.Drawing.Point(265, 786);
            this.Label_Question.Name = "Label_Question";
            this.Label_Question.Size = new System.Drawing.Size(382, 48);
            this.Label_Question.TabIndex = 1;
            this.Label_Question.Text = "Are You An Idiot ?";
            // 
            // FontColour
            // 
            this.FontColour.Interval = 55;
            this.FontColour.Tick += new System.EventHandler(this.FontColour_Tick);
            // 
            // Timer_FT
            // 
            this.Timer_FT.AutoSize = true;
            this.Timer_FT.Enabled = false;
            this.Timer_FT.Location = new System.Drawing.Point(865, 763);
            this.Timer_FT.Name = "Timer_FT";
            this.Timer_FT.Size = new System.Drawing.Size(18, 20);
            this.Timer_FT.TabIndex = 2;
            this.Timer_FT.Text = "0";
            this.Timer_FT.Visible = false;
            // 
            // No
            // 
            this.No.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.Location = new System.Drawing.Point(28, 860);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(262, 57);
            this.No.TabIndex = 3;
            this.No.Text = "No, I\'m not.";
            this.No.UseVisualStyleBackColor = true;
            this.No.Click += new System.EventHandler(this.No_Click);
            this.No.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // None
            // 
            this.None.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.None.Location = new System.Drawing.Point(298, 860);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(354, 57);
            this.None.TabIndex = 4;
            this.None.Text = "I don\'t know =[";
            this.None.UseVisualStyleBackColor = true;
            this.None.Click += new System.EventHandler(this.No_Click);
            this.None.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // Yes
            // 
            this.Yes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes.Location = new System.Drawing.Point(660, 860);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(245, 57);
            this.Yes.TabIndex = 5;
            this.Yes.Text = "Yes, I am.";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            this.Yes.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 929);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.None);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Timer_FT);
            this.Controls.Add(this.Label_Question);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Question";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Are You An Idiot?";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Question_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_Question;
        private System.Windows.Forms.Timer FontColour;
        private System.Windows.Forms.Label Timer_FT;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Button None;
        private System.Windows.Forms.Button Yes;
    }
}
