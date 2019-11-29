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

        public Layer(Material material, double thickness)
        {
            if (thickness > 0)
            {
                this.thickness = thickness;
            }
            else
            {
                throw new ArgumentException("Thickness must be a positive non-zero value.");
            }
            
            this.material = material;
        }
        public double GetRValue()
        {
            return thickness / material.GetThermalConductivity();
        }

        public bool CheckCompatibility(Component.ComponentType type1)
        {
            bool compatibilityCheck = false;

            foreach (Component.ComponentType type2 in material.GetCompatibility())
            {
                if (type1 == type2)
                    compatibilityCheck = true;
            }

            return compatibilityCheck;
        }
    }
}   
