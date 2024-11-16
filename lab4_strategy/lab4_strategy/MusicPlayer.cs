using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_strategy
{
    internal class MusicPlayer
    {
        private IMusicStrategy _strategy;

        public void SetStrategy(IMusicStrategy strategy)
        {
            _strategy = strategy;
        }

        public void PlaySong(string song)
        {
            if (_strategy == null)
            {
                Console.WriteLine("No strategy set. Cannot play music.");
                return;
            }
            _strategy.Play(song);
        }
    }
}

