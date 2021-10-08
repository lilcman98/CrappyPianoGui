using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrappyPianoGui
{
    public partial class CrappyPiano : Form
    {
        private KeyboardPlayer _keyboardPlayer;
        public CrappyPiano(KeyboardPlayer keyboardPlayer)
        {
            _keyboardPlayer = keyboardPlayer;
            _keyboardPlayer.Start();

            Text = "CrappyPiano";

            AutoScaleMode = AutoScaleMode.Dpi;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _keyboardPlayer.Stop();
            _keyboardPlayer.Start();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _keyboardPlayer.SetGain((double)gain.Value/10);
        }

        private void soundTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (soundTypes.Text)
            {
                case "Sawtooth":
                    _keyboardPlayer.SetGeneratorType(NAudio.Wave.SampleProviders.SignalGeneratorType.SawTooth);
                    break;
                case "Sine":
                    _keyboardPlayer.SetGeneratorType(NAudio.Wave.SampleProviders.SignalGeneratorType.Sin);
                    break;
                case "Square":
                    _keyboardPlayer.SetGeneratorType(NAudio.Wave.SampleProviders.SignalGeneratorType.Square);
                    break;
                case "Triangle":
                    _keyboardPlayer.SetGeneratorType(NAudio.Wave.SampleProviders.SignalGeneratorType.Triangle);
                    break;
            }
        }
    }
}
