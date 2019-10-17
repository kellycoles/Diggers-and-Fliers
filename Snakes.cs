    using System;

    namespace digersAndFliers {
public class Snakes : Animal, IGroundMove{
    public Snakes(string name, string type):base(name, type) {
        Name = name;
        Type = type;
    }
    //IGroundMove
       public void Run () {
           Console.WriteLine($"{Name} the {Type} is now running {MaximumSpeed +1} miles per hour");
       }
    public void Walk() {
        Console.WriteLine($"{Name} the {Type} is now walking {MaximumSpeed} miles per hour");
    }
    //can you reset the max speed based on walking or running???
     public int MaximumSpeed {get;} = 1;



}

    }