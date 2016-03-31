using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Hero
    {
        private readonly int MAX_HEALTH = 100;
        private readonly int MAX_MANA = 100;

        private String name;
        private String classTitle;
        private int health;
        private int mana;
        private int manaRegenRate;
        private Weapon weapon;
        private Spell spell;
        private int heroSpellDamage;
        private int heroWeaponDamage;

        public Hero(string name, string classTitle, int health, int mana, int manaRegenRate)
        {
            this.name = name;
            this.classTitle = classTitle;
            this.health = health;
            this.mana = mana;
            this.manaRegenRate = manaRegenRate;
        }

        public void KnownAs()
        {
            string knownAs = String.Format("{0} the {1}", this.name, this.classTitle);

            Console.WriteLine(knownAs);
        }

        public int GetHealth()
        {
            return this.health;
        }

        public int GetMana()
        {
            return this.mana;
        }

        public bool IsAlive()
        {
            if (this.GetHealth() > 0)
            {
                return true;
            }

            return false;
        }

        public bool CanCast()
        {
            if (this.GetMana() > 0)
            {
                return true;
            }

            return false;
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

        public void TakeHealing(int heal)
        {
            if(health <= 0)
            {
                IsAlive();
            }
            else if ((heal + health) > MAX_HEALTH)
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

        public void TakeMana()
        {
            if(mana < 0)
            {
                mana = 0;
                mana += manaRegenRate;
            }
            else if (mana + manaRegenRate > MAX_MANA)
            {
                mana = MAX_MANA;
            }
            else
            {
                mana += manaRegenRate;
            }
        }

        public void Equip(Weapon weapon)
        {
            this.weapon = weapon;
            this.heroWeaponDamage = weapon.weaponDamage;
        }

        public void Learn(Spell spell)
        {
            this.spell = spell;
            this.heroSpellDamage = spell.GetDamage();
        }

        public int Attack(Weapon weapon)
        {
            return weapon.weaponDamage;
        }

        public int Attack(Spell spell)
        {
            return spell.GetDamage();
        }

        public bool ManaCost()
        {
            if(spell.GetManaCost() > mana)
            {
                return false;
            }
            else
            {
                mana -= spell.GetManaCost();
            }

            return true;
        }

        public int CastRange()
        {
            return spell.GetCastRange();
        }

        public Spell GetLearnedSpell()
        {
            return this.spell;
        }

        public Weapon GetEquipedWeapon()
        {
            return this.weapon;
        }

        public int GetHeroWeaponDmg()
        {
            return this.heroWeaponDamage;
        }

        public int GetHeroSpellDmg()
        {
            return this.heroSpellDamage;
        }
    }
}
