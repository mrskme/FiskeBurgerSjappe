using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Lettuce
    {
        public string Name;
        public int Amount;
        public Lettuce(int amount)
        {
            Amount = amount;
            Name = "Isberg salat";
        }
        public void SubtractLettuce()
        {
            Amount -= 1;
        }
    }
}
