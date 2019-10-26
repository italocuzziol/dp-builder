using System;
using System.Collections.Generic;
using System.Text;

namespace dp_builder.classes
{
    /// <summary>
    /// This class specifies single characteristics and follows how I build
    /// /// (it is HouseBuilder's sibling{  }
    /// </summary>
    class CastleBuilder : IBuilder
    {
        private Building building;

        public CastleBuilder()
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
