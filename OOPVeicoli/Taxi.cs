using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPVeicoli
{
    public class Taxi : Veicolo
    {
        protected int codTaxi;

        public Taxi ( string modello , int anno , int colore, int codiceTaxi ) : base( modello , anno , colore )
        {
            this.codTaxi = codiceTaxi;
        }

        public int CodTaxi { get; set; }

        public override string ToString ()
        {
            return base.ToString() + $"Codice Taxi: {codTaxi}";
        }
    }
}