using System.Collections.Generic;

namespace C_Sharp_Einstieg
{
    class Datentypen
    {
        // Ganzzahlen
        byte singleByte = 5; //0 bis 255
        sbyte signedSingleByte = -5; // -128 bis +127

        short twoBytes = 10000; // -32768 bis +32767
        ushort twoBytesWithout = 10000; // 0 bis 65535

        int fourBytesSigned = 2000000000; // -2,14 Milliarden bis +2,14 milliarden
        uint fourBytesUnsigned = 4000000000; // 0 bis 4,29 Milliarden

        long eightBytesSigned = 8; // -9 Trillionen bis +9 Trillionen
        ulong eightBytesUnsigned = 1; // 0 bis 18 Trillionen

        bool singleBit = false; // true (1) oder false (0) verbraucht 1 Byte RAM, da nichts kleineres reserviert werden kann

        // Gebrochene Zahlen
        float fourBytesFloatingPoint = 1.0f; // 6 stellen genau
        double eightBytesFloatingPoint = 1.0d; // 15 stellen genau
        decimal sixteenBytesFloatingPoint; // 25 stellen genau

        // Text
        char singleLetter = 'B'; // 16Bit Buchstabe
        string severalLetters = "Hallo"; //Array aus char

        public void DoSomething()
        {

            //Container

            // Array
            // reservier Speicher für 10 variablen des typ byte die durchnummeriert im RAM landen.
            // die Position im RAM merken wir uns in der Variable integerArray
            byte[] integerArray = new byte[10];

            //setzt den wert an stelle 5 auf den wert 12 (gezählt wird ab stelle 0)
            integerArray[5] = 12;

            // List
            // Komfortablere Version des Array wenn die finale anzahl der elemente nicht fest ist
            // Reserviert mehr speicher als eigendlich nötig und kann dadurch erweitert werden.
            // sollte die Kapazität nicht ausreichen verdoppelt sich die kapazität, was etwas zeit
            // in anspruch nimmt
            // Die mindestkapazität ist 8, kann aber über den Konstruktor anders angegeben werden
            List<short> shortList = new List<short>();
            shortList.Add(5); // fügt ein element hinzu, IDs werden wie beim Array ab 0 begonnen
            shortList.Add(3);
            shortList.Add(12);
            shortList.Add(100);
            shortList[2] = 5; // überschreibt das element an ID 2 mit dem wert 5
        }
    }
}
