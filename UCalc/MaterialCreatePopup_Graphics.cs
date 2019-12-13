using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCalc
{
    partial class MaterialCreatePopup : Form
    {
        // The code here is blackmagic that I require to make things look a bit better.

        private bool dragging;
        private int dragMouseX;
        private int dragMouseY;

        // Allows dragging of a form without a windows border
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragMouseX = Cursor.Position.X - this.Left;
            dragMouseY = Cursor.Position.Y - this.Top;
        }
        private void TopControlPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void TopControlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Left = Cursor.Position.X - dragMouseX;
                this.Top = Cursor.Position.Y - dragMouseY;
            }
        }

        // Value for CS_DROPSHADOW class style. Enables the drop shadow effect on a window.
        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                //Overrides creation parameters of the form with altered ClassStyles value.
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }
    }
}
