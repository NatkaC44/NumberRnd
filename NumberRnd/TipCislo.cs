using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberRnd
{
    public class TipCislo
    {
        public void Run()
        {
            var nk = true;

            while (nk)
             {
                var x = new Random();
                var rndcislo = x.Next(1, 101);
                Console.WriteLine("chces hrat? -> y/n");
                var yn = Console.ReadLine();

                if (yn=="y")
                {
                    int pokusy = 1;
                    for (int i = 0; i < 102; pokusy++)
                    {
                        Console.WriteLine("Tipuj cislo: ");
                        var vyhra = Console.ReadLine();
                        Int32.TryParse(vyhra, out int Intvyhra);
                        if (Intvyhra < rndcislo)
                        {
                            Console.WriteLine("Je vetsi.");
                        }
                        else if(Intvyhra > rndcislo)
                        {
                            Console.WriteLine("Je mensi.");
                        }
                        else if (Intvyhra == rndcislo)
                        {
                            Console.WriteLine("win!");
                            Console.WriteLine(pokusy + " pokusu.");
                            break; 
                        }
                    }
                }
               if (yn=="n")
                {
                    break;
                }


             }
        }

    }
}
