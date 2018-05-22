using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    abstract class Client : IClient
    {
        protected int tryCount;
        protected int state;

        public abstract int Pay();

        public int RandomWish(int n)
        {
            return new Random().Next(0, n);
        }

        public abstract void StateIncrement();

        public abstract void StateDecrement();
    }
}
