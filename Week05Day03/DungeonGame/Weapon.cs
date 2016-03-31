using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Weapon
    {
        private string weaponName;
        public int weaponDamage { get; }

        public Weapon(string name, int damage)
        {
            weaponName = name;
            weaponDamage = damage;
        }
    }
}
