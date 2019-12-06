using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
namespace validTests
{
    public class testComponent
    {
        [Theory]
        [InlineData(20)]
        public double GetRValue(double expected)
        {
            List<Component.ComponentType> brickCompatibleTypes = new List<Component.ComponentType>();
            List<Component.ComponentType> cementCompatibleTypes = new List<Component.ComponentType>();

            brickCompatibleTypes.Add(Component.ComponentType.wall);
            cementCompatibleTypes.Add(Component.ComponentType.wall);
            cementCompatibleTypes.Add(Component.ComponentType.floor);

            Material brick = new Material(1, brickCompatibleTypes);
            Material cement = new Material(2, cementCompatibleTypes);

            Layer brickLayer = new Layer(brick, 10);
            Layer cementLayer = new Layer(cement, 20);

            List<Layer> layers = new List<Layer>
            {
                brickLayer,
                cementLayer
            };

            //Component wall = new Component(layers, Component.ComponentType.wall);

            double output = 0;
            foreach (Layer layer in layers)
            {
                output += layer.GetRValue();
            }

            Assert.Equal(expected, output);

            return output;
        }

        [Theory]
        [InlineData(1, 1)]
        public double GetUValueSum(double Rse, double Rsi)
        {
            List<Component.ComponentType> brickCompatibleTypes = new List<Component.ComponentType>();
            List<Component.ComponentType> cementCompatibleTypes = new List<Component.ComponentType>();

            brickCompatibleTypes.Add(Component.ComponentType.wall);
            cementCompatibleTypes.Add(Component.ComponentType.wall);
            cementCompatibleTypes.Add(Component.ComponentType.floor);

            Material brick = new Material(1, brickCompatibleTypes);
            Material cement = new Material(2, cementCompatibleTypes);

            Layer brickLayer = new Layer(brick, 10);
            Layer cementLayer = new Layer(cement, 20);

            List<Layer> layers = new List<Layer>
            {
                brickLayer,
                cementLayer
            };

            Component wall = new Component(layers, Component.ComponentType.wall);

            double u = 1 / (wall.GetRValueSum() + Rse + Rsi);

            Assert.Equal(20, wall.GetRValueSum());
            Assert.Equal((double) 1 / 22, u);

            return u;
        }
    }
}
