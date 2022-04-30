using NUnit.Framework;
using Roleplay;

namespace Test.Library
{
    public class ShieldTest
    {
        // Testea el metodo AttackValue si attackValue es positivo.
        [Test]
        public void attackValueTest1()
        {
            Shield shield = new Shield(20,0);
            int expected = 20;
            int actual = shield.AttackValue;
            Assert.AreEqual(expected,actual);
        }

        // Testea el metodo AttackValue si attackValue es negativo.
        [Test]
        public void attackValueTest2()
        {
            Shield shield = new Shield(-20,0);
            int expected = 0;
            int actual = shield.AttackValue;
            Assert.AreEqual(expected,actual);
        }

        // Testea el metodo DefenseValue si defenseValue es positivo.
        [Test]
        public void defenseValueTest1()
        {
            Shield shield = new Shield(0,20);
            int expected = 20;
            int actual = shield.DefenseValue;
            Assert.AreEqual(expected,actual);
        }

        // Testea el metodo DefenseValue si defenseValue es negativo.
        [Test]
        public void defenseValueTest2()
        {
            Shield shield = new Shield(0, -20);
            int expected = 0;
            int actual = shield.DefenseValue;
            Assert.AreEqual(expected,actual);
        }
    }
}
