namespace UCalc.Controls.UserControls
{
    partial class LayersList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // listLayoutPanel
            // 
            this.listLayoutPanel.AutoSize = true;
            this.listLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.listLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.listLayoutPanel.Name = "listLayoutPanel";
            this.listLayoutPanel.Size = new System.Drawing.Size(164, 419);
            this.listLayoutPanel.TabIndex = 0;
            this.listLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.listLayoutPanel_Paint);
            // 
            // LayersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Controls.Add(this.listLayoutPanel);
            this.Name = "LayersList";
            this.Size = new System.Drawing.Size(164, 419);
            this.Load += new System.EventHandler(this.LayersList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel listLayoutPanel;
    }
}
