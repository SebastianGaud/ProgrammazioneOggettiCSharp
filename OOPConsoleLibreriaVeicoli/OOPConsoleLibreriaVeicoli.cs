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
            Veicolo Trattore = new Veicolo( "Landini" , 0125458 , 1998 );
            Auto GolfAuto = new Auto( "Golf" , 123458 , 2016, 5 );
            Taxi Taxi45 = new Taxi( "Prius" , 454654 , 2012 , 789 );
        }
    }
}
