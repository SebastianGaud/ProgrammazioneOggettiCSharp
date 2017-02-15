using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPVeicoli
{
    public class Moto : Veicolo
    {
        protected string categoria;

        public Moto ( string modello , int anno , int colore, string categoria ) : base( modello , anno , colore )
        {
            this.categoria = categoria;
        }

        public String Categoria { get; set; }
    }
}