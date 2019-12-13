using System;

namespace UValue
{
    public class Layer
    {
        private Material material;
        public string _name;

        /// <summary>
        /// The thickness of the layer in m.
        /// </summary>
        private double _thickness;

        public double Thickness
        {
            get
            {
                return _thickness;
            }
            set
            {
                _thickness = value;
                ThicknessChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                NameChanged?.Invoke(this, EventArgs.Empty);
            }
        }
       
        public event EventHandler ThicknessChanged;
        public event EventHandler NameChanged;

        public Layer(Material material, int thickness)
        {
            this.Thickness = thickness;
            this.material = material;
        }

        public Layer(Material material, int thickness, string name)
        {
            this.Thickness = thickness;
            this.material = material;
            this.Name = name;
        }

        public double GetRValue()
        {
            return Thickness / material.GetThermalConductivity();
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
