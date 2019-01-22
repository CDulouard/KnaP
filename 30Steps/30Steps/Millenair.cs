using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30Steps
{
    class Millenair
    {
        public int sum(int value) //exo 5.6
        {
            int ans = 0;

            for(int i = 1; i<=value; i++)
            {
                ans += i;
            }
            
            return ans;
        }

        public int Factorielle(int value)
        {
            int ans = 1;
            for (int i = 1; i <= value; i++)
            {
                ans *= i;
            }
            return ans;
        }

        public void Input_20()
        {
            int temp;
            int max = 0;
            int pos = 0;
            
            for (int i = 1; i <= 20; i++)
            {
                
                Console.WriteLine("Entrez nb " + i + " : ");
                temp =  int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    max = temp;
                    pos = i;
                }
                else
                {
                    if (temp > max)
                    {
                        max = temp;
                        pos = i;
                    }
                }
            }
            Console.WriteLine("max : " + max + "\npos : " + pos);

        }

        public void Input0()
        {
            int temp;
            int max = 0;
            int pos = 1;
            int i = 1;
            Console.WriteLine("Entrez nb " + i + " : ");
            temp = int.Parse(Console.ReadLine());

            while (temp != 0)
            {

                
                

                if (i == 1)
                {
                    max = temp;
                    pos = i;
                }
                else
                {
                    Console.WriteLine("Entrez nb " + i + " : ");
                    temp = int.Parse(Console.ReadLine());
                    if (temp > max)
                    {
                        max = temp;
                        pos = i;
                    }
                }
                i++;
            }
            Console.WriteLine("max : " + max + "\npos : " + pos);

        }

    }

    


}
