using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            Millenair test = new Millenair();

            test.Input_20();

            hippo hippovar= new hippo();
            hippovar.exercice55();
            Console.WriteLine(test.Factorielle(3));
            Console.ReadKey();

        }
    }
}
