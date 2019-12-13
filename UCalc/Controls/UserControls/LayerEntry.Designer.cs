namespace UCalc
{
    partial class LayerEntry
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
            this.layerName = new System.Windows.Forms.Label();
            this.layerThickness = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // layerName
            // 
            this.layerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.layerName.AutoSize = true;
            this.layerName.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.layerName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.layerName.Location = new System.Drawing.Point(14, 15);
            this.layerName.Name = "layerName";
            this.layerName.Size = new System.Drawing.Size(87, 19);
            this.layerName.TabIndex = 1;
            this.layerName.Text = "New Layer";
            // 
            // layerThickness
            // 
            this.layerThickness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.layerThickness.AutoSize = true;
            this.layerThickness.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.layerThickness.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.layerThickness.Location = new System.Drawing.Point(116, 15);
            this.layerThickness.Name = "layerThickness";
            this.layerThickness.Size = new System.Drawing.Size(16, 18);
            this.layerThickness.TabIndex = 3;
            this.layerThickness.Text = "0";
            // 
            // LayerEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.layerThickness);
            this.Controls.Add(this.layerName);
            this.Name = "LayerEntry";
            this.Size = new System.Drawing.Size(190, 50);
            this.Load += new System.EventHandler(this.LayerEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label layerName;
        private System.Windows.Forms.Label layerThickness;
    }
}
