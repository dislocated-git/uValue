using System;
using System.Collections.Generic;

namespace UValue
{
    public class Material
    {

        public readonly List<Component.ComponentType> compatibleTypes;

        /// <summary>
        /// Specific thermal conductivity of this layer in W / (K * m)
        /// </summary>
        private readonly double thermalConductivity;
        private string _name;

        public Material(double thermalConductivity, List<Component.ComponentType> types)
        {
            if (thermalConductivity < 0)
            {
                throw new ArgumentException("Thermal conductivity must be a positive non-zero value.");
            }
            this.thermalConductivity = thermalConductivity;
            this.compatibleTypes = types;
        }

        public Material(string name, double thermalConductivity, List<Component.ComponentType> types)
        {
            if (thermalConductivity < 0)
            {
                throw new ArgumentException("Thermal conductivity must be a positive non-zero value.");
            }
            this.thermalConductivity = thermalConductivity;
            this.compatibleTypes = types;
            this.Name = name;
        }

        public event EventHandler NameChanged;

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
        public double GetThermalConductivity()
        {
            return thermalConductivity;
        }
    }
}
