using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            var texBurger = new TexBurger();

            texBurger.MakeBurger((FishName)0, "Fint",2);
            texBurger.MakeBurger((FishName)1, "Grovt", 1);

            texBurger.GiveBurgersToCustomer();
        }
    }
}
