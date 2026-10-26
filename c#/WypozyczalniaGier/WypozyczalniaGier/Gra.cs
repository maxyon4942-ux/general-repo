using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaGier
{
    internal class Gra
    {
        public string nazwaGry;
        public double cenaZaDzien;

        public Gra(string nazwaGry, double cenaZaDzien)
        {
            this.nazwaGry = nazwaGry;
            this.cenaZaDzien = cenaZaDzien;
            ListaGier.lista.Add(this);
        }
    }
}
