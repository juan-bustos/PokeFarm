using System;
using System.Collections.Generic;
using System.Text;

namespace PokeFarm
{
    public class Charmander : Pokemon
    {
        int MaxAge = 15;
        public string hiddenAbility;

        public Charmander (string name)
        {
            this.name = name;
            this.move = "Ember";
            this.type = "Fire";
            this.MaxAge = R.Next(MaxAge);
            this.hiddenAbility = "Solar Power";
        }
    }
}
