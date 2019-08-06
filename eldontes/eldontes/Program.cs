using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eldontes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = {9, 7, 8, 2, 4, 6, 1, 5};
            int n = t.Length;
            //int ker = 3;
            int ker;
            Console.WriteLine("Add meg a keresett számot: ");
            ker = int.Parse(Console.ReadLine());

            int i = 0;
            while (i < n && t[i] != ker)
                i++;
            if(i<n)
                Console.WriteLine("Benne van ");
            else
                Console.WriteLine("Nincs benne");

            //bool van = false;
            //for (int i = 0; i < n; i++)
            //    if (t[i] == ker)
            //        van = true;
            
            //Console.WriteLine("Igaz-e hogy a keresett szám eleme a tömbnek: {0}", van);
            Console.ReadLine();
            

            
        }
    }
}
