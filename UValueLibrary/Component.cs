using System.Collections.Generic;

namespace UValue
{
    public class Component
    {
        //private readonly List<Layer> layers;
        public List<Layer> layers;

        public ComponentType type;

        public double surfaceArea;
        public enum ComponentType { wall, floor }

        public Component(List<Layer> layers, ComponentType type)
        {
            this.layers = layers;
            this.type = type;
        }

        public Component(List<Layer> layers, ComponentType type, double surfaceArea)
        {
            this.layers = layers;
            this.type = type;
            this.surfaceArea = surfaceArea;
        }

        public double GetUValue()
        {
            return 1 / (this.GetRValueSum());
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
