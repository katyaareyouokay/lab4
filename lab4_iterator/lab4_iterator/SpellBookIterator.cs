using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_iterator
{
    internal class SpellBookIterator : IIterator<string>
    {
        private readonly string[] _spells;
        private int _position;

        public SpellBookIterator(string[] spells)
        {
            _spells = spells;
            _position = 0;
        }

        public bool HasNext()
        {
            return _position < _spells.Length;
        }

        public string Next()
        {
            if (HasNext())
            {
                return _spells[_position++];
            }
            throw new InvalidOperationException("No more spells in the book.");
        }
    }
}
