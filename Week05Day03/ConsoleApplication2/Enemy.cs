using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Enemy
    {
        private readonly int MAX_HEALTH = 100;
        private readonly int MAX_MANA = 100;

        private int health;
        private int mana;
        private int damage;

        public Enemy(int health, int mana, int damage)
        {
            this.health = health;
            this.mana = mana;
            this.damage = damage;
        }

        public bool IsAlive()
        {
            if(health > 0)
            {
                return true;
            }

            return false;
        }

        public bool CanCast()
        {
            if(mana > 0)
            {
                return true;
            }

            return false;
        }

        public int GetHealth()
        {
            return health;
        }

        public int GetMana()
        {
            return mana;
        }

        public int GetDamage()
        {
            return damage;
        }

        public void TakeHealing(int heal)
        {
            if (health <= 0)
            {
                IsAlive();
            }
            else if(health + heal > MAX_HEALTH)
            {
                health = MAX_HEALTH;
            }
            else
            {
                health += heal;
            }
        }

        public void TakeMana(int mana)
        {
            if(this.mana + mana > MAX_MANA)
            {
                this.mana = MAX_MANA;
            }
            else if (this.mana < 0)
            {
                this.mana = 0;
                this.mana += mana;
            }
            else
            {
                this.mana += mana;
            }
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int damage)
        {
            if (damage > health)
            {
                health = 0;
            }
            else
            {
                health -= damage;
            }
        }
    }
}
