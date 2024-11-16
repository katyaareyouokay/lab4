using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MusicPlayer player = new MusicPlayer();

            Console.WriteLine("Using Hip-Hop Music Strategy:");
            player.SetStrategy(new HipHopMusicStrategy());
            player.PlaySong("Travis Scott, Young Thug, M.I.A. - FRANCHISE");

            Console.WriteLine("Using Indie Music Strategy:");
            player.SetStrategy(new IndieMusicStrategy());
            player.PlaySong("twenty one pilots - Chlorine");

            Console.WriteLine("Using Pop Music Strategy:");
            player.SetStrategy(new PopMusicStrategy());
            player.PlaySong("Lana Del Rey - Love");
            Console.ReadKey();
        }
    }
}
