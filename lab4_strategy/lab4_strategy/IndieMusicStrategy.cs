using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_strategy
{
    internal class IndieMusicStrategy : IMusicStrategy
{
    public void Play(string song)
    {
        Console.WriteLine($"Playing indie song: {song} with heartfelt lyrics.");
    }
}
}
