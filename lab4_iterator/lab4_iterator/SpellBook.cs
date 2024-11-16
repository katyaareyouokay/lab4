using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_iterator
{
    internal class SpellBook : ISpellCollection
    {
        private readonly string[] _spells;

        public SpellBook()
        {
            _spells = new[]
            {
            "Fireball",
            "Ice Shard",
            "Lightning Strike",
            "Healing Light"
        };
        }

        public IIterator<string> CreateIterator()
        {
            return new SpellBookIterator(_spells);
        }
    }
}
