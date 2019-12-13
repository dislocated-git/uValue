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
using Component = UValue.Component;

namespace UCalc.Controls.UserControls
{
    public partial class LayersList : UserControl
    {
        public LayersList()
        {
            InitializeComponent();
        }

        private List<LayerEntry> oldEntries = new List<LayerEntry>(); 
        public void UpdateLayers(ref List<Layer> layers)
        {
            if (oldEntries.Count != 0)
            {
                foreach (LayerEntry entry in oldEntries) entry.Dispose();
            }
            foreach (Layer layer in layers)
            {
                LayerEntry entry = new LayerEntry(layer);
                oldEntries.Add(entry);
                listLayoutPanel.Controls.Add(entry);
                entry.Width = this.Width;
                entry.Dock = DockStyle.Fill;
            }
        }

        private void listLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LayersList_Load(object sender, EventArgs e)
        {

        }
    }
}
