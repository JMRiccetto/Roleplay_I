using System;
using System.Linq;

namespace Roleplay
{
    public class Wizard
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
            }
        }

        private int health = 70;

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                if (value > 0)
                {
                    this.health = value;
                }
                else
                {
                    health = 0;
                }
            }
        }

        public Cape Cape;
        
        public SpellBook SpellBook;

        public Wizard(string aName)
        {
            name = aName;
        }

        public void ChangeCape(Cape cape)
        {
            this.Cape = cape;
        }

        public void RemoveCape(Cape cape)
        {
            this.Cape = null;
        }
        
        public int GetAttack(Spell spell)
        {
            return this.SpellBook.spell.AttackValue;
        }

        public void DamageReceived(int damage)
        {
            int totalDefense = this.Cape.defenseValue + this.SpellBook.spell.DefenseValue;
            if( totalDefense < damage)
            {
                damage -= totalDefense;
                this.health -= damage;
            }
        }

        public void Heal()
        {
            this.health = 70;
        }
    }
}