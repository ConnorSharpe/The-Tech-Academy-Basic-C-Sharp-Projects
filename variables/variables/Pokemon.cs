using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Pokemon
    {
        public Pokemon(string name) : this(name, 75)
        {

        }
        public Pokemon(string name, int Hp)
        {
            string Name = name;
            int health = Hp;
        }
    }
}
