using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaGier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaGier.ZainicjujGry();
            bool wypozyczanie = true;
            while (wypozyczanie)
            {
                wypozyczanie = WypozyczGre();
            }
        }

        static bool WypozyczGre()
        {
            if(ListaGier.lista.Count == 0)
            {
                Console.WriteLine("Wszystkie gry zostały wypożyczone");
                return false;
            }
            Console.WriteLine("Wybierz gre do wypożyczenia: 1-" + ListaGier.lista.Count + "\nq aby wyjść z programu");
            ListaGier.WyswietlGry();

            try
            {
                string wyborTekst = Console.ReadLine();
                if (wyborTekst == "q") return false;
                int wybor = int.Parse(wyborTekst);
                if (wybor < 1 || wybor > ListaGier.lista.Count)
                {
                    Console.WriteLine("Liczba musi miescic sie miedzy 1 a " + ListaGier.lista.Count);
                    return true;
                }
                Console.WriteLine("Wybierz na ile dni chcesz wypożyczyć gre: ");
                int liczbaDni = int.Parse(Console.ReadLine());
                if(liczbaDni < 1 || liczbaDni > 31)
                {
                    Console.WriteLine("Gra musi być wypożyczona na przynajmiej 1 dzien i może być wypożyczona maksymalna na 31 dni\n");
                    return true;
                }
                Gra wybrana = ListaGier.lista[wybor - 1];
                double cena = ListaGier.ObliczKoszt(wybrana, liczbaDni);
                Console.WriteLine("Gra została wypożyczona na: " + liczbaDni + " za: " + cena + " zł\n");
                ListaGier.lista.Remove(wybrana);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Podana liczba jest nieprawidłowa");
                Console.WriteLine(ex.Message + "\n");
            }
            return true;
        }
    }
}
