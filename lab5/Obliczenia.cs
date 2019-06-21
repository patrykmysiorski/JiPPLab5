using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace lab5
{
    class Obliczenia
    {
        Complex x1 = new Complex(0, 0);
        Complex x2 = new Complex(0, 0);
        Complex x3 = new Complex(0, 0);
        Complex x4 = new Complex(0, 0);
        Complex addResult = new Complex(0, 0);
        Complex subResult = new Complex(0, 0);
        Complex powResult = new Complex(0, 0);
        List<Complex> wyniki = new List<Complex>();

        double oblicz_delte(List<int> tab)
        {
            int a = tab[0];
            int b = tab[1];
            int c = tab[2];
            double delta = 0;
            if (a != 0)
            {
                delta = 1.0 * b * b - 4.0 * a * c;
            }
            else if (b != 0)
            {
                delta = -4.0 * b * c;
            }
            return delta;
        }

        public void oblicz_pierwiastki(List<int> tab)
        {
            int a = tab[0];
            int b = tab[1];
            int c = tab[2];

            wyniki.Add(x1);
            wyniki.Add(x2);
            wyniki.Add(x3);
            wyniki.Add(x4);
            wyniki.Add(addResult);
            wyniki.Add(subResult);
            wyniki.Add(powResult);
            

            if (a != 0)
            { //a nierowne 0
                double delta = oblicz_delte(tab);

                if (delta > 0)
                { //delta dodatnia
                    double pdelta = Math.Sqrt(delta);

                    double t1 = (-1.0 * b - pdelta) / (2.0 * a);
                    double t2 = (-1.0 * b + pdelta) / (2.0 * a);

                    if (t1 < 0)
                    {//t1 ujemne 
                        x1 = new Complex(0, -1.0 * t1);
                        x2 = new Complex(x1.Real, -1.0 * x1.Imaginary);
                        
                        wyniki[0] = x1;
                        wyniki[1] = x2;
                    }
                    else
                    { //t1 dodatnie lub rowne 0
                        x1 = new Complex(Math.Sqrt(t1), 0);
                        x2 = new Complex(-1.0 * Math.Sqrt(t1), 0);
                        wyniki[0] = x1;
                        wyniki[1] = x2;
                    }

                    if (t2 < 0)
                    { //t2 ujemne
                        x3 = new Complex(0, Math.Sqrt(-1.0 * t2));
                        x4 = new Complex(x3.Real, -1.0 * x3.Imaginary);
                        
                        wyniki[2] = x3;
                        wyniki[3] = x4;
                    }
                    else
                    { //t2 wieksze lub rowne 0
                        x3 = new Complex(Math.Sqrt(t2), 0);
                        x4 = new Complex(-1.0 * Math.Sqrt(t2), 0);
                        wyniki[2] = x3;
                        wyniki[3] = x4;
                    }
                }
                else if (delta == 0)
                {//delta rowna 0
                    double t = (-1.0 * b) / (2.0 * a);

                    if (t >= 0)
                    { // t wieksze lub rowne 0
                        x1 = new Complex(Math.Sqrt(t), 0);
                        x2 = new Complex(-1.0 * Math.Sqrt(t), 0);
                        
                        wyniki[0] = x1;
                        wyniki[1] = x2;
                    }
                    else
                    { // t ujemne
                        
                        x1 = new Complex(0, Math.Sqrt(-1.0 * t));
                        x2 = new Complex(x1.Real, -1.0 * x1.Imaginary);
                        
                        wyniki[0] = x1;
                        wyniki[1] = x2;
                    }
                }
                else
                { //delta ujemna
                    double pdelta = Math.Sqrt(-1.0 * delta);

                    double t1r = (-1.0 * b) / (2.0 * a);
                    double t1u = (-1.0 * pdelta) / (2.0 * a);
                    double t2r = t1r;
                    double t2u = (1.0 * pdelta) / (2.0 * a);
                    x1 = new Complex(Math.Sqrt((Math.Sqrt(t1r * t1r + t1u * t1u) + t1r) / 2.0), Math.Sqrt((Math.Sqrt(t1r * t1r + t1u * t1u) - t1r) / 2.0));
                    x2 = new Complex(x1.Real, -1.0 * x1.Imaginary);
                    x3 = new Complex(-1.0 * Math.Sqrt((Math.Sqrt(t2r * t2r + t2u * t2u) + t2r) / 2.0), -1.0 * Math.Sqrt((Math.Sqrt(t2r * t2r + t2u * t2u) - t2r) / 2.0));
                    x4 = new Complex(x3.Real, -1.0 * x3.Imaginary);
                    wyniki[0] = x1;
                    wyniki[1] = x2;
                    wyniki[2] = x3;
                    wyniki[3] = x4;
                }
            }
            else if (b != 0)
            {//a rowne 0, b rozne od 0
                double delta = oblicz_delte(tab);

                if (delta > 0)
                { //delta dodatnia
                    double pdelta = Math.Sqrt(delta);
                    x1 = new Complex((-1.0 * pdelta) / (2.0 * b), 0);
                    x2 = new Complex((1.0 * pdelta) / (2.0 * b), 0);
                    wyniki[0] = x1;
                    wyniki[1] = x2;
                }
                else if (delta == 0)
                {//delta rowna 0

                    x1 = new Complex(0, 0);
                    x2 = new Complex(x1.Real, 0);
                    wyniki[0] = x1;
                    wyniki[1] = x2;
                }
                else
                { //delta ujemna
                    double delta_2 = -1.0 * delta;
                    double pdelta = Math.Sqrt(delta_2);

                    
                    x1 = new Complex(0, (-1.0 * pdelta) / (2.0 * b));
         
                    x2 = new Complex(0, (1.0 * pdelta) / (2.0 * b));
                    wyniki[0] = x1;
                    wyniki[1] = x2;
                }
            }
        }

        void dodaj_l_zesp()
        {


          
            addResult = (x1 + x2 + x3 + x4);

            wyniki[4] = addResult;
        }

        void odejm_l_zesp()
        {
            
            subResult = (x1 - x2 - x3 - x4);
            if (subResult.Imaginary < 0)
            {
                subResult = new Complex(subResult.Real, subResult.Imaginary * -1.0);
                
            }
            wyniki[5] = subResult;
        }

        void pomnoz_l_zesp()
        {
            
            Complex tmp = new Complex(x1.Real, x1.Imaginary);
            //subResult.real(x1.real() - x2.real() - x3.real() - x4.real());
            //subResult.imag(x1.imag() - x2.imag() - x3.imag() - x4.imag());
            
            Complex zeroComplex = new Complex(0, 0);
            powResult = x1;
            for (int i = 1; i < 4; i++)
            {
                if (wyniki.ElementAt(i) != zeroComplex) ;
                powResult = powResult * wyniki[i];
            }
            wyniki[6] = powResult;
        }

        public void wyswietl_wyniki(List<int> tab)
        {
            int a = tab[0];
            int b = tab[1];
            int c = tab[2];

            if (a != 0)
            {
                double delta = oblicz_delte(tab);
                Console.WriteLine("delta: {0}", delta);
                if (delta != 0) //delta rozna od zera
                {
                    //wypisz x1
                    Console.WriteLine("x1: {0}", wyniki.ElementAt(0));

                    //cout << x1.real() << "+" << x1.getImaginaryNumber() << endl;
                    //printString(wyniki[0]);

                    //wypisz x2
                    Console.WriteLine("x2: {0}", wyniki.ElementAt(1));
                    
                    //printString(wyniki[1]);
                    
                    //wypisz x3
                    
                    Console.WriteLine("x3: {0}", wyniki.ElementAt(2));
                    //printString(wyniki[2]);

                    //wypisz x4

                    Console.WriteLine("x4: {0}", wyniki.ElementAt(3));
                    //printString(wyniki[3]);
                    
                }
                else // delta rowna 0
                {
                    //printString(wyniki[0]);
                    Console.WriteLine("x1: {0}", wyniki.ElementAt(0));

                    //printString(wyniki[1]);
                    Console.WriteLine("x2: {0}", wyniki.ElementAt(1));
                    
                }
            }
            else //a rowne zero
            {
                double delta = oblicz_delte(tab);
                Console.WriteLine("delta: {0}", delta);
                
                if (delta < 0) //delta ujemna
                {
                    //cout << x1.real() << "+" << x1.getImaginaryNumber() << endl;
                    //printString(wyniki[0]);
                    //printString(wyniki[1]);
                    Console.WriteLine("x1: {0}", wyniki.ElementAt(0));
                    Console.WriteLine("x2: {0}", wyniki.ElementAt(1));
                    
                }
                else //delta wieksza lub rowna zero
                {
                    Console.WriteLine("x1: {0}", wyniki.ElementAt(0).Real);
                    Console.WriteLine("x2: {0}", wyniki.ElementAt(1).Real);
                }
            }
            odejm_l_zesp();
            dodaj_l_zesp();
            pomnoz_l_zesp();

            /*cout << "sr: " << wyniki[4].real() << "\n";
            cout << "sr: " << wyniki[0] << endl;
            cout << "su: " << wyniki[4].imag() << "\n";
            cout << "rr: " << wyniki[5].real() << "\n";
            cout << "ru: " << wyniki[5].imag() << "\n";*/
            Console.WriteLine("suma: {0}", wyniki.ElementAt(4));
            Console.WriteLine("roznica: {0}", wyniki.ElementAt(5));
            Console.WriteLine("mnozenie: {0}", wyniki.ElementAt(6));
        }
    }
}
