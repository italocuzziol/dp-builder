using System;
using System.Collections.Generic;
using System.Text;

namespace dp_builder.classes
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

        public string Owner { get => owner; private set => owner = value; }
        public string Location { get => location; private set => location = value; }
        public string Basement { get => basement; private set => basement = value; }
        public string Structure { get => structure; private set => structure = value; }
        public string Ceiling { get => ceiling; private set => ceiling = value; }

        public void setOwner(string owner) { this.Owner = owner; }
        public void setLocation(string location) { this.Location = location;  }
        public void setBasement(string basement) { this.Basement = basement; }
        public void setStructure(string structure) { this.Structure = structure; }
        public void setCeiling(string ceiling) { this.Ceiling = ceiling; }
    }
}
