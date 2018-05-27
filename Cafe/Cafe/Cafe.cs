using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
            food = new List<string>();
            food.Add("Tea".ToUpper());
            food.Add("Coffee".ToUpper());
            food.Add("Ice cream".ToUpper());
            Play();
        }

        private string ClientState()
        {

            if (client.State == 0) return "Angry".ToUpper();
            else if (client.State == 1) return "Dissatisfied".ToUpper();
            else if (client.State == 2) return "Neutral".ToUpper();
            else if (client.State == 3) return "Happy".ToUpper();
            else return "Error";
        }

        public bool endCheck()
        {
            if (balance >= 0 && balance < 100)
                return false;
            return true;
        }

        public void Play()
        {
            int choice, wish;
            View v = new View();
            client = new CurrentClient();

            while(true)
            {
                if (endCheck())
                    break;
                if(client.TryCount == 0 || client.State == 0 || client.State == 3)
                {
                    balance += client.Pay();
                    Console.WriteLine("You`ve earned {0}", client.Pay());
                    Console.WriteLine("\n{0}",new String('*', 30));

                    if (endCheck())
                        break;
                    Thread.Sleep(1500);
                    Console.WriteLine("You`ve got a new client!");
                    client = new CurrentClient();
                }
                v.Game(balance, client.TryCount, ClientState());
                wish = client.RandomWish(food.Count);
                choice = v.makeChoice(food);
                if (choice == -1)
                {
                    Console.WriteLine("\nYou finished the game or some error occurred.");
                    Console.WriteLine("GAME OVER");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (choice == wish)
                    client.StateIncrement();
                else
                    client.StateDecrement();

                v.current(food[choice], food[wish]);
                Thread.Sleep(1000);

            }

            Console.WriteLine("\nYou balance is {0}", balance);
            if (balance >= 100)
                Console.WriteLine("You win! Congratulations!");
            else
                Console.WriteLine("You lose.\nGAME OVER");
        }
    }
}
