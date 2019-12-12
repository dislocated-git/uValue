using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCalc
{
    partial class MainWindow : Form
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

        // Allows to have an invisible scrollbar

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

        private enum ScrollBarDirection
        {
            SB_HORZ = 0,
            SB_VERT = 1,
            SB_CTL = 2,
            SB_BOTH = 3
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

        //Temporary solution to resizing
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            ShowScrollBar(ListLayoutPanel.Handle, (int)ScrollBarDirection.SB_BOTH, false);

            base.WndProc(ref m);
        }
    }
}
