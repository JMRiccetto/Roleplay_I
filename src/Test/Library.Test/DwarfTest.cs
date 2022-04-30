using NUnit.Framework;
using Roleplay;
using System.Collections.Generic;

namespace Test.Library
{


    public class DwarfTest
    {

        
        // Name tests.


        // Testea si el nombre es valido.
        [Test]
        public void validNameTest()
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            string expected = "Ragnar";
            string actual = dwarf.Name;
            Assert.AreEqual(expected,actual);
        }

        // Testea si el nombre no es valido.
        [Test]
        public void noValidName1Test()
        {
            Dwarf dwarf = new Dwarf("");
            string expected = "";
            string actual = dwarf.Name;
            Assert.AreEqual(expected, actual);
        }

        // Testea si el nombre no es valido.
        [Test]
        public void noValidName2Test()
        {
            Dwarf dwarf = new Dwarf(null);
            string expected = null;
            string actual = dwarf.Name;
            Assert.AreEqual(expected, actual);
        }


        // Health tests.


        //Test que demuestra que no es posible asignar una vida válida.
        [Test]
        public void InvalidHealthTest()
        {
            Dwarf dwarf = new Dwarf("Joseph");
            dwarf.Health = -30;
            Assert.AreEqual(dwarf.Health, 0);
        }

        //Test que demuestra que es posible asignar una vida válida.
        [Test]
        public void ValidHealthTest()
        {
            Dwarf dwarf = new Dwarf("Joseph");
            Assert.AreEqual(dwarf.Health, 110);
        }

