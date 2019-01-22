using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30Steps
{
    class hippo
    {
        public void exercice64()
        {   // la fonction retounre le produit de chaque case du tableau avec toute les cases d'avant. 
            int[] tableau = { 1, 4, 6, 2, 6 };
            Console.Write("Tableau: \n");
            int i;
            for (i = 1; i < 5; i++)
            {
                Console.Write("{0} \n", tableau[i - 1]);
                tableau[i] = tableau[i] * tableau[i - 1];
            }
            Console.Write("{0} \n", tableau[i - 1]);

        }
        public void exercice65()
        {
            int[] tableau= { 1, 0, 0, 0, 0, 0};
            Console.Write("Tableau: \n");
            int i;
            for (i = 1; i < 5; i++)
            {
                Console.Write("{0} \n", tableau[i - 1]);
                tableau[i] = tableau[i - 1] +2;
            }
            Console.Write("{0} \n", tableau[i - 1]);
        }
        public void exercice66()
        {
            Console.Write("CA FAIT UN TABLEAU OU CHAQUE CASE EST LE RESULTAT DE LA SOMME DES DEUX CASES AVANT PUTAIN");
            Console.ReadLine();
        }
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
            int E, sommedue, M, reste, Nb10e, Nb5e;
            E = 1;
            sommedue = 0;
            Nb10e = 0;
            Nb5e = 0;
            Console.Write("entrez le montant : ");
            E = Convert.ToInt32(Console.ReadLine());
            sommedue += E;
            Console.Write("vous devez {0} euros \n", sommedue);
            Console.Write("montant versé : ");
            M = Convert.ToInt32(Console.ReadLine());
            reste = M - sommedue;
            while (reste >= 10)
            {
                Nb10e++;
                reste = reste - 10;
            }
            if (reste >= 5)
            {
                Nb5e = 1;
                reste = reste - 5;
            }
            Console.Write("billets de 10 euros : {0} \n Billets de 5 euros : {1} \n Pieces de 1 euro : {2}", Nb10e, Nb5e, reste);
        }   
        
    }
}