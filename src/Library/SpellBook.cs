using System;
using System.Collections.Generic;

namespace Roleplay
{
    //Esta clase contiene Spells que serán utilizados como la herramienta del mago para atacar,
    //no posee un método que remueva los Spells ya que suena absurdo que un mago borre uno de sus hechizos de un libro mágico.
    public class SpellBook
    {
        public Spell spell;

        List<Spell> SpellList = new List<Spell>();
        
        //El mago aprende un nuevo Spell y este se agrega a su libro
        public void AddSpell(Spell spell)
        {
            this.SpellList.Add(spell);
        }

        //El mago decide que hechizo utilizar.
        public void CastSpell(Spell spell)
        {
            if (SpellList.Contains(spell))
            {
                this.spell = spell;
            }
        }
    }
}