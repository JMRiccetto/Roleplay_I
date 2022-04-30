using NUnit.Framework;
using Roleplay;

namespace Test.Library
{
    public class BowTest
    {
        // Testea el metodo AttackValue si attackValue es positivo.
        [Test]
        public void attackValueTest1()
        {
            Bow bow = new Bow(20,0);
            int expected = 20;
            int actual = bow.AttackValue;
            Assert.AreEqual(expected,actual);
        }

        // Testea el metodo AttackValue si attackValue es negativo.
        [Test]
        public void attackValueTest2()
        {
            Bow bow = new Bow(-20,0);
            int expected = 0;
            int actual = bow.AttackValue;
            Assert.AreEqual(expected,actual);
        }

        // Testea el metodo DefenseValue si defenseValue es positivo.
        [Test]
        public void defenseValueTest1()
        {
            Bow bow = new Bow(0,20);
            int expected = 20;
            int actual = bow.DefenseValue;
            Assert.AreEqual(expected,actual);
        }

        // Testea el metodo DefenseValue si defenseValue es negativo.
        [Test]
        public void defenseValueTest2()
        {
            Bow bow = new Bow(0,-20);
            int expected = 0;
            int actual = bow.DefenseValue;
            Assert.AreEqual(expected,actual);
        }
    }
}