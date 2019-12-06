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

        public readonly List<Component.ComponentType> compatibleTypes;
                
        public Material(double thermalConductivity, List<Component.ComponentType> types)
        {
            if (thermalConductivity < 0)
            {
                throw new ArgumentException("Thermal conductivity must be a positive non-zero value.");
            }
            this.thermalConductivity = thermalConductivity;
            this.compatibleTypes = types;
        }
        
        public double GetThermalConductivity()
        {
            return thermalConductivity;
        }
    }
}
