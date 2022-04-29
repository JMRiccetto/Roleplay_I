
using System;
using System.Linq;

namespace Roleplay
{
    public class Elf
    {
        private string name;
        private int health = 80;
        public Boots boots;
        public Bow bow;

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
        //item ofensivo

        //cambio item
        public void ChangeBow(Bow bow)
        {
            this.bow = bow;
        }
        //remover item
        public void RemoveBow(Bow bow)
        {
            this.bow = null;
        }
        //item defensivo

        //cambiar item
        public void ChangeBoots(Boots boots)
        {
            this.boots = boots;
        }
        //remover item
        public void RemoveBoots(Boots boots)
        {
            this.boots = null;
        }
        
        public int GetAttack()  
        {   
            int totalDamage = 10;     //daño default (aunque no tenga item equipado)

            if (this.bow != null)
            {
                totalDamage += this.bow.AttackValue; 
                return totalDamage;  
            }
            return totalDamage;
        }

        public void Heal()
        {
            this.health = 80;
        }

        public string GetString()
        {
            return ($" Elfo: {this.name} \n Vida: {this.health} \n Botas: {this.boots} \n Arco: {this.bow} \n");
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
        }

         public void attackWizard(Wizard wizard)
        {      
            if (wizard.SpellBook.spell != null)
            {
                if ((wizard.Health > 0) && (this.GetAttack() > wizard.SpellBook.spell.DefenseValue))
                {                  
                    wizard.Health -= (this.GetAttack() - wizard.SpellBook.spell.DefenseValue);                    
                }
            }    
        }

        public void attackElf(Elf elf)
        {      
            if (elf.boots != null)
            {
                if ((elf.Health > 0) && (this.GetAttack() > elf.boots.DefenseValue))
                {                  
                    elf.Health -= (this.GetAttack() - elf.boots.DefenseValue);                    
                }
            }    
        }

         public void attackDwarf(Dwarf dwarf)
        {      
            if (dwarf.shield != null)
            {
                if ((dwarf.Health > 0) && (this.GetAttack() > dwarf.shield.DefenseValue))
                {                  
                    dwarf.Health -= (this.GetAttack() - dwarf.shield.DefenseValue);                    
                }
            }    
        }
    }
}

