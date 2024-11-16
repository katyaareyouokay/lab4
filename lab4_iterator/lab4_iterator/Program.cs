using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var spellBook = new SpellBook();
            var iterator = spellBook.CreateIterator();

            Console.WriteLine("Reading spells from the spellbook:");
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
            Console.ReadKey();
        }
    }
}
