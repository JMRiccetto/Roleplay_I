using NUnit.Framework;
using Roleplay;
using System.Collections.Generic;

namespace Test.Library
{
    public class Test
    {
        //Tests Elf. 
        // Name tests.
        // Testea si el nombre es valido.
        [Test]
        public void validNameTest()
        {
            Elf elf = new Elf("Fernando");
            string expected = "Fernando";
            string actual = elf.Name;
            Assert.AreEqual(expected,actual);
        }

        // Testea si el nombre no es valido.
        [Test]
        public void noValidName1Test()
        {
            Elf elf = new Elf("");
            string expected = "";
            string actual = elf.Name;
            Assert.AreEqual(expected, actual);
        }

        // Testea si el nombre no es valido.
        [Test]
        public void noValidName2Test()
        {
            Elf elf = new Elf(null);
            string expected = null;
            string actual = elf.Name;
            Assert.AreEqual(expected, actual);
        }

        // Health tests.

        // Testea la vida del personaje sin items.
        [Test]
        public void healthTestWithoutItemsTest()
        {
            Elf elf = new Elf("Fernando");
            int expected = 75;
            int actual = elf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea la vida del personaje con items.
        [Test]
        public void healthTestWithItemsTest()
        {
            Elf elf = new Elf("Fernando");
            Bow bow = new Bow(15,0);
            Boots boots = new Boots(0,15);
            elf.ChangeBow(bow);
            elf.ChangeBoots(boots);
            int expected = 75;
            int actual = elf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Item tests.

        // Testea si el item "Bow" es null cuando se crea el personaje.
        [Test]
        public void isNullBowTest()
        {
            Elf elf = new Elf("Fernando");
            Assert.IsNull(elf.Bow);
        }

        // Testea el metodo ChangeBow.
        [Test]
        public void changeBowTest()
        {
            Elf elf = new Elf("Fernando");
            Bow bow = new Bow(15,0);
            elf.ChangeBow(bow);
            Assert.IsNotNull(elf.Bow);
        }

        // Testea el metodo RemoveBow.
        [Test]
        public void removeBowTest()
        {
            Elf elf = new Elf("Fernando");
            Bow bow = new Bow(15,0);
            elf.ChangeBow(bow);
            elf.RemoveBow(bow);
            Assert.IsNull(elf.Bow);
        }

        // Testea si el item "Boots" es null cuando se crea el personaje.
        [Test]
        public void isNullBootsTest()
        {
            Elf elf = new Elf("Fernando");
            Assert.IsNull(elf.Boots);
        }

        // Testea el metodo ChangeBoots.
        [Test]
        public void changeBootsTest()
        {
            Elf elf = new Elf("Fernando");
            Boots boots = new Boots(0,15);
            elf.ChangeBoots(boots);
            Assert.IsNotNull(elf.Boots);
        }

        // Testea el metodo RemoveBoots.
        [Test]
        public void removeBootsTest()
        {
            Elf elf = new Elf("Fernando");
            Boots boots = new Boots(0,15);
            elf.ChangeBoots(boots);
            elf.RemoveBoots();
            Assert.IsNull(elf.Bow);
        }


        // GetAttack() method tests.


        // Testea el valor de ataque default cuando el personaje no tiene items.
        [Test]
        public void attackValueWithoutItemsTest()
        {
            Elf elf = new Elf("Fernando");
            int expected = 10;
            int actual = elf.GetAttack();
            Assert.AreEqual(expected, actual);
        }

        // Testea el valor de ataque de un personaje con items.
        [Test]
        public void attackValueWithItemsTest()
        {
            Elf elf = new Elf("Fernando");
            Bow bow = new Bow(15,0);
            Boots boots = new Boots(0,15);
            elf.ChangeBow(bow);
            elf.ChangeBoots(boots);
            int expected = 25;
            int actual = elf.GetAttack();
            Assert.AreEqual(expected, actual);
        }


        // attackElf method tests. 


        // Testea el metodo attackWrrior con ambos personajes sin items.
        [Test]
        
        public void attackWarrior1Test()    
        {
            Elf elf = new Elf("Fernando");
            Warrior warrior = new Warrior("Bjorn");
            elf.attackWarrior(warrior);
            int expected = 90;
            int actual = warrior.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende sin item de defensa.
        [Test]

        public void attackWarrior2Test()    
        {
            Elf elf = new Elf("Fernando");
            Warrior warrior = new Warrior("Bjorn");
            Bow bow= new Bow(25,0);
            elf.ChangeBow(bow);
            elf.attackWarrior(warrior);
            int expected = 65;
            int actual = warrior.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca sin item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackWarrior3Test()    
        {
            Elf elf = new Elf("Fernando");
            Warrior warrior = new Warrior("Bjorn");
            Breastplate breastplate = new Breastplate(0,20);
            warrior.ChangeBreastplate(breastplate);
            elf.attackWarrior(warrior);
            int expected = 100;
            int actual = warrior.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackWarrior4Test()    
        {
            Elf elf = new Elf("Fernando");
            Warrior warrior = new Warrior("Bjorn");
            Bow bow= new Bow(25,0);
            Breastplate breastplate = new Breastplate(0,20);
            elf.ChangeBow(bow);
            warrior.ChangeBreastplate(breastplate);
            elf.attackWarrior(warrior);
            int expected = 85;
            int actual = warrior.Health;
            Assert.AreEqual(expected, actual);
        }


        // attackWizard method tests 


        // Testea el metodo attackWizard con ambos personajes sin items.
        [Test]
        
        public void attackWizard1Test()    
        {
            Elf elf = new Elf("Fernando");
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Merlín", spellBook);
            elf.attackWizard(wizard);
            int expected = 60;
            int actual = wizard.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWizard con el personaje que ataca con item de ataque y el que se defiende sin item de defensa.
        [Test]

        public void attackWizard2Test()    
        {
            Elf elf = new Elf("Fernando");           
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Merlín", spellBook);
            Bow bow = new Bow(15,0);
            elf.ChangeBow(bow);
            elf.attackWizard(wizard);
            int expected = 45;
            int actual = wizard.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWizard con el personaje que ataca sin item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackWizard3Test()    
        {
            Elf elf = new Elf("Fernando"); 
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Merlín", spellBook);
            Cape cape = new Cape(0,15);
            wizard.ChangeCape(cape);
            elf.attackWizard(wizard);
            int expected = 70;
            int actual = wizard.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWizard con el personaje que ataca con item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackWizard4Test()    
        {
            Elf elf = new Elf("Fernando");
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Merlín", spellBook);
            Bow bow = new Bow(25,0);
            Cape cape = new Cape(0,15);
            elf.ChangeBow(bow);
            wizard.ChangeCape(cape);
            elf.attackWizard(wizard);
            int expected = 50;
            int actual = wizard.Health;
            Assert.AreEqual(expected, actual);
        }


        // attackElf method tests 


        // Testea el metodo attackElf con ambos personajes sin items.
        [Test]
        
        public void attackElf1()    
        {
            Elf elf = new Elf("Fernando");
            Elf elf2 = new Elf("Almos");
            elf.attackElf(elf);
            int expected = 65;
            int actual = elf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackElf con el personaje que ataca con item de ataque y el que se defiende sin item de defensa.
        [Test]

        public void attackElf2()    
        {
            Elf elf = new Elf("Fernando");
            Elf elf2 = new Elf("Almos");
            Bow bow = new Bow(15,0);
            elf.ChangeBow(bow);
            elf.attackElf(elf);
            int expected = 50;
            int actual = elf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackElf con el personaje que ataca sin item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackElf3()    
        {
            Elf elf = new Elf("Fernando");
            Elf elf2 = new Elf("Almos");
            Boots boots = new Boots(0,15);
            elf.ChangeBoots(boots);
            elf.attackElf(elf);
            int expected = 75;
            int actual = elf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackElf con el personaje que ataca con item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackElf4()    
        {
            Elf elf = new Elf("Fernando");
            Elf elf2 = new Elf("Almos");
            Bow bow = new Bow(25,0);
            Boots boots = new Boots(0,15);
            elf.ChangeBow(bow);
            elf.ChangeBoots(boots);
            elf.attackElf(elf);
            int expected = 55;
            int actual = elf.Health;
            Assert.AreEqual(expected, actual);
        }


        // attackDwarf
        [Test]
        
        public void attackDwarf1Test()    
        {
            Elf elf = new Elf("Fernando");
            Dwarf dwarf = new Dwarf("Grumpy");
            elf.attackDwarf(dwarf);
            int expected = 100;
            int actual = dwarf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackDwarf con el personaje que ataca con item de ataque y el que se defiende sin item de defensa.
        [Test]

        public void attackDwarf2Test()    
        {
            Elf elf = new Elf("Fernando");
            Dwarf dwarf = new Dwarf("Grumpy");
            Bow bow = new Bow(15,0);
            elf.ChangeBow(bow);
            elf.attackDwarf(dwarf);
            int expected = 85;
            int actual = dwarf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackDwarf con el personaje que ataca sin item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackDwarf3Test()    
        {
            Elf elf = new Elf("Fernando");
            Dwarf dwarf = new Dwarf("Grumpy");
            Shield shield = new Shield(0,15);
            dwarf.ChangeShield(shield);
            elf.attackDwarf(dwarf);
            int expected = 110;
            int actual = dwarf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackDwarf con el personaje que ataca con item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackDwarf4Test()    
        {
            Elf elf = new Elf("Fernando");
            Dwarf dwarf = new Dwarf("Grumpy");
            Bow bow = new Bow(25,0);
            Shield shield = new Shield(0,15);
            elf.ChangeBow(bow);
            dwarf.ChangeShield(shield);
            elf.attackDwarf(dwarf);
            int expected = 90;
            int actual = dwarf.Health;
            Assert.AreEqual(expected, actual);
        }

    }   
} 
