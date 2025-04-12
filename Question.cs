using System.Drawing;
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using NAudio.Wave;
using System.IO;

namespace YouAreAnIdiot_UnFlash
{
    public partial class Question : Form
    {
        IWavePlayer waveOutStart = new WaveOut();

        public Question()
        {
            InitializeComponent();
            this.ActiveControl = Label_Question;
            FontColour.Start();
            Mp3FileReader provider = new Mp3FileReader(new MemoryStream(Properties.Resources.you_are_an_idiot));

            waveOutStart.Init(provider);
            waveOutStart.Play();
        }

        private void FontColour_Tick(object sender, EventArgs e)
        {
            this.Timer_FT.Text = Conversions.ToString(Conversions.ToDouble(this.Timer_FT.Text) + 1.0);
            if (Conversions.ToDouble(this.Timer_FT.Text) == 0.0)
                this.Label_Question.ForeColor = Color.Indigo;
            if (Conversions.ToDouble(this.Timer_FT.Text) == 1.0)
                this.Label_Question.ForeColor = Color.Ivory;
            if (Conversions.ToDouble(this.Timer_FT.Text) == 2.0)
                this.Label_Question.ForeColor = Color.LightPink;
            if (Conversions.ToDouble(this.Timer_FT.Text) == 3.0)
                this.Label_Question.ForeColor = Color.LightSkyBlue;
            if (Conversions.ToDouble(this.Timer_FT.Text) == 4.0)
                this.Label_Question.ForeColor = Color.Lime;
            if (Conversions.ToDouble(this.Timer_FT.Text) == 5.0)
                this.Label_Question.ForeColor = Color.MediumPurple;
            if (Conversions.ToDouble(this.Timer_FT.Text) == 6.0)
                this.Label_Question.ForeColor = Color.MediumSpringGreen;
            if (Conversions.ToDouble(this.Timer_FT.Text) == 7.0)
                this.Label_Question.ForeColor = Color.Pink;
            if (Conversions.ToDouble(this.Timer_FT.Text) == 8.0)
                this.Label_Question.ForeColor = Color.Red;
            if (Conversions.ToDouble(this.Timer_FT.Text) != 9.0)
                return;
            this.Label_Question.ForeColor = Color.Snow;
            this.Timer_FT.Text = Conversions.ToString(0);
        }

        private void No_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oh... I think you are an idiot. XD", "YouAreAnIdiot");
            this.Close();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?", "YouAreAnIdiot", MessageBoxButtons.YesNo);
            this.Close();
        }

        IWavePlayer waveOut = new WaveOut();
        Mp3FileReader provider = new Mp3FileReader(new MemoryStream(Properties.Resources.you_are_an_idiot_long));

        private void Question_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (waveOut.PlaybackState != PlaybackState.Playing)
            {
                waveOutStart.Stop();
                waveOut.Init(provider);
                waveOut.Play();
                waveOut.PlaybackStopped += WaveOut_PlaybackStopped;
            }
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
            this.Hide();
        }

        private void WaveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            provider.Position = 0;
            waveOut.Play();
        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            waveOutStart.Dispose();

            if (waveOut.PlaybackState == PlaybackState.Playing) return;
            waveOut.PlaybackStopped += WaveOut_PlaybackStopped;
            waveOut.Init(provider);
            waveOut.Play();
        }
    }
}
