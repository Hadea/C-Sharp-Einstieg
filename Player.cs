using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Einstieg
{
    class Player
    {
        public int Hitpoints;
        public string Name;
        private float MovementSpeed;
        
        public Player() //Standard-Konstruktor. Wird automatisch durch das new gestartet wenn ein Objekt vom Typ Player erstellt wird
        {
            Hitpoints = 5;
            MovementSpeed = 10.0f;
        }

        public Player(int Number)//Überladener-Konstruktor. Falls für die Erstellung zusätzliche informationen nötig sind
        {
            Hitpoints = Number;
            MovementSpeed = 10.0f;
        }

        public bool GetDamage(int DamagePoints)//Eine Methode (Fähigkeit) vom Player welche von aussen gestartet werden kann
        {
            Hitpoints -= DamagePoints;
            return Hitpoints > 0; //Falls eine Methode mit einem Ergebnis antworten soll wird das mit return gemacht
            // return beendet die Methode und kopiert den angegebenen wert zu dem Aufrufer.
        }
    }
}
