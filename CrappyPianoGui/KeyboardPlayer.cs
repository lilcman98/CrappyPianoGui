using NAudio.Wave.SampleProviders;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Input;

namespace CrappyPianoGui
{
    public class KeyboardPlayer
    {
        private List<Thread> _threadPool = new List<Thread>();
        private PianoKey[] _pianoKeys = new PianoKey[] {
                new PianoKey(261.63, 0.3, Key.Q, SignalGeneratorType.Sin),
                new PianoKey(293.66, 0.3, Key.W, SignalGeneratorType.Sin),
                new PianoKey(329.63, 0.3, Key.E, SignalGeneratorType.Sin),
                new PianoKey(349.23, 0.3, Key.R, SignalGeneratorType.Sin),
                new PianoKey(392.00, 0.3, Key.T, SignalGeneratorType.Sin),
                new PianoKey(440.00, 0.3, Key.Y, SignalGeneratorType.Sin),
                new PianoKey(493.88, 0.3, Key.U, SignalGeneratorType.Sin),
                new PianoKey(523.25, 0.3, Key.I, SignalGeneratorType.Sin),
                new PianoKey(587.33, 0.3, Key.O, SignalGeneratorType.Sin),
                new PianoKey(659.25, 0.3, Key.P, SignalGeneratorType.Sin),
                new PianoKey(698.46, 0.3, Key.OemOpenBrackets, SignalGeneratorType.Sin),
                new PianoKey(783.99, 0.3, Key.OemCloseBrackets, SignalGeneratorType.Sin),
            };

        public void Start()
        {
            foreach (PianoKey key in _pianoKeys)
            {
                var thread = new Thread(() => key.StartListener());

                thread.SetApartmentState(ApartmentState.STA);
                thread.IsBackground = true;

                thread.Start();
                _threadPool.Add(thread);
            }
        }

        public void Stop()
        {
            foreach (Thread thread in _threadPool)
            {
                thread.Abort();
            }
        }

        public void SetGeneratorType(SignalGeneratorType type)
        {
            foreach (PianoKey key in _pianoKeys)
            {
                key.Wave.Type = type;
            }
        }

        public void SetGain(double gain)
        {
            foreach (PianoKey key in _pianoKeys)
            {
                key.Wave.Gain = gain;
            }
        }
    }
}