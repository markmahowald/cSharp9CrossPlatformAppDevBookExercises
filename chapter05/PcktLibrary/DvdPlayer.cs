using static System.Console;
namespace  Pckt.Shared
{
    public class DvdPlayer : IPlayable
    {
        public void Pause()
        {
            WriteLine("DVD Player is pausing.");
        }

        public void Play()
        {
            WriteLine("DVD Player is playing.");
        }
    }
}