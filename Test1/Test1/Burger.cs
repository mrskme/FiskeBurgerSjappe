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

        public Burger(string burgerType, string lettuceName, string bread)
        {
            BurgerType = burgerType;
            Bread = bread;
            Lettuce = lettuceName;

        }
        public string MakeBurgerText()
        {
            return $"Din burger består av {BurgerType} og {Lettuce} og {Bread}";
        }
    }
}
