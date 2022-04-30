using NUnit.Framework;
using Roleplay;

namespace Test.Library
{
    public class BootsTest
    {
        // Testea el metodo AttackValue si attackValue es positivo.
        [Test]
        public void attackValueTest1()
        {
            Boots boots = new Boots(20,0);
            int expected = 20;
            int actual = boots.AttackValue;
            Assert.AreEqual(expected,actual);
        }

        // Testea el metodo AttackValue si attackValue es negativo.
        [Test]
        public void attackValueTest2()
        {
            Boots boots = new Boots(-20,0);
            int expected = 0;
            int actual = boots.AttackValue;
            Assert.AreEqual(expected,actual);
        }

        // Testea el metodo DefenseValue si defenseValue es positivo.
        [Test]
        public void defenseValueTest1()
        {
            Boots boots = new Boots(0,20);
            int expected = 20;
            int actual = boots.DefenseValue;
            Assert.AreEqual(expected,actual);
        }

        // Testea el metodo DefenseValue si defenseValue es negativo.
        [Test]
        public void defenseValueTest2()
        {
            Boots boots = new Boots(0,-20);
            int expected = 0;
            int actual = boots.DefenseValue;
            Assert.AreEqual(expected,actual);
        }
    }
}