using System;
using System.Collections.Generic;

namespace UValue
{
    public class Material
    {

        /// <summary>
        /// Specific thermal conductivity of this layer in W / (K * m)
        /// </summary>
        private readonly double thermalConductivity;

        public readonly List<Component.ComponentType> compatibleTypes;

        private string _name;

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

        public event EventHandler NameChanged;

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

        public double GetThermalConductivity()
        {
            return thermalConductivity;
        }
    }
}
