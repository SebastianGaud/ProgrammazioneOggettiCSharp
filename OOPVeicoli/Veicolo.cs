using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPVeicoli
{
    public class Veicolo
    {
        protected int anno;
        protected int colore;
        protected string modello;

        public String Modello { get; set; }
        public int Anno { get; set; }
        public int Colore { get; set; }

        public Veicolo (String modello, int anno, int colore)
        {
            this.modello = modello;
            this.anno = anno;
            this.colore = colore;
        }

        public override string ToString ()
        {
            return $"Il modello : {modello} \n" + 
                   $"Anno di immatricolazione: {anno}\n" +
                   $"Colore: #{colore}";
        }
    }
}