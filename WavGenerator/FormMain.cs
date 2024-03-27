using NAudio.Wave;
using System.Diagnostics;

namespace WavGenerator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sampleRate = (int)this.numericUpDownSampleRate.Value;
            var frequency = (int)this.numericUpDownToneFrequency.Value;
            var amplitude = (float)(this.numericUpDownAmp.Value / 100);
            var seconds = (int)this.numericUpDownTime.Value;

            string FileName = String.Format("{0}_{1}Hz_{2}%_{3}s.wav", sampleRate, frequency, amplitude * 100, seconds);
            string FullPath = Path.Combine(this.textBoxFilePath.Text, FileName);

            var waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, 1);
            using (var writer = new WaveFileWriter(FullPath, waveFormat))
            {
                var samples = new float[sampleRate * seconds];
                for (int n = 0; n < samples.Length; n++)
                {
                    var time = (double)n / sampleRate;
                    samples[n] = (float)(amplitude * Math.Sin(2 * Math.PI * frequency * time));
                }

                writer.WriteSamples(samples, 0, samples.Length);
            }

            // open explorer with the file
            Process.Start("explorer.exe", "/select, " + FullPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPrev();
        }

        private void LoadPrev()
        {
            this.numericUpDownSampleRate.Value = Properties.Settings.Default.SampleRate;
            this.numericUpDownToneFrequency.Value = Properties.Settings.Default.ToneFrequency;
            this.numericUpDownAmp.Value = Properties.Settings.Default.Volume;
            this.numericUpDownTime.Value = Properties.Settings.Default.Time;

            if (Path.Exists(Properties.Settings.Default.PathToSave))
            {
                this.textBoxFilePath.Text = Properties.Settings.Default.PathToSave;
            }
            else
            {
                // set default path which exe file exists
                this.textBoxFilePath.Text = Path.GetDirectoryName(Application.ExecutablePath);
            }
        }

        private void numericUpDownSampleRate_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SampleRate = this.numericUpDownSampleRate.Value;
            Properties.Settings.Default.Save();
        }

        private void numericUpDownToneFrequency_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ToneFrequency = this.numericUpDownToneFrequency.Value;
            Properties.Settings.Default.Save();
        }

        private void numericUpDownAmp_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Volume = this.numericUpDownAmp.Value;
            Properties.Settings.Default.Save();
        }

        private void numericUpDownTime_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Time = this.numericUpDownTime.Value;
            Properties.Settings.Default.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PathToSave = this.textBoxFilePath.Text;
            Properties.Settings.Default.Save();
        }
    }
}
