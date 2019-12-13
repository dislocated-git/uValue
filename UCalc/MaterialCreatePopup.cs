using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UValue;
using Component = UValue.Component;

namespace UCalc
{
    public partial class MaterialCreatePopup : Form
    {
        public MaterialCreatePopup()
        {
            InitializeComponent();
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }

            this.Activate();
        }



        private void TopControlPanel_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Component.ComponentType> materialTypes = new List<Component.ComponentType>();
            bool valid = true;
            string errorMsg = "";
            if (!String.IsNullOrWhiteSpace(materialName.Text))
            {
                
                if (wallButton.Checked)
                {
                    materialTypes.Add(Component.ComponentType.wall);
                }
                if (floorButton.Checked)
                {
                    materialTypes.Add(Component.ComponentType.floor);
                }
                if (!wallButton.Checked && !floorButton.Checked)
                {
                    valid = false;
                    errorMsg = "No type selected.";
                    // Some sort of error label should appear - no type selected
                }
            }
            else
            {
                valid = false;
                errorMsg = "Invalid name.";
            }

            if (valid)
            {
                Material newMaterial = new Material(materialName.Text,(double)thermalConductivityInput.Value, materialTypes);
                Storage.AddMaterial(newMaterial);
                Close();
            }
            else
            {
                errorlabel.Text = errorMsg;
                // Set error label to errormessage
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
