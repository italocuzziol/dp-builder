using System;
using System.Collections.Generic;
using System.Text;

namespace dp_builder.classes
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

        public void buildOwner() { building.setOwner("Villager"); }
        public void buildLocation() { building.setLocation("Village"); }
        public void buildBasement() { building.setBasement("Wooden Poles"); }
        public void buildStructure() { building.setStructure("Wood"); }
        public void buildCeiling() { building.setCeiling("Wood and Straw"); }
        public Building getBuilding() { return this.building; }
    }
}
