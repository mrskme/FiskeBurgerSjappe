using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            var texBurger = new TexBurger();
            texBurger.CheckMakeAndGiveBurger((int)FishName.Laks, (int)BreadName.Fint, 1);
            texBurger.CheckMakeAndGiveBurger((int)FishName.Ørret, (int)BreadName.Grovt, 2);
        }
    }
}
