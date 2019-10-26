using System;
using System.Collections.Generic;
using System.Text;

namespace dp_builder.dp_builder
{
    /// <summary>
    /// This class is not actually part of the builder pattern but it helps to centralize the execution of specific builders
    /// </summary>
    class Peon
    {

        private IBuilder builder;

        public Peon(IBuilder builder)
        {
            this.builder = builder;
        }

        public void constructBuilding()
        {
            this.builder.buildBasement();
            this.builder.buildCeiling();
            this.builder.buildLocation();
            this.builder.buildOwner();
            this.builder.buildStructure();
        }

        public Building getBuilding()
        {
            return this.builder.getBuilding();
        }
    }
}
