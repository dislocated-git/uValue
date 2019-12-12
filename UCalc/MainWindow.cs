using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UCalc.Controls.UserControls;

namespace UCalc
{
    public partial class MainWindow : Form
    {
        public const int cGrip = 26;      // Grip size

        private ComponentEntry activeComponent = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ComponentEntry componentEntry = new ComponentEntry();
            ListLayoutPanel.Controls.Add(componentEntry);

        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            ListLayoutPanel.Visible = true;
            ListLayoutPanel.VerticalScroll.Visible = false;
            ListLayoutPanel.HorizontalScroll.Maximum = 0;
            ListLayoutPanel.AutoScroll = false;
            ListLayoutPanel.VerticalScroll.Visible = false;
            ListLayoutPanel.AutoScroll = true;
            ListLayoutPanel.VerticalScroll.Visible = false;

            ComponentEntry componentEntry = e.Control as ComponentEntry;

            componentEntry.Selected += ComponentEntry_SelectedChanged;


            dynamicPanel.Controls.Add(new ComponentCreationDialog());
        }

        private void ComponentEntry_SelectedChanged(object sender, EventArgs e)
        {
            if (activeComponent != null)
            {
                
            }
        }


    }
}
