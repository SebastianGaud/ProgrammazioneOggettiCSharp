using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPVeicoli
{
    public class Moto : Veicolo
    {
        public Moto ( string modello , int anno , int colore, string categoria ) : base( modello , anno , colore )
        {
            Categoria = categoria;
        }

        public String Categoria { get; set; }
    }
}