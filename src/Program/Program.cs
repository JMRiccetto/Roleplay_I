using System;

namespace Roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior1 = new Warrior("Ragnar");

            Warrior warrior2 = new Warrior("Bjorn");

            Console.WriteLine("stats iniciales");
            Console.WriteLine(warrior1.Name);
            Console.WriteLine(warrior1.Health);
            Console.WriteLine(warrior1.GetAttack());
            
            Sword sword1 = new Sword(30, 0);
            Breastplate breastplate1 = new Breastplate(0,5);
            
            Console.WriteLine("stats con item");
            warrior1.ChangeSword(sword1);
            warrior1.ChangeBreastplate(breastplate1);

            Console.WriteLine(warrior1.Health);
            Console.WriteLine(warrior1.GetAttack());
            
            Console.WriteLine("stats pj 2");
            Console.WriteLine(warrior2.Health);
            Console.WriteLine(warrior2.GetAttack());

            warrior2.attackWarrior(warrior1);

            Console.WriteLine("stats despues de ser atacado");
            Console.WriteLine(warrior1.Health);

            warrior2.attackWarrior(warrior1);

            Console.WriteLine("stats despues de ser atacado");
            Console.WriteLine(warrior1.Health);
            
            
        }
    }
}
