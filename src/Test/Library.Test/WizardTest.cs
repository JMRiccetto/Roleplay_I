using NUnit.Framework;
using Roleplay;
using System.Collections.Generic;

namespace Test.Library
{
    public class WizardTest
    {
        private Wizard wizard;

        private Wizard wizard2;

        private Spell spell;

        private SpellBook spellBook;

        private Cape cape;

        private Warrior warrior;

        private Breastplate breastplate;

        private Dwarf dwarf;

        private Shield shield;

        private Elf elf;

        private Boots boots;

        [SetUp]
        public void SetUp()
        {
            this.spell = new Spell("Fireball", 30);
            this.spellBook = new SpellBook();
            this.cape = new Cape(0, 10);
            this.wizard = new Wizard("Merlín", this.spellBook);
            this.spellBook.AddSpell(this.spell);
            this.spellBook.CastSpell(this.spell);
            this.wizard2 = new Wizard("Gandalf", this.spellBook);
            this.wizard2.ChangeCape(this.cape);
            this.warrior = new Warrior("Cloud");
            this.breastplate = new Breastplate(0, 20);
            this.warrior.ChangeBreastplate(breastplate);
            this.dwarf = new Dwarf("Gimli");
            this.shield = new Shield(0, 30);
            this.dwarf.ChangeShield(this.shield);
            this.elf = new Elf("Legolas");
            this.boots = new Boots(0, 15);
            this.elf.ChangeBoots(this.boots);
        }

        //Test que demuestra que no es posible asignar un nombre inválido.
        [Test]
        public void InvalidNameTest()
        {
            this.wizard.Name = "";
            Assert.AreEqual(this.wizard.Name, "Merlín");
        }

        //Test que demuestra que es posible asignar un nombre válido.
        [Test]
        public void ValidNameTest()
        {
            this.wizard.Name = "Rudeus";
            Assert.AreEqual(this.wizard.Name, "Rudeus");
        }

        //Test para verificar que un wizard pueda cambiar su capa.
        [Test]
        public void ChangeCapeTest()
        {
            Cape cape2 = new Cape(0,20);
            this.wizard.ChangeCape(cape2);
            Assert.AreEqual(this.wizard.Cape.DefenseValue, cape2.DefenseValue);
        }

        //Test para verificar que un wizard pueda sacarse su capa.
        [Test]
        public void RemoveCapeTest()
        {
            this.wizard.RemoveCape();
            Assert.IsNull(wizard.Cape);
        }

        //Test para saber el ataque de un mago.
        [Test]
        public void GetAttackTest()
        {
            int expectedAttack = 45;
            Assert.AreEqual(expectedAttack,this.wizard.GetAttack());
        }

        //Test para verificar que un wizard puede atacar a otro wizard con una armadura válida.
        [Test]
        public void AttackWizardWithValidArmor()
        {
            this.wizard.attackWizard(this.wizard2);
            int expectedHealth = 35;
            Assert.AreEqual(expectedHealth, wizard2.Health);
        }

        //Test para verificar que un wizard puede atacar a otro wizard con una armadura inválida.
        [Test]
        public void AttackWizardWithInvalidArmor()
        {
            this.wizard2.RemoveCape();
            this.wizard.attackWizard(this.wizard2);
            int expectedHealth = 25;
            Assert.AreEqual(expectedHealth, wizard2.Health);
        }

        //Test para verificar que un wizard puede atacar a un warrior con una armadura válida.
        [Test]
        public void AttackWarriorWithValidArmor()
        {
            this.wizard.attackWarrior(this.warrior);
            int expectedHealth = 75;
            Assert.AreEqual(expectedHealth, warrior.Health);
        }

        //Test para verificar que un wizard puede atacar a un warrior con una armadura inválida.
        [Test]
        public void AttackWarriorWithInvalidArmor()
        {
            this.warrior.RemoveBreastplate();
            this.wizard.attackWarrior(this.warrior);
            int expectedHealth = 55;
            Assert.AreEqual(expectedHealth, warrior.Health);
        }

        //Test para verificar que un wizard puede atacar a un dwarf con una armadura válida.
        [Test]
        public void AttackDwarfWithValidArmor()
        {
            this.wizard.attackDwarf(this.dwarf);
            int expectedHealth = 95;
            Assert.AreEqual(expectedHealth, dwarf.Health);
        }

        //Test para verificar que un wizard puede atacar a un dwarf con una armadura inválida.
        [Test]
        public void AttackDwarfWithInvalidArmor()
        {
            this.dwarf.RemoveShield();
            this.wizard.attackDwarf(this.dwarf);
            int expectedHealth = 65;
            Assert.AreEqual(expectedHealth, dwarf.Health);
        }

        //Test para verificar que un wizard puede atacar a un elf con una armadura válida.
        [Test]
        public void AttackElfWithValidArmor()
        {
            this.wizard.attackElf(this.elf);
            int expectedHealth = 50;
            Assert.AreEqual(expectedHealth, elf.Health);
        }

        //Test para verificar que un wizard puede atacar a un elf con una armadura inválida.
        [Test]
        public void AttackElfWithInvalidArmor()
        {
            this.elf.RemoveBoots();
            this.wizard.attackElf(this.elf);
            int expectedHealth = 35;
            Assert.AreEqual(expectedHealth, elf.Health);
        }
    }
}