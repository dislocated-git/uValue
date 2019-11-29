using System;
using System.Collections.Generic;
using System.Text;

namespace uTest
{
    class Layer
    {
        private Material material;
        /// <summary>
        /// The thickness of the layer in m.
        /// </summary>
        private readonly double thickness;

        public Layer(Material material, int thickness)
        {
            this.thickness = thickness;
            this.material = material;
        }
        public double GetRValue()
        {
            return thickness / material.GetThermalConductivity();
        }
    }
}
