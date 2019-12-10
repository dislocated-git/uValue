using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCalc.Controls.UserControls
{
    public partial class ComponentEntry : UserControl
    {
        public bool Selected = false;

            


        public ComponentEntry()
        {
            InitializeComponent();
        }

        public ComponentEntry(string name, int layerCount)
        {
            InitializeComponent();

        }

        private void ComponentEntry_Load(object sender, EventArgs e)
        {

        }

        private void ComponentEntry_Click(object sender, EventArgs e)
        {
            
        }
    }
}
