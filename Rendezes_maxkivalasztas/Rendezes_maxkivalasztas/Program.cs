using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendezes_maxkivalasztas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 8, 3, 9, 1, 5, 2, 7 };
            int n = t.Length;

            for (int i=0; i<n; i++)
                Console.Write(t[i] + " ");
            Console.WriteLine();

            for (int i = n-1; i > 0; i--)
            {
                int max = i;
                for (int j = 0; j <= i; j++)
                    if (t[j] > t[max])
                        max = j;
                int swap = t[i];
                t[i] = t[max];
                t[max] = swap;
                
            }
            for (int i = 0; i < n; i++)
                Console.Write(t[i] + " ");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
