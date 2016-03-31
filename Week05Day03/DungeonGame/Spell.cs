using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Spell
    {
        private string spellName;
        private int spellDamage;
        private int manaCost;
        private int castRange;

        public Spell(string name, int damage, int manaCost, int castRange)
        {
            spellName = name;
            spellDamage = damage;
            this.manaCost = manaCost;
            this.castRange = castRange;
        }

        public int GetManaCost()
        {
            return this.manaCost;
            
        }

        public int GetCastRange()
        {
            return this.castRange;
        }

        public int GetDamage()
        {
            return this.spellDamage;
        }

        public string GetName()
        {
            return this.spellName;
        }
    }
}
