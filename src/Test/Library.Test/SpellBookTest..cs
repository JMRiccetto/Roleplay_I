using NUnit.Framework;
using Roleplay;

namespace Test.Library
{
    public class SpellBookTest
    {
        private Spell spell;
        private SpellBook spellBook;

        [SetUp]
        public void SetUp()
        {
            this.spell = new Spell("Fireball", 30);
            this.spellBook = new SpellBook();
        }

        //Test que demuestra que el spellBook no posee nada al momento de crearse.
        [Test]
        public void NullSpellTest()
        {
            Assert.IsNull(this.spellBook.spell);
        }

        //Test que demustra que un spell se agrega correctamente.
        [Test]
        public void AddSpellTest()
        {
            this.spellBook.AddSpell(this.spell);
            Assert.IsNotNull(this.spellBook.spell);
        }

        //Test que demuestra que el spell que se crea por fuera y el que se agrega son el mismo.
        [Test]
        public void CastValidSpellTest()
        {
            this.spellBook.AddSpell(this.spell);
            Assert.AreEqual(this.spellBook.spell, this.spell);
        }

        //Test que demuestra que no puede utilizarse un spell nulo.
        [Test]
        public void CastInvalidSpellTest()
        {
            Assert.AreNotEqual(this.spellBook.spell, this.spell);
        }
    }
}