using System;

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

        public Wizard(string aName, SpellBook aSpellBook)
        {
            this.name = aName;
            this.SpellBook = aSpellBook;
        }

        public void ChangeCape(Cape cape)
        {
            this.Cape = cape;
        }

        public void RemoveCape(Cape cape)
        {
            this.Cape = null;
        }
        
        public int GetAttack()
        {
            int totalDamage = 15;

            if (this.SpellBook.spell != null)
            {
                totalDamage += this.SpellBook.spell.AttackValue; 
                return totalDamage;  
            }
            return totalDamage;
        }

        public void attackWarrior(Warrior warrior)
        {      
            if (warrior.Breastplate != null)
            {
                if ((warrior.Health > 0) && (this.GetAttack() > warrior.Breastplate.DefenseValue))
                {                  
                    warrior.Health -= (this.GetAttack() - warrior.Breastplate.DefenseValue);                    
                }
            }    
        }

         public void attackWizard(Wizard wizard)
        {      
            if (wizard.SpellBook.spell != null)
            {
                if ((wizard.Health > 0) && (this.GetAttack() > wizard.Cape.DefenseValue))
                {                  
                    wizard.Health -= (this.GetAttack() - wizard.Cape.DefenseValue);                    
                }
            }    
        }

        
        public void Heal()
        {
            this.health = 70;
        }
    }
}