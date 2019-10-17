using System;

namespace digersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Earthworm eddie = new Earthworm ("Eddie", "earthworm");
           eddie.Dig();
           RattleSnake rusty = new RattleSnake("Rusty", "rattlesnake");
           rusty.Run();
           rusty.Walk();
           rusty.Dig();
        }
    }
}
// Parakeets
// Earthworms
// Terrapins
// Timber Rattlesnake
// Mice
// Ants
// Finches
// Betta Fish
// Copperhead snake
// Gerbils

//seperate into these categories
// 1 Animals that dig and live in the ground
// 2 Animals that move about on the ground
// 3 Animals that swim in water
// 4 Animals that fly above the ground