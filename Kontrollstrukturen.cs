namespace C_Sharp_Einstieg
{
    class Kontrollstrukturen
    {
        public static void DoSomething()
        {
            if (3 < 2) // testet
            {// wenn true

            }
            else // wenn false (optional)
            {

            }

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

        }
    }
}
