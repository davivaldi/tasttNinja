using System;
using System.Collections.Generic;

namespace hungryNinjas
{

class SpiceHound : Ninja
{
public override void Consume(IConsumable item){
    if(IsFull){
        Console.WriteLine("SpiceHound is full and cannot eat anymore");
    }
    else{
        //  revisit later ************************************************
    }
}
}


}