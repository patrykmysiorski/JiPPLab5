using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Quadratic : Rownanie
    {
        override public void formatuj_rnie(List<int> tab)
        {
            int a = tab[0];
            int b = tab[1];
            int c = tab[2];

            //wszystkie mozliwosci a
            if (a != 0)
            {
                if (a == -1)
                {
                    Console.Write("-xxxx");
                    
                }
                else if (a == 1)
                {
                    Console.Write("xxxx");
                    
                }
                else
                {
                    Console.Write("{0} xxxx", a);
                    
                }

                //wszystkie mozliwosci b
                if (b != 0)
                {
                    if (b < 0) //b ujemne
                    {
                        Console.Write("{0} xx", b);
                    }
                    else if (b == 1)
                    {
                        Console.Write("+xx");
                        
                    }
                    else
                    {
                        Console.Write("+ {0} xxxx", b);
                        
                    }
                }

                //c
                if (c != 0)
                {
                    if (c < 0)
                    {
                        Console.Write("{0}", c);
                        
                    }
                    else
                    {
                        Console.Write("+{0}", c);
                        
                    }
                }
                Console.Write("=0\n");
                
            }
            else
            { //a rowne zero
                if (b != 0)
                {
                    if (b != 1)
                    {
                        Console.Write("{0} xx", b);
                        
                    }
                    else
                    {
                        Console.Write("xx");
                        
                    }
                    if (c != 0)
                    {
                        if (c < 0)
                        {
                            Console.Write("{0}", c);
                            
                        }
                        else
                        {
                            Console.Write("+{0}", c);
                            
                        }
                    }

                    Console.Write("=0\n");
                }
                else
                { //b rowne zero
                    if (c != 0)
                    {
                        Console.Write("Rownanie sprzeczne.\n");
                        
                    }
                    else
                    {
                        Console.Write("Rownanie tozsamosciowe. 0=0\n");
                        
                    }
                }
            }
            //koniec wypisywania
        }
    }
}
