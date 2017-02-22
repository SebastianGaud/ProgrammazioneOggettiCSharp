using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPersona
{
    class Persona
    {
        public String Nome { get; private set; }
        public int Eta { get; private set; }

        public static Persona CreaDaTastiera ()
        {
            Persona nuovaPersona = new Persona();
            Console.WriteLine("Inserisci il nome della persona:");
            nuovaPersona.Nome = Console.ReadLine();
            Console.WriteLine("Inserisci l'età della persona");
            nuovaPersona.Eta = Convert.ToInt32(Console.ReadLine());
            return nuovaPersona;
        }

        public static bool Equals ( Persona p1, Persona p2 )
        {
            if ( p1 == p2 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
