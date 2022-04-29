using System;

namespace Roleplay
{
    public class Spell
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