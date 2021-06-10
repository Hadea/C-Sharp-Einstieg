using System;
using System.Collections.Generic;

namespace C_Sharp_Einstieg
{
    class Program
    {
        int classField = 4;

        static void Main()
        {


            // objekte von Klassen erstellen
            Player playerOne = new Player(2);
            playerOne.Hitpoints = 5;
            playerOne.Name = "Hans";
            
            if (playerOne.GetDamage(2))
            {
                Console.WriteLine("Spieler lebt");
            }
            else
            {
                Console.WriteLine("Spieler ist gestorben");
            }

            DoSomthingWithPlayer(playerOne);

           
        }

        public static void DoSomthingWithPlayer(Player PlayerToWorkWith)
        {
            Console.WriteLine(PlayerToWorkWith.Hitpoints);
            PlayerToWorkWith.Hitpoints = 2;
        }
    }
}
