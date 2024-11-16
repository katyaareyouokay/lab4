using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_strategy
{
    internal class HipHopMusicStrategy : IMusicStrategy
    {
        public void Play(string song)
        {
            Console.WriteLine($"Dropping sick beats for: {song} with rhythmic rap and heavy bass!");
        }
    }
}
