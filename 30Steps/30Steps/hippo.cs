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
        public void exercice510()
        {
            int E, sommedue, M, reste, Nb10e, Nb5e, Nb1e;
            E = 1;
            sommedue = 0;
            Console.Write("entrez le montant : ");
            E = Convert.ToInt32(Console.ReadLine());
            sommedue += E;
            Console.Write("vous devez {0} euros \n", sommedue);
            Console.Write("montant versé : ");
            M = Convert.ToInt32(Console.ReadLine());
            reste = M - sommedue;
            Nb10e = 0;
            while (reste >= 10)
            {
                Nb10e++;
                reste = reste - 10;
            }

        }   
        
    }
}