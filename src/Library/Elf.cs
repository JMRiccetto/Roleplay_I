using System;
using System.Linq;

namespace Roleplay
{
    public class Elf
    {
        private string name;
        private int health = 75;
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
            this.name = aName;
        }
        //item ofensivo

        //cambio item
        public void ChangeBow(Bow bow)
        {
            this.Bow = bow;
        }
        //remover item
        public void RemoveBow(Bow bow)
        {
            this.Bow = null;
        }
        //item defensivo

        //cambiar item
        public void ChangeBoots(Boots boots)
        {
            this.Boots = boots;
        }
        //remover item
        public void RemoveBoots()
        {
            this.Boots = null;
        }
        
        public int GetAttack()  
        {   
            int totalDamage = 10;     //daño default (aunque no tenga item equipado)

            if (this.Bow != null)
            {
                totalDamage += this.Bow.AttackValue; 
                return totalDamage;  
            }
            return totalDamage;
        }

        public void Heal()
        {
            this.health = 80;
        }
               //Metodos para atacar a otros personajes


        // Si el daño de ataque del personaje atacante es menor que el valor de defensa del item del personaje que se defiende,
        // entonces el ataque no tiene efecto. 
        // En cambio, si el daño de ataque del personaje atacante es mayor que el valor de defensa del item del personaje que se defiende,
        // entonces el daño recibido por el personaje va ser el daño de ataque del atacante menos el valor de defensa de su item.
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
    }
}
