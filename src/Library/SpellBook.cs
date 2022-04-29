using System;
using System.Collections.Generic;

namespace Roleplay
{
    public class SpellBook
    {
        public Spell spell;

        List<Spell> SpellList = new List<Spell>();

        public void AddSpell(Spell spell)
        {
            this.SpellList.Add(spell);
        }

        public void CastSpell(Spell spell)
        {
            if (SpellList.Contains(spell))
            {
                this.spell = spell;
            }
        }
    }
}