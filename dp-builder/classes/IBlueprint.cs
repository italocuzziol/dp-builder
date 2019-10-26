using System;
using System.Collections.Generic;
using System.Text;

namespace dp_builder.dp_builder
{
    /// <summary>
    /// This interface specifies the way how I do a product
    /// </summary>
    interface IBlueprint
    {

        public void setOwner(string owner);
        public void setLocation(string location);
        public void setBasement(string basement);
        public void setStructure(string structure);
        public void setCeiling(string ceiling);
        public void setInterior(string interior);

    }
}