using System;
using System.Collections.Generic;

namespace hungryNinjas
{
     public class Ninja
    {
    private int calorieIntake;
    private bool isfull;
    public List<Food> FoodHistory;
    
    public bool Isfull{
        get{ return Isfull;}
    }
    public Ninja(){
        calorieIntake = 0;
        List<Food>FoodHistory = new List<Food>();
    }
    public void Eat(Food item)
    {
        if(!Isfull){
            
        }
    }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
