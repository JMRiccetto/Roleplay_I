/*using NUnit.Framework;
using Roleplay;

namespace Test.Library
{


    public class ExampleTest
    {


        //Tests Warrior 


        // Name tests

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

        // Health tests

        [Test]
        public void healthTestWithoutItems()
        {
            Warrior warrior = new Warrior("Ragnar");
            int expected = 100;
            int actual = warrior.Health;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void healthTestWithItems()
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

        // Item tests

        [Test]
        public void isNullSword()
        {
            Warrior warrior = new Warrior("Ragnar");
            Assert.IsNull(warrior.Sword);
        }

        [Test]
        public void changeSwordTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            Sword sword = new Sword(20,0);
            warrior.ChangeSword(sword);
            Assert.IsNotNull(warrior.Sword);
        }

        [Test]
        public void removeSwordTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            Sword sword = new Sword(20,0);
            warrior.ChangeSword(sword);
            warrior.RemoveSword();
            Assert.IsNull(warrior.Sword);
        }

        [Test]
        public void isNullBreastplate()
        {
            Warrior warrior = new Warrior("Ragnar");
            Assert.IsNull(warrior.Breastplate);
        }

        [Test]
        public void changeBreastplateTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            Breastplate breastplate = new Breastplate(0,20);
            warrior.ChangeBreastplate(breastplate);
            Assert.IsNotNull(warrior.Sword);
        }

        [Test]
        public void removeBreastplateTest()
        {
            Warrior warrior = new Warrior("Ragnar");
            Breastplate breastplate = new Breastplate(0,20);
            warrior.ChangeBreastplate(breastplate);
            warrior.RemoveBreastplate();
            Assert.IsNull(warrior.Sword);
        }

        // GetAttack() method tests

        [Test]
        public void attackValueWithoutItems()
        {
            Warrior warrior = new Warrior("Ragnar");
            int expected = 15;
            int actual = warrior.GetAttack();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void attackValueWithItems()
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

        // attackWarrior method tests 

        [Test]
        
        // Without items
        public void attackWarrior1()    
        {
            Warrior warrior1 = new Warrior("Ragnar");
            Warrior warrior2 = new Warrior("Bjorn");
            warrior1.attackWarrior(warrior2);
            int expected = 85;
            int actual = warrior2.Health;
            Assert.AreEqual(expected, actual);
        }

        [Test]

        // Attacker with sword  , Attacked without breastplate
        public void attackWarrior2()    
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

        [Test]

        // Attacker without sword  , Attacked with breastplate
        public void attackWarrior3()    
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

        [Test]

        // Attacker with sword  , Attacked with breastplate
        public void attackWarrior4()    
        {
            Warrior warrior1 = new Warrior("Ragnar");
            Warrior warrior2 = new Warrior("Bjorn");
            Sword sword = new Sword(25,0);
            Breastplate breastplate = new Breastplate(0,20);
            warrior1.ChangeSword(sword);
            warrior2.ChangeBreastplate(breastplate);
            warrior1.attackWarrior(warrior2);
            int expected = 95;
            int actual = warrior2.Health;
            Assert.AreEqual(expected, actual);
        }


        // attackWizard method tests 


        [Test]
        
        public void attackWizard1()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Wizard wizard = new Wizard("Merlín");
            warrior.attackWizard(wizard);
            int expected = 55;
            int actual = wizard.Health;
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void attackWizard2()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Wizard wizard = new Wizard("Merlín");
            Sword sword = new Sword(20,0);
            warrior.ChangeSword(sword);
            warrior.attackWizard(wizard);
            int expected = 35;
            int actual = wizard.Health;
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void attackWizard3()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Wizard wizard = new Wizard("Merlín");
            Cape cape = new Cape(0,15);
            wizard.ChangeCape(cape);
            warrior.attackWizard(wizard);
            int expected = 70;
            int actual = wizard.Health;
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void attackWizard4()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Wizard wizard = new Wizard("Merlín");
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


        [Test]
        
        public void attackElf1()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Elf elf = new Elf("Dobby");
            warrior.attackWizard(elf);
            int expected = 75;
            int actual = elf.Health;
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void attackElf2()    
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

        [Test]

        public void attackElf3()    
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

        [Test]

        public void attackElf4()    
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


        [Test]
        
        public void attackDwarf1()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Dwarf dwarf = new Dwarf("Grumpy");
            warrior.attackDwarf(dwarf);
            int expected = 95;
            int actual = dwarf.Health;
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void attackDwarf2()    
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

        [Test]

        public void attackDwarf3()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Dwarf dwarf = new Dwarf("Grumpy");
            Shield shield = new Shield(0,15);
            elf.ChangeSield(shield);
            warrior.attackDwarf(dwarf);
            int expected = 110;
            int actual = dwarf.Health;
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void attackDwarf4()    
        {
            Warrior warrior = new Warrior("Ragnar");
            Dwarf dwarf = new Dwarf("Grumpy");
            Sword sword = new Sword(25,0);
            Boots boots = new Boots(0,15);
            warrior.ChangeSword(sword);
            elf.ChangeBoots(boots);
            warrior.attackDwarf(dwarf);
            int expected = 85;
            int actual = dwarf.Health;
            Assert.AreEqual(expected, actual);
        }

    }   
}   */