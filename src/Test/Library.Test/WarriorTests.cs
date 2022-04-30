using NUnit.Framework;
using Roleplay;
using System.Collections.Generic;

namespace Test.Library
{


    public class WarriorTest
    {

        
        // Name tests.


        // Testea si el nombre es valido.
        [Test]
        public void validNameTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            string expected = "Ragnar";
            string actual = warrior.Name;
            Assert.AreEqual(expected,actual);
        }

        // Testea si el nombre no es valido.
        [Test]
        public void noValidName1Test()
        {
            Warrior warrior = new Warrior("");
            string expected = "";
            string actual = warrior.Name;
            Assert.AreEqual(expected, actual);
        }

        // Testea si el nombre no es valido.
        [Test]
        public void noValidName2Test()
        {
            Warrior warrior = new Warrior(null);
            string expected = null;
            string actual = warrior.Name;
            Assert.AreEqual(expected, actual);
        }


        // Health tests.


        // Testea la vida del personaje sin items.
        [Test]
        public void healthTestWithoutItemsTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            int expected = 100;
            int actual = warrior.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea la vida del personaje con items.
        [Test]
        public void healthTestWithItemsTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            Sword sword = new Sword(20,0);
            Breastplate breastplate = new Breastplate(0,20);
            warrior.ChangeSword(sword);
            warrior.ChangeBreastplate(breastplate);
            int expected = 100;
            int actual = warrior.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo Heal.
        [Test]
        public void HealTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            warrior.Health = 20;
            warrior.Heal();
            int expected = 100;
            int actual = warrior.Health;
            Assert.AreEqual(expected, actual);
        }


        // Item tests.


        // Testea si el item "Sword" es null cuando se crea el personaje.
        [Test]
        public void isNullSwordTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            Assert.IsNull(warrior.Sword);
        }

        // Testea el metodo ChangeSword.
        [Test]
        public void changeSwordTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            Sword sword = new Sword(20,0);
            warrior.ChangeSword(sword);
            Assert.IsNotNull(warrior.Sword);
        }

        // Testea el metodo RemoveSword.
        [Test]
        public void removeSwordTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            Sword sword = new Sword(20,0);
            warrior.ChangeSword(sword);
            warrior.RemoveSword();
            Assert.IsNull(warrior.Sword);
        }

        // Testea si el item "Breastplate" es null cuando se crea el personaje.
        [Test]
        public void isNullBreastplateTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            Assert.IsNull(warrior.Breastplate);
        }

        // Testea el metodo ChangeBreastplate.
        [Test]
        public void changeBreastplateTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            Breastplate breastplate = new Breastplate(0,20);
            warrior.ChangeBreastplate(breastplate);
            Assert.IsNotNull(warrior.Breastplate);
        }

        // Testea el metodo RemoveBreastplate.
        [Test]
        public void removeBreastplateTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            Breastplate breastplate = new Breastplate(0,20);
            warrior.ChangeBreastplate(breastplate);
            warrior.RemoveBreastplate();
            Assert.IsNull(warrior.Sword);
        }


        // GetAttack() method tests.


        // Testea el valor de ataque default cuando el personaje no tiene items.
        [Test]
        public void attackValueWithoutItemsTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            int expected = 15;
            int actual = warrior.GetAttack();
            Assert.AreEqual(expected, actual);
        }

        // Testea el valor de ataque de un personaje con items.
        [Test]
        public void attackValueWithItemsTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            Sword sword = new Sword(20,0);
            Breastplate breastplate = new Breastplate(0,20);
            warrior.ChangeSword(sword);
            warrior.ChangeBreastplate(breastplate);
            int expected = 35;
            int actual = warrior.GetAttack();
            Assert.AreEqual(expected, actual);
        }


        // attackWarrior method tests. 


        // Testea el metodo attackWrrior con ambos personajes sin items.
        [Test]
        
        public void attackWarrior1Test()    
        {
            Warrior warrior1 = new Warrior("Ragnar");
            Warrior warrior2 = new Warrior("Bjorn");
            warrior1.attackWarrior(warrior2);
            int expected = 85;
            int actual = warrior2.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende sin item de defensa.
        [Test]

        public void attackWarrior2Test()    
        {
            Warrior warrior1 = new Warrior("Ragnar");
            Warrior warrior2 = new Warrior("Bjorn");
            Sword sword = new Sword(20,0);
            warrior1.ChangeSword(sword);
            warrior1.attackWarrior(warrior2);
            int expected = 65;
            int actual = warrior2.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca sin item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackWarrior3Test()    
        {
            Warrior warrior1 = new Warrior("Ragnar");
            Warrior warrior2 = new Warrior("Bjorn");
            Breastplate breastplate = new Breastplate(0,20);
            warrior2.ChangeBreastplate(breastplate);
            warrior1.attackWarrior(warrior2);
            int expected = 100;
            int actual = warrior2.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackWarrior4Test()    
        {
            Warrior warrior1 = new Warrior("Ragnar");
            Warrior warrior2 = new Warrior("Bjorn");
            Sword sword = new Sword(25,0);
            Breastplate breastplate = new Breastplate(0,20);
            warrior1.ChangeSword(sword);
            warrior2.ChangeBreastplate(breastplate);
            warrior1.attackWarrior(warrior2);
            int expected = 80;
            int actual = warrior2.Health;
            Assert.AreEqual(expected, actual);
        }


        // attackWizard method tests 


        // Testea el metodo attackWrrior con ambos personajes sin items.
        [Test]
        
        public void attackWizard1Test()    
        {
            Warrior warrior = new Warrior("Ragnar");
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Merlín", spellBook);
            warrior.attackWizard(wizard);
            int expected = 55;
            int actual = wizard.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende sin item de defensa.
        [Test]

        public void attackWizard2Test()    
        {
            Warrior warrior = new Warrior("Ragnar");           
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Merlín", spellBook);
            Sword sword = new Sword(20,0);
            warrior.ChangeSword(sword);
            warrior.attackWizard(wizard);
            int expected = 35;
            int actual = wizard.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca sin item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackWizard3Test()    
        {
            Warrior warrior = new Warrior("Ragnar"); 
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Merlín", spellBook);
            Cape cape = new Cape(0,15);
            wizard.ChangeCape(cape);
            warrior.attackWizard(wizard);
            int expected = 70;
            int actual = wizard.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackWizard4Test()    
        {
            Warrior warrior = new Warrior("Ragnar");
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Merlín", spellBook);
            Sword sword = new Sword(25,0);
            Cape cape = new Cape(0,15);
            warrior.ChangeSword(sword);
            wizard.ChangeCape(cape);
            warrior.attackWizard(wizard);
            int expected = 45;
            int actual = wizard.Health;
            Assert.AreEqual(expected, actual);
        }


        // attackElf method tests 


        // Testea el metodo attackWrrior con ambos personajes sin items.
        [Test]
        
        public void attackElf1Test()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Elf elf = new Elf("Dobby");
            warrior.attackElf(elf);
            int expected = 65;
            int actual = elf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende sin item de defensa.
        [Test]

        public void attackElf2Test()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Elf elf = new Elf("Dobby");
            Sword sword = new Sword(20,0);
            warrior.ChangeSword(sword);
            warrior.attackElf(elf);
            int expected = 45;
            int actual = elf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca sin item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackElf3Test()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Elf elf = new Elf("Dobby");
            Boots boots = new Boots(0,15);
            elf.ChangeBoots(boots);
            warrior.attackElf(elf);
            int expected = 80;
            int actual = elf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackElf4Test()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Elf elf = new Elf("Dobby");
            Sword sword = new Sword(25,0);
            Boots boots = new Boots(0,15);
            warrior.ChangeSword(sword);
            elf.ChangeBoots(boots);
            warrior.attackElf(elf);
            int expected = 55;
            int actual = elf.Health;
            Assert.AreEqual(expected, actual);
        }


        // attackDwarf


        // Testea el metodo attackWrrior con ambos personajes sin items.
        [Test]
        
        public void attackDwarf1Test()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Dwarf dwarf = new Dwarf("Grumpy");
            warrior.attackDwarf(dwarf);
            int expected = 95;
            int actual = dwarf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende sin item de defensa.
        [Test]

        public void attackDwarf2Test()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Dwarf dwarf = new Dwarf("Grumpy");
            Sword sword = new Sword(20,0);
            warrior.ChangeSword(sword);
            warrior.attackDwarf(dwarf);
            int expected = 75;
            int actual = dwarf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca sin item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackDwarf3Test()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Dwarf dwarf = new Dwarf("Grumpy");
            Shield shield = new Shield(0,15);
            dwarf.ChangeShield(shield);
            warrior.attackDwarf(dwarf);
            int expected = 110;
            int actual = dwarf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackDwarf4Test()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Dwarf dwarf = new Dwarf("Grumpy");
            Sword sword = new Sword(25,0);
            Shield shield = new Shield(0,15);
            warrior.ChangeSword(sword);
            dwarf.ChangeShield(shield);
            warrior.attackDwarf(dwarf);
            int expected = 85;
            int actual = dwarf.Health;
            Assert.AreEqual(expected, actual);
        }

    }   
} 