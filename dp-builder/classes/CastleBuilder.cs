using System;
using System.Collections.Generic;
using System.Text;

namespace dp_builder.dp_builder
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

        public void buildOwner(){ building.setOwner("Villager"); }
        public void buildLocation(){ building.setLocation("Village"); }
        public void buildBasement(){ building.setBasement("Wooden Poles"); }
        public void buildStructure(){ building.setStructure("Wood"); }
        public void buildCeiling(){ building.setCeiling("Wood and Straw"); }
        public Building getBuilding() { return this.building; }
    }
}
