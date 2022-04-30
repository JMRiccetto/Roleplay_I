using System;

namespace Roleplay
{
    public class Warrior
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

        private int health = 100;

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
                    this.health = 0;
                }     
            }           
        }
        

        //Constructor
        public Warrior(string aName) 
        {
            this.name = aName;
        }
        
        // Item ofensivo
        public Sword Sword; 

        // Item defensivo
        public Breastplate Breastplate;

        // Cambiar item ofensivo
        public void ChangeSword(Sword sword)
        {
            this.Sword = sword;
        }

        // Remover item ofensivo
        public void RemoveSword()
        {
            if (this.Sword != null)
            {
                this.Sword = null;
            }
        }

        // Cambiar item defensivo
         public void ChangeBreastplate(Breastplate breastplate)
        {
            this.Breastplate = breastplate;
        }

        // Remover item defensivo
        public void RemoveBreastplate()
        {   
            if (this.Breastplate != null)
            {
                this.Breastplate = null;
            }
        }

        // Daño de ataque del personaje
        public int GetAttack()  
        {   
            int totalDamage = 15;     //daño default (aunque no tenga item equipado)

            if (this.Sword != null)
            {
                totalDamage += this.Sword.AttackValue; 
                return totalDamage;  
            }
            return totalDamage;
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

        public void Heal()
        {
            this.health = 100;
        }
    }
}