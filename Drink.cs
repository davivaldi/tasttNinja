using System;

namespace hungryNinjas
{
class Drink : IConsumable
{
    public string Name {get;set;}
    public int Calories {get;set;}
    public bool IsSpicy {get;set;}
    public bool IsSweet {get;set;}
    
    public string GetInfo(){
        return  $"{Name} (food).  Calories: {Calories}. Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
    }
    public Drink(string name, int calories, bool spicy, bool sweet){
        Name= name;
        Calories = calories;
        IsSpicy = spicy;
        IsSweet = sweet;
    }
}   
}