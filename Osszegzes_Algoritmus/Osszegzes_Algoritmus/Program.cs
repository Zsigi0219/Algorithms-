using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osszegzes_Algoritmus
{
    class Program
    {
        //Az algoritmus a tömbben található számok összegét fogja kiírni
        static void Main(string[] args)
        {

            int[] t = { 9, 7, 3, 5, 4, 2, 6 };
            int n = t.Length;
            int c = 0;

            for (int i = 0; i < n; i++)
                if (t[i] < 5)
                    c++;
            Console.WriteLine("5 nél kisebb számok száma {0}",c);
            
            
            
            //int[] tomb = { 8, 9, 5, 4, 1, 6};
            //int n = 6;
            //Console.WriteLine("Összegzés tétel");
            //
            //int osszeg = 0;
            //for (int i = 0; i < n; i++)
            //    osszeg = osszeg + tomb[i];
            //Console.WriteLine("Összeg: "+ osszeg);
            

            //int[] tomb = { 8, 9, 5, 4, 1 };
            //int n = 5;
            //Console.WriteLine("Összegzés tétel");
            //int osszeg = 0;
            //for (int i = 0; i < n; i++)
            //    osszeg = osszeg + tomb[i];
            //Console.WriteLine("Összeg: " + osszeg);
            _ = Console.ReadKey();
        }
    }
}
