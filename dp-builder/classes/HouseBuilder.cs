using System;
using System.Collections.Generic;
using System.Text;

namespace dp_builder.dp_builder
{
    /// <summary>
    /// This class specifies single characteristics and follows how I build
    /// (it is CastleBuilder's sibling)
    /// </summary>
    class HouseBuilder : IBuilder
    {
        private Building building;

        public HouseBuilder()
        {
            this.building = new Building();
        }

        public void buildOwner() { building.setOwner("Dracula"); }
        public void buildLocation() { building.setLocation("Mountain"); }
        public void buildBasement() { building.setBasement("Concrete"); }
        public void buildStructure() { building.setStructure("Bricks"); }
        public void buildCeiling() { building.setCeiling("Roof tiles"); }
        public Building getBuilding() { return this.building; }
    }
}
