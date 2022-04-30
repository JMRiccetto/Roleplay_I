
using System;
using System.Linq;

namespace Roleplay
{
    public class Elf
    {
        private string name;
        private int health = 80;
        public Boots Boots;
        public Bow Bow;

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

        public Elf(string aName)
        {
            aName = name;
        }

        public void ChangeBow(Bow bow)
        {
            this.Bow = bow;
        }

        public void RemoveBow(Bow bow)
        {
            this.Bow = null;
        }

        public void ChangeBoots(Boots boots)
        {
            this.Boots = boots;
        }

        public void RemoveBoots()
        {
            this.Boots = null;
        }
        
        public int GetAttack(Bow bow)
        {
            return this.Bow.AttackValue;
        }

        public void DamageReceived(int damage)
        {
            int totalDefense = this.Bow.defenseValue + this.Boots.DefenseValue;
            if( totalDefense < damage)
            {
                damage -= totalDefense;
                this.health -= damage;
            }
        }

        public void Heal()
        {
            this.health = 80;
        }

        public string GetString()
        {
            return ($" Elfo: {this.name} \n Vida: {this.health} \n Botas: {this.Boots} \n Arco: {this.Bow} \n");
        }
   }
}