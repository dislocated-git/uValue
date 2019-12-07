using System;
using System.Drawing;
using System.Windows.Forms;

namespace UCalc
{
    public partial class MainWindow : Form
    {
        public const int cGrip = 26;      // Grip size
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

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
            base.WndProc(ref m);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private bool dragging;
        private int dragMouseX;
        private int dragMouseY;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragMouseX = Cursor.Position.X - this.Left;
            dragMouseY = Cursor.Position.Y - this.Top;

        }

        private void TopControlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Left = Cursor.Position.X - dragMouseX;
                this.Top = Cursor.Position.Y - dragMouseY;
            }
        }

        private void TopControlPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
