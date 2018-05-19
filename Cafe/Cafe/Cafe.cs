using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class Cafe
    {
        int balance;
        List<string> food;

        public Cafe()
        {
            balance = 10;
            food.Add("Tea");
            food.Add("Coffee");
            food.Add("Ice cream");
        }

        public void Play()
        {
            Console.Title = "CAFE";
            Console.WriteLine("CURRENT BALANCE: " );
        }
    }
}
