    using System;

    namespace digersAndFliers {
        public class RattleSnake : Snakes, IDig {
            public RattleSnake (string name, string type) : base (name, type) {
                Name = name;
                Type = type;

            }

            public int MaximumDiameter { get; } = 3;

            public void Dig () {

                Console.WriteLine ($"{Name} the {Type} is now digging a hole {MaximumDiameter} inches wide");
            }
        }
    }

    //      //IDig
    //          int MaximumDiameter {get;} = 2;
    //    public void Dig(){
    // Console.WriteLine($"{Name} the {Type} is now digging a hole {MaximumDiameter} inches in diameter");