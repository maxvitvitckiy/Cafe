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

        private string ClientState()
        {

            if (client.State == 0) return "Angry";
            else if (client.State == 1) return "Dissatisfied";
            else if (client.State == 2) return "Neutral";
            else if (client.State == 3) return "Happy";
            else return "Error";
        }

        public void Play()
        {
            string sState;
            do
            {
                sState = ClientState();

            } while (balance > 0 && balance < 100);
        }
    }
}
