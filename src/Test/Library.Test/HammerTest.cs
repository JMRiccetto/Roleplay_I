using NUnit.Framework;
using Roleplay;

namespace Test.Library
{
    public class HammerTest
    {
        // Testea el metodo AttackValue si attackValue es positivo.
        [Test]
        public void attackValueTest1()
        {
            Hammer hammer = new Hammer(20,0);
            int expected = 20;
            int actual = hammer.AttackValue;
            Assert.AreEqual(expected,actual);
        }

        // Testea el metodo AttackValue si attackValue es negativo.
        [Test]
        public void attackValueTest2()
        {
            Hammer hammer = new Hammer(-20,0);
            int expected = 0;
            int actual = hammer.AttackValue;
            Assert.AreEqual(expected,actual);
        }

        // Testea el metodo DefenseValue si defenseValue es positivo.
        [Test]
        public void defenseValueTest1()
        {
            Hammer hammer = new Hammer(0,20);
            int expected = 20;
            int actual = hammer.DefenseValue;
            Assert.AreEqual(expected,actual);
        }

        // Testea el metodo DefenseValue si defenseValue es negativo.
        [Test]
        public void defenseValueTest2()
        {
            Hammer hammer = new Hammer(0, -20);           
            int expected = 0;
            int actual = hammer.DefenseValue;
            Assert.AreEqual(expected,actual);
        }
    }
}