using System;

namespace digersAndFliers {
public interface IGroundMove
{
    void Run();
    void Walk();
     int MaximumSpeed {get;}
}
}