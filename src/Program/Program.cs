using System;
using Roleplay;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Elve Fernando = new Elve("Fernando");
            
            Boots BotasMagicas = new Boots(0,15);
            Bow ArcoMagico = new Bow(30,0);

            Fernando.ChangeBoots(BotasMagicas);
            Fernando.ChangeBow(ArcoMagico);

            Console.WriteLine(Fernando.GetString());

        }
    }
}
