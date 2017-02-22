using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPersona
{
    class OOPPersona
    {
        static void Main ( string[] args )
        {
            Persona p1 = Persona.CreaDaTastiera();
            Persona p2 = Persona.CreaDaTastiera();

            if ( Persona.Equals(p1, p2) )
            {
                Console.WriteLine("Le persone sono uguali");
            }
            else
            {
                Console.WriteLine("Le persone non sono uguali");
            }
            Console.Read();
        }
    }
}
