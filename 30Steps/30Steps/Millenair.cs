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

    }

    


}