        // Testea el metodo Heal.
        [Test]
        public void HealTest()
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            dwarf.Health = 20;
            dwarf.Heal();
            int expected = 110;
            int actual = dwarf.Health;
            Assert.AreEqual(expected, actual);
        }


        // Item tests.


        // Testea si el item "Sword" es null cuando se crea el personaje.
        [Test]
        public void isNullHammerTest()
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            Assert.IsNull(dwarf.Hammer);
        }

        // Testea el metodo ChangeSword.
        [Test]
        public void changeHammerTest()
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            Hammer hammer = new Hammer(20,0);
            dwarf.ChangeHammer(hammer);
            Assert.IsNotNull(dwarf.Hammer);
        }

        // Testea el metodo RemoveSword.
        [Test]
        public void removeHammerTest()
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            Hammer hammer = new Hammer(20,0);
            dwarf.ChangeHammer(hammer);
            dwarf.RemoveHammer();
            Assert.IsNull(dwarf.Hammer);
        }

        // Testea si el item "Breastplate" es null cuando se crea el personaje.
        [Test]
        public void isNullShieldTest()
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            Assert.IsNull(dwarf.Shield);
        }

        // Testea el metodo ChangeBreastplate.
        [Test]
        public void changeShieldTest()
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            Shield shield = new Shield(0,20);
            dwarf.ChangeShield(shield);
            Assert.IsNotNull(dwarf.Shield);
        }

        // Testea el metodo RemoveBreastplate.
        [Test]
        public void removeShieldTest()
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            Shield shield = new Shield(0,20);
            dwarf.ChangeShield(shield);
            dwarf.RemoveShield();
            Assert.IsNull(dwarf.Hammer);
        }


        // GetAttack() method tests.


        // Testea el valor de ataque default cuando el personaje no tiene items.
        [Test]
        public void attackValueWithoutItemsTest()
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            int expected = 15;
            int actual = dwarf.GetAttack();
            Assert.AreEqual(expected, actual);
        }

        // Testea el valor de ataque de un personaje con items.
        [Test]
        public void attackValueWithItemsTest()
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            Hammer hammer = new Hammer(20,0);
            Shield shield = new Shield(0,20);
            dwarf.ChangeHammer(hammer);
            dwarf.ChangeShield(shield);
            int expected = 35;
            int actual = dwarf.GetAttack();
            Assert.AreEqual(expected, actual);
        }


        // attackWarrior method tests. 


        // Testea el metodo attackWrrior con ambos personajes sin items.
        [Test]
        
        public void attackDwarf1Test()    
        {
            Dwarf dwarf1 = new Dwarf("Ragnar");
            Dwarf dwarf2 = new Dwarf("Bjorn");
            dwarf1.attackDwarf(dwarf2);
            int expected = 95;
            int actual = dwarf2.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende sin item de defensa.
        [Test]

        public void attackDwarf2Test()    
        {
            Dwarf dwarf1 = new Dwarf("Ragnar");
            Dwarf dwarf2 = new Dwarf("Bjorn");
            Hammer hammer = new Hammer(20,0);
            dwarf1.ChangeHammer(hammer);
            dwarf1.attackDwarf(dwarf2);
            int expected = 75;
            int actual = dwarf2.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca sin item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackDwarf3Test()    
        {
            Dwarf dwarf1 = new Dwarf("Ragnar");
            Dwarf dwarf2 = new Dwarf("Bjorn");
            Shield shield = new Shield(0,20);
            dwarf2.ChangeShield(shield);
            dwarf1.attackDwarf(dwarf2);
            int expected = 110;
            int actual = dwarf2.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackDwarf4Test()    
        {
            Dwarf dwarf1 = new Dwarf("Ragnar");
            Dwarf dwarf2 = new Dwarf("Bjorn");
            Hammer hammer = new Hammer(25,0);
            Shield shield = new Shield(0,20);
            dwarf1.ChangeHammer(hammer);
            dwarf2.ChangeShield(shield);
            dwarf1.attackDwarf(dwarf2);
            int expected = 90;
            int actual = dwarf2.Health;
            Assert.AreEqual(expected, actual);
        }


        // attackWizard method tests 


        // Testea el metodo attackWrrior con ambos personajes sin items.
        [Test]
        
        public void attackWizard1Test()    
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Merlín", spellBook);
            dwarf.attackWizard(wizard);
            int expected = 55;
            int actual = wizard.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende sin item de defensa.
        [Test]

        public void attackWizard2Test()    
        {
            Dwarf dwarf = new Dwarf("Ragnar");           
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Merlín", spellBook);
            Hammer hammer = new Hammer(20,0);
            dwarf.ChangeHammer(hammer);
            dwarf.attackWizard(wizard);
            int expected = 35;
            int actual = wizard.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca sin item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackWizard3Test()    
        {
            Dwarf dwarf = new Dwarf("Ragnar"); 
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Merlín", spellBook);
            Cape cape = new Cape(0,15);
            wizard.ChangeCape(cape);
            dwarf.attackWizard(wizard);
            int expected = 55;
            int actual = wizard.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackWizard4Test()    
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Merlín", spellBook);
            Hammer hammer = new Hammer(25,0);
            Cape cape = new Cape(0,15);
            dwarf.ChangeHammer(hammer);
            wizard.ChangeCape(cape);
            dwarf.attackWizard(wizard);
            int expected = 30;
            int actual = wizard.Health;
            Assert.AreEqual(expected, actual);
        }


        // attackElf method tests 


        // Testea el metodo attackWrrior con ambos personajes sin items.
        [Test]
        
        public void attackElf1Test()    
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            Elf elf = new Elf("Dobby");
            dwarf.attackElf(elf);
            int expected = 60;
            int actual = elf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende sin item de defensa.
        [Test]

        public void attackElf2Test()    
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            Elf elf = new Elf("Dobby");
            Hammer hammer = new Hammer(20,0);
            dwarf.ChangeHammer(hammer);
            dwarf.attackElf(elf);
            int expected = 40;
            int actual = elf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca sin item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackElf3Test()    
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            Elf elf = new Elf("Dobby");
            Boots boots = new Boots(0,15);
            elf.ChangeBoots(boots);
            dwarf.attackElf(elf);
            int expected = 75;
            int actual = elf.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackElf4Test()    
        {
            Dwarf dwarf = new Dwarf("Ragnar");
            Elf elf = new Elf("Dobby");
            Hammer hammer = new Hammer(25,0);
            Boots boots = new Boots(0,15);
            dwarf.ChangeHammer(hammer);
            elf.ChangeBoots(boots);
            dwarf.attackElf(elf);
            int expected = 50;
            int actual = elf.Health;
            Assert.AreEqual(expected, actual);
        }


        // attackDwarf


        // Testea el metodo attackWrrior con ambos personajes sin items.
        [Test]
        
        public void attackWarrior1Test()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Dwarf dwarf = new Dwarf("Grumpy");
            dwarf.attackWarrior(warrior);
            int expected = 85;
            int actual = warrior.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende sin item de defensa.
        [Test]

        public void attackWarrior2Test()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Dwarf dwarf = new Dwarf("Grumpy");
            Hammer hammer = new Hammer(20,0);
            dwarf.ChangeHammer(hammer);
            dwarf.attackWarrior(warrior);
            int expected = 65;
            int actual = warrior.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca sin item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackWarrior3Test()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Dwarf dwarf = new Dwarf("Grumpy");
            Shield shield = new Shield(0,15);
            dwarf.ChangeShield(shield);
            dwarf.attackWarrior(warrior);
            int expected = 85;
            int actual = warrior.Health;
            Assert.AreEqual(expected, actual);
        }

        // Testea el metodo attackWrrior con el personaje que ataca con item de ataque y el que se defiende con item de defensa.
        [Test]

        public void attackWarrior4Test()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Dwarf dwarf = new Dwarf("Grumpy");
            Hammer hammer = new Hammer(25,0);
            Shield shield = new Shield(0,15);
            dwarf.ChangeHammer(hammer);
            dwarf.ChangeShield(shield);
            dwarf.attackWarrior(warrior);
            int expected = 60;
            int actual = warrior.Health;
            Assert.AreEqual(expected, actual);
        }

    }   
} 