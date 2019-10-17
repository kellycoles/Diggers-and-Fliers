
using System;

namespace digersAndFliers {
public class Earthworm: Animal, IDig
{
//this is needed because of the constructor in the base class, Animal
    public Earthworm(string name, string type):base(name, type) {
        Name = name;
        Type = type;
    }
    public int MaximumDiameter { get; } = 1;
    public void Dig() {
        Console.WriteLine($"{Name} the {Type} is now digging a hole {MaximumDiameter} cm wide");
    }
}
}
    