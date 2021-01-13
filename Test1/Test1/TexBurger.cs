using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public enum FishName {Laks, Ørret}
    public enum BreadName {Fint, Grovt}
    class TexBurger
    {
        private List<Burger> Burgers = new List<Burger>();
        public int BurgersAmount;

        FishBurger[] fishes = new FishBurger[] { new FishBurger("Laks", 50), new FishBurger("Ørret", 20) };
        Lettuce lettuce = new Lettuce(50);
        Bread[] breads = new Bread[] { new Bread("Fint", 20), new Bread("Grovt", 50) };

        public void MakeBurger(FishName fishType, string bread, int amount)
        {
            FishBurger chosenFish;
            Bread chosenBread;
            for (var i = 0; i < amount; i++) 
            { 
                if (fishType == FishName.Laks) chosenFish = fishes[0];
                else if (fishType == FishName.Ørret) chosenFish = fishes[1];
                else return;
                if (bread == "Fint") chosenBread = breads[0];
                else if(bread == "Grovt") chosenBread = breads[1];
                else return;
            
                SubtractIngredent(chosenFish.Amount);
                SubtractIngredent(chosenBread.Amount);
                SubtractIngredent(lettuce.Amount);
                
                Burgers.Add(new Burger(chosenFish.Name, lettuce.Name, chosenBread.Name));
                BurgersAmount++;
            }
        }
        public void GiveBurgersToCustomer()
        {
            foreach (var burger in Burgers) Console.WriteLine(burger.MakeBurgerText());
        }
        public void SubtractIngredent(int ingredientAmount)
        {
            ingredientAmount--;
        }
    }
}
