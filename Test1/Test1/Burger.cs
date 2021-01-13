using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Burger
    {
        private string BurgerType;
        private string Lettuce;
        private string Bread;
        public static int TotalBurgers;

        public Burger(string burgerType, string lettuceName, string bread)
        {
            BurgerType = burgerType;
            Bread = bread;
            Lettuce = lettuceName;

        }
        public string MakeBurgerText()
        {
            return $"Burger {TotalBurgers}\nBurger: {BurgerType} \nSalat: {Lettuce} \nBrød: {Bread}\n\n";
        }
    }
}
