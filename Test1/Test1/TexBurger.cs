using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public enum FishName {None =-1, Laks, Ørret}
    public enum BreadName {None =-1, Fint, Grovt}
    class TexBurger
    {
        private List<Burger> Burgers = new List<Burger>();
        FishBurger chosenFish;
        Bread chosenBread;

        FishBurger[] fishes = new FishBurger[] { new FishBurger("laks", 50), new FishBurger("ørret", 20) };
        Lettuce lettuce = new Lettuce(2);
        Bread[] breads = new Bread[] { new Bread("fint", 20), new Bread("grovt", 50) };

        public void CheckMakeAndGiveBurger(int fishName, int breadName, int amount)
        {
            for (var i = 0; i < amount; i++)
            {
                chosenFish = fishes[fishName];
                chosenBread = breads[breadName];

                if (chosenFish.Amount <= 0 || chosenBread.Amount <= 0 || lettuce.Amount <= 0) 
                { 
                    Console.WriteLine("Tom for ingrediens"); 
                    return; 
                }
                if (fishName == -1 || breadName == -1) 
                {
                    Console.WriteLine("Man må ha alle 3 ingrediensene foreløping");
                    return; 
                }

                SubtractIngredents();
                var newBurger = new Burger(chosenFish.Name, lettuce.Name, chosenBread.Name);
                Burgers.Add(newBurger);
                Burger.TotalBurgers++;

                Console.Write(newBurger.MakeBurgerText());
            }
        }
        public void SubtractIngredents()
        {
            lettuce.SubtractLettuce();
            chosenFish.SubtractFishBurger();
            chosenBread.subtractBread();
        }
    }
}
