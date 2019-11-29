using System;
using System.Collections.Generic;
using System.Text;

namespace uTest
{
    class Material
    {

        /// <summary>
        /// Specific thermal conductivity of this layer in W / (K * m)
        /// </summary>
        private readonly double thermalConductivity;

        private List<Component.ComponentType> compatibleTypes;

        Component.ComponentType type;


        public Material(double thermalConductivity, List<Component.ComponentType> compatibleTypes)
        {
            if (thermalConductivity > 0)
            {
                throw new ArgumentException("Thermal conductivity must be a positive non-zero value.");
            }
            else
            {
                this.thermalConductivity = thermalConductivity;
            }
           
            if (compatibleTypes.Count == 0)
            {
                throw new ArgumentException("List of compatible types must have at least one member.");
            }
            else
            {
                this.compatibleTypes = compatibleTypes;
            }
        }

        public double GetThermalConductivity()
        {
            return thermalConductivity;
        }

        public List<Component.ComponentType> GetCompatibility()
        {
            return this.compatibleTypes;
        }
    
    }
}
