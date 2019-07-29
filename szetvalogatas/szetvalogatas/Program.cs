using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szetvalogatas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 9, 7, 3, 5, 4, 2, 6};
            int n = a.Length;
            int[] b = new int[n];
            int[] c = new int[n];

            int j = 0;
            int k = 0;
            for (int i = 0; i < n; i++)
                if (a[i] < 5)
                {
                    b[j] = a[i];
                    j++;
                }
                else
                {
                    c[k] = a[i];
                    k++;

                }
            Console.WriteLine("Eredeti számsor: ");
            for (int i = 0; i<n; i++)
                Console.WriteLine("{0}", a[i]);
            Console.WriteLine();

            Console.WriteLine("Kiválogatott számok B: ");
            for (int i = 0; i < j; i++)
                Console.WriteLine("{0}", b[i]);
            Console.WriteLine();

            Console.WriteLine("Kiválogatott számok C: ");
            for (int i = 0; i < k; i++)
                Console.WriteLine("{0}", c[i]);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
