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

        public Material(double thermalConductivity)
        {
            if (thermalConductivity > 0)
            {
                throw new ArgumentException("Thermal conductivity must be a positive non-zero value.");
            }
            this.thermalConductivity = thermalConductivity;
        }

        public double GetThermalConductivity()
        {
            return thermalConductivity;
        }
    
    }
}
