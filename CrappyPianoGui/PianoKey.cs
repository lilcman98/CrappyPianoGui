using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CrappyPianoGui
{
    class PianoKey
    {
        public SignalGenerator Wave;
        public KeyState State;
        public Key Key;

        public PianoKey(double frequency, double gain, Key key, SignalGeneratorType type)
        {
            Wave = new SignalGenerator
            {
                Gain = gain,
                Frequency = frequency,
                Type = type,
            };

            State = KeyState.Released;
            Key = key;
        }

        public void StartListener()
        {
            using (var wo = new WaveOutEvent())
            {
                var wave = new SignalGenerator()
                {
                    Gain = Wave.Gain,
                    Frequency = Wave.Frequency,
                    Type = Wave.Type,
                };

                wo.Init(wave);
                for (; ; )
                {
                    if (Keyboard.IsKeyDown(Key) && State == KeyState.Released)
                    {
                        Task.Run(() => wo.Play());
                        State = KeyState.Pressed;
                    }
                    else if (!Keyboard.IsKeyDown(Key) && State == KeyState.Pressed)
                    {
                        wo.Stop();
                        State = KeyState.Released;
                    }

                    Thread.Sleep(1);

                }
            }
        }
    }

    enum KeyState
    {
        Pressed,
        Released,
    }
}
