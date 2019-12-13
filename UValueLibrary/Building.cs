using System.Collections.Generic;

namespace UValue
{
    internal class Building
    {
        public List<Component> components;

        public Building(List<Component> components)
        {
            this.components = components;
        }

        public double GetBuildingUValue()
        {
            double totalSurfaceArea = 0;
            double sumCombinedSU = 0;

            foreach (Component c in components)
            {
                totalSurfaceArea += c.surfaceArea;
                sumCombinedSU += c.surfaceArea * c.GetUValue();
            }

            double uValue = sumCombinedSU / totalSurfaceArea;

            return uValue;
        }
    }
}