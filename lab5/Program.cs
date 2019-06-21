using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<int> tab = new List<int>();
            Rownanie r = null;
            Console.Write("a: ");
            tab.Add(Convert.ToInt32(Console.ReadLine()));
            Console.Write("b: ");
            tab.Add(Convert.ToInt32(Console.ReadLine()));
            Console.Write("c: ");
            tab.Add(Convert.ToInt32(Console.ReadLine()));

            Obliczenia obliczenie = new Obliczenia();
            if (tab[0] == 0)
            {
                r = new Quadratic();
            }
            else
            {
                r = new DoubleQuadratic();
            }
            r.formatuj_rnie(tab);
            Console.WriteLine();
            obliczenie.oblicz_pierwiastki(tab);
            obliczenie.wyswietl_wyniki(tab);

            Console.ReadLine();
        }
    }
}
