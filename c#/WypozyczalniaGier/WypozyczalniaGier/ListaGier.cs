using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaGier
{
    internal static class ListaGier
    {
        public static List<Gra> lista = new List<Gra>();


        public static void ZainicjujGry()
        {
            Gra g1 = new Gra("Wiedzmin 3", 9.99);
            Gra g2 = new Gra("Cyberpunk 2077", 10);
            Gra g3 = new Gra("Detroit become human", 8.99);
            Gra g4 = new Gra("Celeste", 3.99);
            Gra g5 = new Gra("Geometry Dash", 2.99);
        }

        public static void WyswietlGry()
        {
            int i = 1;
            foreach(Gra g in lista)
            {
                Console.WriteLine(i + " - " + g.nazwaGry + ", cena za dzien: " + g.cenaZaDzien + " zł");
                i++;
            }
        }

        public static double ObliczKoszt(Gra g, int liczbaDni)
        {
            double cena = liczbaDni * g.cenaZaDzien;
            if(liczbaDni >= 7)
            {
                cena *= 0.9;
            }
            return cena;
        }
    }
}
