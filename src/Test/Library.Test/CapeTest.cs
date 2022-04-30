using NUnit.Framework;
using Roleplay;

namespace Test.Library
{
    public class CapeTest
    {
        private Cape cape;

        [SetUp]
        public void SetUp()
        {
            this.cape = new Cape(0, 10);
        }

        //Test que demuestra que el ataque base funciona correctamente.
        [Test]
        public void ValidAttackTest()
        {
            Assert.AreEqual(this.cape.AttackValue, 0);
        }

        //Test que comprueba que el ataque no pueda ir por debajo de 0.
        [Test]
        public void InvalidAttackTest()
        {
            this.cape.AttackValue = -30;
            Assert.AreEqual(this.cape.AttackValue, 0);
        }

        //Test que demuestra que la defensa base funciona correctamente.
        [Test]
        public void ValidDefenseTest()
        {
            Assert.AreEqual(this.cape.DefenseValue, 10);
        }

        //Test que comprueba que la defensa no pueda ir por debajo de 0.
        [Test]
        public void InvalidDefenseTest()
        {
            this.cape.DefenseValue = -30;
            Assert.AreEqual(this.cape.DefenseValue, 0);
        }
    }
}