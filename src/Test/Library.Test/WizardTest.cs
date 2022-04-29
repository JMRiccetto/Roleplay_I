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

        [SetUp]
        public void SetUp()
        {
            this.spell = new Spell("Fireball", 30);
            this.spellBook = new SpellBook();
            this.cape = new Cape(0,10);
            this.wizard = new Wizard("Merlín", this.spellBook);
            this.spellBook.AddSpell(this.spell);
            this.spellBook.CastSpell(this.spell);
            this.wizard2 = new Wizard("Gandalf", this.spellBook);
            this.wizard2.ChangeCape(this.cape);
            this.warrior = new Warrior("Cloud");
            this.breastplate = new Breastplate(0,20);
            this.warrior.ChangeBreastplate(breastplate);
        }

        //Test para verificar que un wizard puede cambiar su capa.
        [Test]
        public void ChangeCapeTest()
        {
            Cape cape2 = new Cape(0,20);
            this.wizard.ChangeCape(cape2);
            Assert.AreEqual(this.wizard.Cape.DefenseValue, cape2.DefenseValue);
        }

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
    }
}