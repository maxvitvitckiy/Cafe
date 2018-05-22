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
            Console.WriteLine("Current cafe balance: {0}", balance);
            Console.WriteLine("Try to guess your client`s wish.");
            Console.WriteLine("Client {0}, count of tries: {1}", state, count);
        }

        public void printFood(List<string> l)
        {
            for(int i = 0; i < l.Count; i++)
                Console.WriteLine("{0}. {1}", i+1, l[i]);
        }

        public int makeChoice(List<string> l)
        {
            int i;
            Console.WriteLine("0. Exit");
            printFood(l);
            Console.Write("Your choice: ");
            int.TryParse(Console.ReadLine(), out (i));
            if (i > l.Count)
                return -1;
            return i - 1;
        }

        public void current(string choice, string wish)
        {
            Console.WriteLine("\nClient`s wish was {0}", wish);
            Console.WriteLine("Your choice was {0}\n", choice);
        }
    }
}
