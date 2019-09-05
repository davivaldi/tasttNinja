using System;
using System.Collections.Generic;

namespace hungryNinjas
{
     abstract class Ninja
    {
    protected int calorieIntake;
    private bool isfull;
    public List<IConsumable> ConsumptionHistory;
    
    
    public Ninja(){
        calorieIntake = 0;
        ConsumptionHistory = new List<IConsumable>();
    }
    public abstract bool IsFull {get; }
    public abstract void Consume(IConsumable item);
    public void Eat(Food item)
    {
        if(!IsFull){
          

        }
    }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
