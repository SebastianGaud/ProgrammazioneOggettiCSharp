using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPVeicoli
{
    public class Veicolo
    {
        public String Modello { get; set; }
        public int Anno { get; set; }
        public int Colore { get; set; }

        public Veicolo (String modello, int anno, int colore)
        {
            this.Modello = modello;
            this.Anno = anno;
            this.Colore = colore;
        }
    }
}