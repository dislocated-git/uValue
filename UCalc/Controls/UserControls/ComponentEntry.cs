using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UValue;
namespace UCalc.Controls.UserControls
{
    public partial class ComponentEntry : UserControl
    {
        public bool Active { get; set; }

        public Component Component { get; set; }

        public event EventHandler Selected;

        protected virtual void OnSelected()
        {
            Selected?.Invoke(this, EventArgs.Empty);
        }

        public ComponentEntry()
        {
            InitializeComponent();
        }

        private void ComponentEntry_Load(object sender, EventArgs e)
        {
        }

        private void ClickedOn(object sender, EventArgs e)
        {
            if (!Active)
            {
                OnSelected();
            }
        }
    }
}
