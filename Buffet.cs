using System;
using System.Collections.Generic;

namespace hungryNinjas
{
    class Buffet
    {
     public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Banana", 250, false, true),
            new Food("Khmer Stir Fry", 500, true, true),
            new Food("Pizza", 700, false, false),
            new Food("Bacon Cheeseburger", 1200,false,false),
            new Food("guacamole", 450,true,false),
            new Food("Salad", 1,false,false),
            new Food("Ice Cream", 600,false,true)
        };
    }
     
    public Food Serve()
    {
        Random rand = new Random();
        return Menu[rand.Next(Menu.Count)];
//         for (int i = 0; i < Menu.Count; i++)
// {
// }
    }
        static void Main(string[] args)
        {
        
        }
    }
}
