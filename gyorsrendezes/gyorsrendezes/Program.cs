using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyorsrendezes
{
    class Program
    {
        static int[] t = { 8, 3, 9, 1, 5, 2, 7 };
        static void gyorsrendezes(int also, int felso)
        {
            int i = also;
            int j = felso;
            int kozep = t[(felso + also)/2];
            while (also <= felso)
            {
                while (also < j && t[also] < kozep)
                    also++;
                while (felso > i && t[felso] > kozep)
                    felso--;
                if (also<=felso)
                {
                    int tmp = t[also];
                    t[also] = t[felso];
                    t[felso] = tmp;
                    ++also;
                    --felso;
                }
                
            }
            if (also < j) gyorsrendezes(also, j);
            if (i<felso) gyorsrendezes(i, felso);
        }

        static void Main()
        {
            int n = t.Length;

            for (int i = 0; i < n; i++)
                Console.Write(t[i] + " ");
            Console.WriteLine();

            gyorsrendezes(0, 6);
            for (int i = 0; i < n; i++)
                Console.Write(t[i] + " ");
            Console.WriteLine();
            {

            }
            Console.ReadLine();
        }
        
    }
}
