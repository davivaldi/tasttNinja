using System;

namespace hungryNinjas
{
    public class Food
    {
    public string Name;
    public int Calories;
    public bool IsSpicy; 
    public bool IsSweet; 

    public Food(string name, int calories, bool spicy, bool sweet){
        Name= name;
        Calories = calories;
        IsSpicy = spicy;
        IsSweet = sweet;
    }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
