using System;
using System.Collections.Generic;
using System.Text;

namespace uTest
{
    class Component
    {
        private readonly List<Layer> layers;

        public Component(List<Layer> layers)
        {
            this.layers = layers;
        }
        /// <summary>
        /// Returns a U Value of this component.
        /// </summary>
        /// <param name="Rse">External heat transfer resistance.</param>
        /// <param name="Rsi">Internal heat trasnfer resistance.</param>
        /// <returns></returns>
        public double GetUValue(double Rse, double Rsi)
        {
            return 1 / (this.GetRValue() + Rse + Rsi);
        }

        public double GetRValue()
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
