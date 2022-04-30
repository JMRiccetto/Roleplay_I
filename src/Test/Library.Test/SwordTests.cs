using NUnit.Framework;
using Roleplay;

namespace Test.Library
{
    public class SwordTest
    {
        // Testea el metodo AttackValue si attackValue es positivo.
        [Test]
        public void attackValueTest1()
        {
            Sword sword = new Sword(20,0);
            int expected = 20;
            int actual = sword.AttackValue;
            Assert.AreEqual(expected,actual);
        }

        // Testea el metodo AttackValue si attackValue es negativo.
        [Test]
        public void attackValueTest2()
        {
            Sword sword = new Sword(-20,0);
            int expected = 0;
            int actual = sword.AttackValue;
            Assert.AreEqual(expected,actual);
        }

        // Testea el metodo DefenseValue si defenseValue es positivo.
        [Test]
        public void defenseValueTest1()
        {
            Sword sword = new Sword(0,20);
            int expected = 20;
            int actual = sword.DefenseValue;
            Assert.AreEqual(expected,actual);
        }

        // Testea el metodo DefenseValue si defenseValue es negativo.
        [Test]
        public void defenseValueTest2()
        {
            Sword sword = new Sword(0, -20);           
            int expected = 0;
            int actual = sword.DefenseValue;
            Assert.AreEqual(expected,actual);
        }
    }
}