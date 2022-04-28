using System;
using System.Collections.Generic;

namespace Roleplay
{
    public class SpellBook
    {
        public Spell spell;

        public List<Spell> SpellList;

        public SpellBook(List<Spell> spellList)
        {
            this.SpellList = spellList;
        }

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