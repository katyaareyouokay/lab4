using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_strategy
{
    internal class PopMusicStrategy : IMusicStrategy
    {
        public void Play(string song)
        {
            Console.WriteLine($"Spinning catchy pop hit: {song} with jamming and bright melodies!");
        }
    }
}
