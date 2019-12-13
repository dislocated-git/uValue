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

namespace UCalc.Controls.UserControls
{
    public partial class ComponentCreationDialog : UserControl
    {
        private List<Layer> currentLayers = new List<Layer>();
        LayersList layersList;
        public ComponentCreationDialog()
        {
            InitializeComponent();
            Storage.MaterialsChanged += Storage_MaterialsChanged;
            layersList = new LayersList();

            layersListPanel.Controls.Add(layersList);
            layersList.Dock = DockStyle.Fill;
        }

        private void Storage_MaterialsChanged(object sender, EventArgs e)
        {
            PopulateMaterialList();
        }

        private void ComponentCreationDialog_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void PopulateMaterialList()
        {//use combobox, instead (it's pretty much the same code)   okay
         // this is the combobox object in the designer   okayy i see now i didnt know it already existed
         // yep that';s fine i just didn't write any logic for it.

            foreach (Material mat in Storage.GetMaterials())
            {
                materialsBox.Items.Add(mat.Name);
            }
        }

        private void materialCreateButton_Click(object sender, EventArgs e)
        {
            MaterialCreatePopup popup = new MaterialCreatePopup();
            popup.ShowDialog();
        }

        private void createLayer(object sender, MouseEventArgs e)
        {
            bool valid = true;
            if (String.IsNullOrWhiteSpace(newLayerName.Text))
            {
                valid = false;
                // invalid name
            }

            if (materialsBox.SelectedItem == null)
            {
                valid = false;
                // no material selected
            }

            if (valid)
            {
                Layer newLayer = new Layer(material: materialsBox.SelectedItem as Material,
                                           thickness: (int)thicknessInput.Value,
                                           name: newLayerName.Text);
                currentLayers.Add(newLayer);
                layersList.UpdateLayers(ref currentLayers);
            }
        }
    }
}
