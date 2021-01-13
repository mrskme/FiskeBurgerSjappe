using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Bread
    {
        public string Name;
        public int Amount;

        public Bread(string brødType, int amount)
        {
            Name = brødType;
            Amount = amount;
        }
        public void subtractBread()
        {
            Amount -= 1;
        }
    }
}
