using System;
using System.Collections.Generic;
using System.Text;

namespace validTests
{
    class Building
    {
        public List<Component> components;

        public Building(List<Component> components)
        {
            this.components = components;
        }


        // Commented this out for now, as the method references don't work yet.

        /*
        public double GetBuildingUValue()
        {
            double tsa = 0;
            double sAUValue = 0;

            foreach (Component c in components)
            {
                tsa += c.surfaceArea;
                sAUValue += c.surfaceArea * c.GetUValue();
            }

            double uValue = sAUValue / tsa;

            return uValue;
        }
        */

    }
}
