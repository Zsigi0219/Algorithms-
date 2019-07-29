using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereses_alg
{
    /* Benne van-e a keresett szám, és hányadik helyen van  */
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = {9, 7, 3, 5, 4, 2, 6};
            int n = t.Length;
            int ker = 5;
            //int ker = 0;
            //Console.WriteLine("Adja meg a keresett értéket: ");
            //ker = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < n && t[i] != ker)
                i++;
            if(i<n)
                Console.WriteLine("Indexe: {0}", i);
            else
                Console.WriteLine("Nincs benne");
            Console.ReadLine();
        }
    }
}
