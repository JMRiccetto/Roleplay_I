using System;

namespace Roleplay
{
    //Clase que a efectos prácticos funciona como armas, pero que deben ser almacenados en un libro de hechizos.
    public class Spell
    {
        //Nombre del Spell.
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

        //Valor de ataque del Spell.
        private int attackValue;

        public int AttackValue
        {
            get
            {
                return this.attackValue;
            }

            set
            {
                if (value > 0)
                {
                    this.attackValue = value;
                }
                else
                {
                    this.attackValue = 0;
                }
            }
        }

        public Spell(string aName, int aAttackValue)
        {
            this.name = aName;
            this.attackValue = aAttackValue;
        }
    }
}