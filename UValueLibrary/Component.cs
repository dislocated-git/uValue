using System.Collections.Generic;

namespace UValue
{
    public class Component
    {
        //private readonly List<Layer> layers;
        public List<Layer> layers;

        public ComponentType type;

        public enum ComponentType { wall, floor }

        public Component(List<Layer> layers, ComponentType type)
        {
            this.layers = layers;
            this.type = type;
        }
        /// <summary>
        /// Returns a U Value of this component.
        /// </summary>
        /// <param name="Rse">External heat transfer resistance.</param>
        /// <param name="Rsi">Internal heat transfer resistance.</param>
        /// <returns></returns>
        /// 

        public double GetUValue(double Rse, double Rsi)
        {
            return 1 / (this.GetRValueSum() + Rse + Rsi);
        }

        public double GetRValueSum()
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
