namespace UCalc.Controls.UserControls
{
    partial class ComponentEntry
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
            this.componentName = new System.Windows.Forms.Label();
            this.layersTitle = new System.Windows.Forms.Label();
            this.layersCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // componentName
            // 
            this.componentName.AutoSize = true;
            this.componentName.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.componentName.Location = new System.Drawing.Point(13, 19);
            this.componentName.Name = "componentName";
            this.componentName.Size = new System.Drawing.Size(175, 23);
            this.componentName.TabIndex = 0;
            this.componentName.Text = "Sample Component";
            this.componentName.Click += new System.EventHandler(this.ClickedOn);
            // 
            // layersTitle
            // 
            this.layersTitle.AutoSize = true;
            this.layersTitle.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layersTitle.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.layersTitle.Location = new System.Drawing.Point(159, 48);
            this.layersTitle.Name = "layersTitle";
            this.layersTitle.Size = new System.Drawing.Size(51, 16);
            this.layersTitle.TabIndex = 1;
            this.layersTitle.Text = "Layers:";
            this.layersTitle.Click += new System.EventHandler(this.ClickedOn);
            // 
            // layersCount
            // 
            this.layersCount.AutoSize = true;
            this.layersCount.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layersCount.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.layersCount.Location = new System.Drawing.Point(216, 48);
            this.layersCount.Name = "layersCount";
            this.layersCount.Size = new System.Drawing.Size(15, 16);
            this.layersCount.TabIndex = 2;
            this.layersCount.Text = "0";
            this.layersCount.Click += new System.EventHandler(this.ClickedOn);
            // 
            // ComponentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Controls.Add(this.layersCount);
            this.Controls.Add(this.layersTitle);
            this.Controls.Add(this.componentName);
            this.Name = "ComponentEntry";
            this.Size = new System.Drawing.Size(256, 77);
            this.Load += new System.EventHandler(this.ComponentEntry_Load);
            this.Click += new System.EventHandler(this.ClickedOn);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label componentName;
        private System.Windows.Forms.Label layersTitle;
        private System.Windows.Forms.Label layersCount;
    }
}
