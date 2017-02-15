using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPVeicoli
{
    public class Taxi : Veicolo
    {
        public Taxi ( string modello , int anno , int colore, int codiceTaxi ) : base( modello , anno , colore )
        {
            CodTaxi = codiceTaxi;
        }

        public int CodTaxi { get; set; }
    }
}