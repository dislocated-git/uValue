using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UValue;

namespace UCalc
{
    public partial class LayerEntry : UserControl
    {
        public LayerEntry()
        {
            InitializeComponent();
        }

        public LayerEntry(Layer layer)
        {
            InitializeComponent();
            layer.NameChanged += Layer_NameChanged;
            layer.ThicknessChanged += Layer_ThicknessChanged;

            layerName.Text = layer.Name;
            layerThickness.Text = layer.Thickness.ToString();
            Dock = DockStyle.Fill;
        }

        private void Layer_ThicknessChanged(object sender, EventArgs e)
        {
            // This will update the values each time we edit the layer a UI element is bound to.
            string thickness = (sender as Layer).Thickness.ToString();
            layerThickness.Text = thickness + "mm";
        }

        private void Layer_NameChanged(object sender, EventArgs e)
        {
            layerName.Text = (sender as Layer).Name;
        }

        private void LayerEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
