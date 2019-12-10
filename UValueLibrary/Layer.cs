namespace UValue
{
    public class Layer
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

        public bool CheckCompatibility(Component.ComponentType type2)
        {
            bool isCompatible = false;

            foreach (Component.ComponentType type1 in material.compatibleTypes)
            {
                if (type1 == type2)
                {
                    isCompatible = true;
                }
                else
                {
                    isCompatible = false;
                }
            }

            return isCompatible;
        }
    }
}
