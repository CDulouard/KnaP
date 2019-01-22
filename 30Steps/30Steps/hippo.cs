using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30Steps
{
    class hippo
    {
        public void exercice55()
        {
            int j, n;

            Console.Write("Table de multiplication:\n");
            Console.Write("\n\n");

            Console.Write("quelle est la table? : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }
        }
    }
}