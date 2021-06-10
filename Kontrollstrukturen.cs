namespace C_Sharp_Einstieg
{
    class Kontrollstrukturen
    {
        public static void DoSomething()
        {
            //verzweigungen

            if (3 < 2) // testet
            {// wenn true

            }
            else // wenn false (optional)
            {

            }

            //            test ? true : false
            int Number = (3 < 2 ? 5 : 7);

            int Value = 4;
            switch (Value)
            {
                case 1:
                    System.Console.WriteLine("Hab eine Eins gefunden");
                    break;
                case 2:
                    System.Console.WriteLine("Hab eine Zwei gefunden");
                    break;

                case 4:
                case 7:
                case 3:
                    System.Console.WriteLine("Hab eine Irgendwas gefunden");
                    break;
                default:
                    System.Console.WriteLine("bin im default");
                    break;

            }

            Number = (Value) switch
            {
                1 => 5, // entspricht case 1: Number = 5; break;
                2 => 7,
                _ => 0 // entspricht default: Number = 0; break;
            };

            // schleifen

            int[] integerArray = new int[5];

            // (optional) erster teil erstellt hilfsvariable einmal am anfang, sie ist nach dem ablauf der for auch zerstört
            // (optional) zweiter teil ist die überprüfung welche vor jedem durchlauf passiert
            // (optional) dritter teil ist das modifizieren des zählers nach jedem durchlauf
            for (int counter = 0; counter < integerArray.Length; counter++)
            {
                integerArray[counter] = 5;
            }

            /*
            for(;;) // zoidberg for
            {
            }
            */

            foreach (int item in integerArray)
            {
                System.Console.WriteLine(item);
            }


            // while läuft solange die bedinung true ergibt
            Number = 10;
            while (Number > 2)
            {
                Number /= 2;
                System.Console.WriteLine(Number);
            }

            // do/while läuft mindestens einmal
            Number = 10;
            do
            {
                Number /= 2;
                System.Console.WriteLine(Number);
            } while (Number > 2); // wanna see me do it again

        }
    }
}
