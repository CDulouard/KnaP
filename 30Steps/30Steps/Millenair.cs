﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30Steps
{
    class Millenair
    {
        public int Sum(int value) //exo 5.6
        {
            int ans = 0;

            for(int i = 1; i<=value; i++)
            {
                ans += i;
            }
            
            return ans;
        }

        public int Factorielle(int value) //exo 5.7
        {
            int ans = 1;
            for (int i = 1; i <= value; i++)
            {
                ans *= i;
            }
            return ans;
        }

        public void Input_20() //exo 5.8
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

        public void Input0() //exo 5.9
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

        public void Proba(int nb_chevaux, int nb_joue) //exo 6.11
        {
            int nf = Factorielle(nb_chevaux);
            int pf = Factorielle(nb_joue);
            int nmpf = Factorielle(nb_chevaux - nb_joue);
            double X = nf / nmpf;
            double Y = nf / (pf * nmpf);

            Console.WriteLine("\nDans l'ordre : Une chance sur " + X +" de gagner\nDans le desordre : Une chance sur " + Y + " de gagner");
        }

        public void Input_20p1() //6.12
        {
            int[] temp = new int[20];

            for (int i = 1; i <= 20; i++)
            {

                Console.WriteLine("Entrez nb " + i + " : ");
                temp[i - 1] = int.Parse(Console.ReadLine());

            }
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine(temp[i] + 1);
            }
        }

        public void Input0_12() //6.13
        {
            List<int> temp = new List<int>();

            int i = 0;
            int max = 0;
            int pos = 0;

            Console.WriteLine("Entrez nb " + (i + 1) + " : ");
            temp.Add(int.Parse(Console.ReadLine()));

            while (temp[i] != 0)
            {
                i++;
                Console.WriteLine("Entrez nb " + (i + 1) + " : ");
                temp.Add(int.Parse(Console.ReadLine()));
               
            }

            Console.WriteLine("\nMax : " + temp.Max() + "\nPos : " + ( 
temp.IndexOf(temp.Max()) + 1));


        }

        public void Input_notes() //6.14
        {
            List<int> temp = new List<int>();

            int i = 0;
            int max = 0;
            int pos = 0;
            int count = 0;

            do
            {
                Console.WriteLine("Entrez nb " + (i + 1) + " : ");
                temp.Add(int.Parse(Console.ReadLine()));
                i++;

            } while (temp[i - 1] != 0);

            temp.RemoveAt(i - 1);
            double avg = temp.Average();


            for (int j = 0; j < temp.Count(); j++)
            {
                if (temp[j] > avg)
                {
                    count++;
                }
            }

            Console.WriteLine("Moyenne : " + avg);
            Console.WriteLine("Nb notes > moyenne : " + count);


        }
    }

    


}
