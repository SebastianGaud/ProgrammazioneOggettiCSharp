using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPVeicoli
{
    public class Auto : Veicolo
    {
        protected int numeroPorte;

        public Auto ( string modello , int anno , int colore, int numeroPorte ) 
            : base( modello , anno , colore )
        {
            this.numeroPorte = numeroPorte;
        }

        public int NumeroPorte { get; set; }


    }
}