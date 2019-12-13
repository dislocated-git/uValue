using System;

namespace UValue
{
    public class Layer
    {
        public string _name;

        /// <summary>
        /// The thickness of the layer in m.
        /// </summary>
        private double _thickness;

        private Material material;

        public Layer(Material material, int Thickness)
        {
            this.Thickness = Thickness;
            this.material = material;
        }

        public Layer(Material material, int Thickness, string Name)
        {
            this.Thickness = Thickness;
            this.material = material;
            this.Name = Name;
        }

        public event EventHandler NameChanged;

        public event EventHandler ThicknessChanged;

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

        public double GetRValue()
        {
            return Thickness / material.GetThermalConductivity();
        }
    }
}