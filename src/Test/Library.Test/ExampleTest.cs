using NUnit.Framework;
using Roleplay;

namespace Test.Library
{


    public class ExampleTest
    {


        //Tests del personaje Warrior 

        [Test]
        public void validName()
        {
            Warrior warrior = new Warrior("Ragnar");
            string expected = "Ragnar";
            string actual = warrior.Name;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void noValidName1()
        {
            Warrior warrior = new Warrior("");
            string expected = null;
            string actual = warrior.Name;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void noValidName2()
        {
            Warrior warrior = new Warrior(null);
            string expected = null;
            string actual = warrior.Name;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void healthTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            int expected = 100;
            int actual = warrior.Health;
            Assert.AreEqual(expected, actual);
        }

         [Test]
        public void swordTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            int expected = 100;
            int actual = warrior.Health;
            Assert.AreEqual(expected, actual);
        }

    }

}