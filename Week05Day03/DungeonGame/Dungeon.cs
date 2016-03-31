using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Dungeon
    {
        private Hero hero;
        private List<char[]> map = new List<char[]>();
        private int heroListPosition = 0;
        private int heroArrPosition = 0;
        private List<string> treasure = new List<string>() { "Health potion", "Mana potion", "No treasure" };
        private Random rnd = new Random();
        private Enemy enemy;
        private string gameState = "";
        

        private int enemyListPosition = 0;
        private int enemyArrPosition = 0;

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        };

        public Dungeon()
        {

        }

        public void GenerateMap(string map)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(map);
            string line;

            while((line = sr.ReadLine()) != null)
            {
                char[] temp = line.ToCharArray();
                this.map.Add(temp);
            }

            sr.Close();

        }

        public void PrintMap()
        {
            foreach (char[] item in map)
            {
                foreach (char ch in item)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public bool Spawn(Hero hero)
        {
            for (int i = 0; i < map.Count; i++)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    if (map[i][j].Equals('S'))
                    {
                        map[i][j] = 'H';

                        heroListPosition = i;
                        heroArrPosition = j;
                        this.hero = hero;

                        return true;
                    }
                }
            }
            
            return false;
        }

        public bool MoveHero(Direction direction)
        {
            if(gameState.Equals("defeat"))
            {
                Console.WriteLine("You cannot move your hero. He is dead!");
                return false;
            }

            if(direction.Equals(Direction.Down))
            {
                if(!MoveDown())
                {
                    return false;
                }
            }
            else if(direction.Equals(Direction.Up))
            {
                if(!MoveUp())
                {
                    return false;
                }
            }
            else if(direction.Equals(Direction.Left))
            {
                if(!MoveLeft())
                {
                    return false;
                }
            }
            else
            {
                if(!MoveRight())
                {
                    return false;
                }
            }

            if(gameState.Equals("defeat"))
            {
                map[heroListPosition][heroArrPosition] = 'L';
                return false;
            }

            hero.TakeMana();
            return true;
            
        }

        private bool MoveDown()
        {
            if ((heroListPosition + 1) >= map.Count)
            {
                return false;
            }
            else if (map[heroListPosition + 1][heroArrPosition].Equals('#'))
            {
                return false;
            }
            else if (map[heroListPosition + 1][heroArrPosition].Equals('T'))
            {
                PickTreasure();
            }
            else if (map[heroListPosition + 1][heroArrPosition].Equals('G'))
            {
                GameOver();
            }
            else if (map[heroListPosition + 1][heroArrPosition].Equals('E'))
            {
                HeroAttack();
            }
            map[heroListPosition][heroArrPosition] = '.';
            map[heroListPosition + 1][heroArrPosition] = 'H';
            heroListPosition++;

            return true;
        }

        private bool MoveUp()
        {
            if ((heroListPosition - 1) < 0)
            {
                return false;
            }
            else if (map[heroListPosition - 1][heroArrPosition].Equals('#'))
            {
                return false;
            }
            else if (map[heroListPosition - 1][heroArrPosition].Equals('T'))
            {
                PickTreasure();
            }
            else if (map[heroListPosition - 1][heroArrPosition].Equals('G'))
            {
                GameOver();
            }
            else if (map[heroListPosition - 1][heroArrPosition].Equals('E'))
            {
                HeroAttack();
            }
            map[heroListPosition][heroArrPosition] = '.';
            map[heroListPosition - 1][heroArrPosition] = 'H';
            heroListPosition--;

            return true;
        }

        private bool MoveLeft()
        {
            if ((heroArrPosition - 1) < 0)
            {
                return false;
            }
            else if (map[heroListPosition][heroArrPosition - 1].Equals('#'))
            {
                return false;
            }
            else if (map[heroListPosition][heroArrPosition - 1].Equals('T'))
            {
                PickTreasure();
            }
            else if (map[heroListPosition][heroArrPosition - 1].Equals('G'))
            {
                GameOver();
            }
            else if (map[heroListPosition][heroArrPosition - 1].Equals('E'))
            {
                HeroAttack();
            }

            map[heroListPosition][heroArrPosition] = '.';
            map[heroListPosition][heroArrPosition - 1] = 'H';
            heroArrPosition--;

            return true;
        }

        private bool MoveRight()
        {
            if (heroArrPosition >= map[heroListPosition].Length)
            {
                return false;
            }
            else if (map[heroListPosition][heroArrPosition + 1].Equals('#'))
            {
                return false;
            }
            else if (map[heroListPosition][heroArrPosition + 1].Equals('T'))
            {
                PickTreasure();
            }
            else if (map[heroListPosition][heroArrPosition + 1].Equals('G'))
            {
                GameOver();
            }
            else if (map[heroListPosition][heroArrPosition + 1].Equals('E'))
            {
                HeroAttack();
            }
            map[heroListPosition][heroArrPosition] = '.';
            map[heroListPosition][heroArrPosition + 1] = 'H';
            heroArrPosition++;

            return true;
        }

        private void PickTreasure()
        {
            string foundTreasure = treasure[rnd.Next(treasure.Count)];

            if(foundTreasure.Equals(treasure[0]))
            {
                hero.TakeHealing(10);

                Console.WriteLine("Found health potion! Hero health is {0}.", hero.GetHealth());
            }
            else if(foundTreasure.Equals(treasure[1]))
            {
                hero.TakeMana(10);

                Console.WriteLine("Found mana potion! Hero mana is {0}.", hero.GetMana());
            }
            else
            {
                Console.WriteLine("Found treasure! Treasure chest is empty!");
            }
        }

        public void HeroAttack()
        {
            if (EnemyCheck())
            {
                enemy = new Enemy(100, 100, 20);
                Spell attackSpell = hero.GetLearnedSpell();
                Weapon attackWeapon = hero.GetEquipedWeapon();

                Console.WriteLine
                    ("Enemy found! A fight is started between our Hero(health=100, mana=100) and Enemy(health=100, mana=100, damage=20)");
                
                while(true)
                {
                    if(!enemy.IsAlive())
                    {
                        Console.WriteLine("Enemy is dead!");
                        gameState = "victory";
                        break;
                    }
                    else if (!hero.IsAlive())
                    {
                        Console.WriteLine("Hero is dead!");
                        gameState = "defeat";
                        break;
                    }
                    else
                    {
                        if (hero.GetHeroSpellDmg() >= hero.GetHeroWeaponDmg() && hero.ManaCost())
                        {
                            enemy.TakeDamage(attackSpell.GetDamage());
                            Console.WriteLine("Hero cast a {0}, hit enemy for {1} dmg. Enemy health is {2}",
                                attackSpell.GetName(), attackSpell.GetDamage(), enemy.GetHealth());
                        }
                        else
                        {
                            enemy.TakeDamage(attackWeapon.weaponDamage);
                            Console.WriteLine("Hero hits with Axe for {0} dmg. Enemy health is {1}",
                                attackWeapon.weaponDamage, enemy.GetHealth());
                        }
                        
                        hero.TakeMana();

                        EnemyAttack();

                    }
                }
                
            }
            else
            {
                Console.WriteLine("No enemy has been found! Nothing is in cast range {0}", hero.CastRange());
            }
        }

        public void EnemyAttack()
        {
            if((enemyArrPosition + 1) == heroArrPosition || (enemyArrPosition - 1) == heroArrPosition)
            {
                hero.TakeDamage(enemy.GetDamage());
                Console.WriteLine("Enemy hits hero for {0} dmg. Hero health is {1} dmg.",
                    enemy.GetDamage(), hero.GetHealth());
            }
            else if (enemyArrPosition < heroArrPosition)
            {
                map[enemyListPosition][enemyArrPosition] = '.';
                enemyArrPosition++;
                Console.WriteLine("Enemy moves one square to the left in order to get to the hero. This is his move.");
            }
            else if (enemyArrPosition > heroArrPosition)
            {
                map[enemyListPosition][enemyArrPosition] = '.';
                enemyArrPosition--;
                Console.WriteLine("Enemy moves one square to the right in order to get to the hero. This is his move.");
            }
        }

        public bool EnemyCheck()
        {
            int tempPosition = heroArrPosition + 1;

            while(true)
            {
                if(tempPosition < map[heroListPosition].Length)
                {
                    if(tempPosition <= heroArrPosition + hero.CastRange())
                    {
                        if (map[heroListPosition][tempPosition].Equals('E'))
                        {
                            enemyArrPosition = tempPosition;
                            enemyListPosition = heroListPosition;

                            return true;
                        }

                        tempPosition++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
                
            }

            tempPosition = heroArrPosition - 1;

            while (true)
            {
                if(tempPosition >= 0)
                {
                    if(tempPosition >= heroArrPosition - hero.CastRange())
                    {
                        if (map[heroListPosition][tempPosition].Equals('E'))
                        {
                            enemyListPosition = heroListPosition;
                            enemyArrPosition = tempPosition;

                            return true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            
            return false;
        }

        private void GameOver()
        {
            Console.WriteLine("Game over!");
            
        }
    }
}
