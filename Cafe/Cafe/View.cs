using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class View
    {


        public void Game(int balance, int count, string state)
        {
            Console.Title = "Game \"Cafe\"";
            
            Console.WriteLine("Current cafe balance: {0}", balance);
            Console.WriteLine("Client {0}, count of tries: {1}", state, count);


        }

        public int makeChoice()
        {
            int i = -1;
            Console.WriteLine("\nMenu:\n1. Tea\n2. Coffee\n3. Ice-cream\nTo exit - 0");
            Console.Write("Your choice: ");
            int.TryParse(Console.ReadLine(), out (i));
            return i - 1;
        }
    }
}
