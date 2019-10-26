using System;
using System.Collections.Generic;
using System.Text;

namespace dp_builder.classes
{
    /// <summary>
    /// This interface specifies how I build the product
    /// </summary>
    interface IBuilder
    {
        public void buildOwner();
        public void buildLocation();
        public void buildBasement();
        public void buildStructure();
        public void buildCeiling();
        public Building getBuilding();
    }
}
