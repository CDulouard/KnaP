using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30Steps
{
    class Millenair
    {
        public int sum(int value)
        {
            int ans = 0;

            for(int i = 1; i<=value; i++)
            {
                ans += i;
            }
            
            return ans;
        }
    }
}
