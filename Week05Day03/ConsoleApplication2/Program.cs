using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Hero hero = new Hero("Bron", "Dragonslayer", 100, 100, 2);
            Spell spell = new Spell("Fireball", 20, 60, 2);
            Weapon wep = new Weapon("Stinger", 5);
            hero.Equip(wep);
            hero.Learn(spell);
            Dungeon dung = new Dungeon();
            string map = @"C:\Users\Budinov\Documents\Visual Studio 2015\Projects\Week05Day03\ConsoleApplication2\level1.txt";
            dung.GenerateMap(map);
            dung.Spawn(hero);
            
            dung.PrintMap();
            dung.MoveHero(Dungeon.Direction.Left);
            dung.PrintMap();
            dung.MoveHero(Dungeon.Direction.Left);
            dung.PrintMap();

            
            
        }
    }
}
