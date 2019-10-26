using System;

namespace dp_builder.classes
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilder castleBuilder = new CastleBuilder();
            IBuilder houseBuilder = new HouseBuilder();

            Peon peon = new Peon();

            peon.setBuilding(castleBuilder);
            peon.constructBuilding();
            Building castle = peon.getBuilding();

            peon.setBuilding(houseBuilder);
            peon.constructBuilding();
            Building house = peon.getBuilding();

            Console.WriteLine(castle.Owner);
            Console.WriteLine(house.Owner);
        }
    }
}
