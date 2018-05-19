using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class CurrentClient:IClient
    {
        int tryCount;
        int state;

        public CurrentClient()
        {
            tryCount = 3;
            Random rand = new Random();
            state = rand.Next(1, 2);
        }

        public int Pay()
        {
            if (state == 0) return -10;
            else return state * 10;
        }
    }
}
