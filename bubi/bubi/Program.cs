using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[] { 5, 4, 9, 3, 7};
            int n = t.Length;

            for (int i = 0; i < n; i++)
                Console.Write("{0},", t[i]);
            Console.WriteLine();

            //Buborék rendezés
            for (int i = n-1; i > 0; i--)
                for (int j = 0; j < i; j++)
                    if (t[j] > t[j+1])
                    {
                        int tmp = t[j + 1];
                        t[j + 1] = t[j];
                        t[j] = tmp;
                    }
            //kiíratás rendezés után
            for (int i = 0; i < n; i++)
                Console.Write("{0},",t[i]);
            Console.WriteLine();
            Console.ReadLine();           
        }
    }
}
