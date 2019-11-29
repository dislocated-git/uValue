using System;
using System.Collections.Generic;
using System.Text;

namespace uTest
{
    class Component
    {

        public enum ComponentType
        {
            Wall,
            CeilingFloor,
            Window,
            Door
        }

        private readonly List<Layer> layers;
        private ComponentType componentType;


        public Component(ComponentType componentType, List<Layer> layers)
        {
            
            this.componentType = componentType;

            bool layersCompatible = true;
            foreach (Layer layer in layers)
            {
               if (!layer.CheckCompatibility(this.componentType))
                {
                    layersCompatible = false;
                }
            }
            if (!layersCompatible)
            {
                throw new ArgumentException("Given layers are incompatible with this component type.");
            }

        }
        /// <summary>
        /// Returns a U Value of this component.
        /// </summary>
        /// <param name="Rse">External heat transfer resistance.</param>
        /// <param name="Rsi">Internal heat trasnfer resistance.</param>
        /// <returns></returns>
        public double GetUValue(double Rse, double Rsi)
        {
            return 1 / (this.GetRValueSum() + Rse + Rsi);
        }

        private double GetRValueSum()
        {
            double output = 0;
            foreach (Layer layer in layers)
            {
                output += layer.GetRValue();
            }
            return output;
        }
    }
}
