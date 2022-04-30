using NUnit.Framework;
using Roleplay;

namespace Test.Library
{
    public class SpellTest
    {
        private Spell spell;

        [SetUp]
        public void SetUp()
        {
            this.spell = new Spell("Fireball", 30);
        }

        //Test que demuestra que no es posible asignar un nombre inválido.
        [Test]
        public void InvalidNameTest()
        {
            this.spell.Name = "";
            Assert.AreEqual(this.spell.Name, "Fireball");
        }

        //Test que demuestra que es posible asignar un nombre válido.
        [Test]
        public void ValidNameTest()
        {
            this.spell.Name = "Thunderbolt";
            Assert.AreEqual(this.spell.Name, "Thunderbolt");
        }

        //Test que demuestra que el ataque base funciona correctamente.
        [Test]
        public void ValidAttackTest()
        {
            Assert.AreEqual(this.spell.AttackValue, 30);
        }

        //Test que comprueba que el ataque no pueda ir por debajo de 0.
        [Test]
        public void InvalidAttackTest()
        {
            this.spell.AttackValue = -30;
            Assert.AreEqual(this.spell.AttackValue, 0);
        }
    }
}