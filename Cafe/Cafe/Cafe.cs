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
        CurrentClient client;

        public Cafe()
        {
            balance = 10;
            food.Add("Tea");
            food.Add("Coffee");
            food.Add("Ice cream");
            client = new CurrentClient();
            Play();
        }

        public void Play()
        {
            Console.Title = "CAFE";
            Console.WriteLine("CURRENT BALANCE: " + balance);
            string sState;
            do
            {
                if()
                Console.WriteLine("Client state: " + client.);
            }
        }
    }
}
