using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPVeicoli;

namespace OOPConsoleLibreriaVeicoli
{
    class OOPConsoleLibreriaVeicoli
    {
        static void Main ( string[] args )
        {
            Veicolo Trattore = new Veicolo( "Landini" , 1998 , 123456789 );
            Auto GolfAuto = new Auto( "Golf" , 2016 , 0123456, 5 );
            Taxi Taxi45 = new Taxi( "Prius" , 2012 , 0123456789 , 789 );

            Console.WriteLine(Trattore.ToString());
            
        }
    }
}
