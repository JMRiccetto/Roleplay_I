using System;

namespace Roleplay
{
    public class Wizard
    {
        //Nombre del wizard.
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

        //Vida base del wizard.
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

        //Objeto de clase Cape que el wizard posee.
        public Cape Cape;
        
        //Objeto de clase SpellBook que el wizard posee.
        public SpellBook SpellBook;

        public Wizard(string aName, SpellBook aSpellBook)
        {
            this.name = aName;
            this.SpellBook = aSpellBook;
        }

        //Método para que el wizard cambie su cape.
        public void ChangeCape(Cape cape)
        {
            this.Cape = cape;
        }

        //Método para que el wizard se saque su cape.
        public void RemoveCape()
        {
            this.Cape = null;
        }
        
        //Método para calcular el ataque del wizard.
        public int GetAttack()
        {
            //Decidimos agregarle un ataque base a los personajes.
            int totalDamage = 15;

            if (this.SpellBook.spell != null)
            {
                totalDamage += this.SpellBook.spell.AttackValue; 
                return totalDamage;  
            }
            return totalDamage;
        }

        //Método para que el wizard pueda atacar a un warrior.
        public void attackWarrior(Warrior warrior)
        {      
            if (warrior.Breastplate != null)
            {
                if ((warrior.Health > 0) && (this.GetAttack() > warrior.Breastplate.DefenseValue))
                {                  
                    warrior.Health -= (this.GetAttack() - warrior.Breastplate.DefenseValue);                    
                }
            }
            else
            {
                warrior.Health -= this.GetAttack();
            }
        }

        //Méotodo para que un wizard pueda atacar a otro wizard.
        public void attackWizard(Wizard wizard)
        {      
            if (wizard.Cape != null)
            {
                if ((wizard.Health > 0) && (this.GetAttack() > wizard.Cape.DefenseValue))
                {                  
                    wizard.Health -= (this.GetAttack() - wizard.Cape.DefenseValue);                    
                }
            }
            else
            {
                wizard.Health -= this.GetAttack();
            } 
        }

        //Méotodo para que un wizard pueda atacar a un dwarf.
        public void attackDwarf(Dwarf dwarf)
        {      
            if (dwarf.Shield != null)
            {
                if ((dwarf.Health > 0) && (this.GetAttack() > dwarf.Shield.DefenseValue))
                {                  
                    dwarf.Health -= (this.GetAttack() - dwarf.Shield.DefenseValue);                    
                }
            }
            else
            {
                dwarf.Health -= this.GetAttack();
            } 
        }

        //Méotodo para que un wizard pueda atacar a un elf.
        public void attackElf(Elf elf)
        {      
            if (elf.Boots != null)
            {
                if ((elf.Health > 0) && (this.GetAttack() > elf.Boots.DefenseValue))
                {                  
                    elf.Health -= (this.GetAttack() - elf.Boots.DefenseValue);                    
                }
            }
            else
            {
                elf.Health -= this.GetAttack();
            } 
        }

        //El personaje es curado, devolviendo su vida al máximo.
        public void Heal()
        {
            this.health = 70;
        }
    }
}