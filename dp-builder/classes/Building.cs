using System;
using System.Collections.Generic;
using System.Text;

namespace dp_builder.dp_builder
{
    /// <summary>
    /// This class specifies the generic product that follows the way I do
    /// </summary>
    class Building : IBlueprint
    {
        
        private string owner;
        private string location;
        private string basement;
        private string structure;
        private string ceiling;
        private string interior;

        public void setOwner(string owner) { this.owner = owner; }
        public void setLocation(string location) { this.location = location;  }
        public void setBasement(string basement) { this.basement = basement; }
        public void setStructure(string structure) { this.structure = structure; }
        public void setCeiling(string ceiling) { this.ceiling = ceiling; }
        public void setInterior(string interior) { this.interior = interior; }
    }
}
