namespace UCalc
{
    partial class MaterialCreatePopup
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label componentNameLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.errorlabel = new System.Windows.Forms.Label();
            this.TopControlPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.MaterialsLabel = new System.Windows.Forms.Label();
            this.materialName = new System.Windows.Forms.TextBox();
            this.wallButton = new System.Windows.Forms.RadioButton();
            this.floorButton = new System.Windows.Forms.RadioButton();
            this.thermalConductivityInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            componentNameLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.TopControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thermalConductivityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // componentNameLabel
            // 
            componentNameLabel.AutoSize = true;
            componentNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            componentNameLabel.ForeColor = System.Drawing.Color.Silver;
            componentNameLabel.Location = new System.Drawing.Point(13, 113);
            componentNameLabel.Name = "componentNameLabel";
            componentNameLabel.Size = new System.Drawing.Size(52, 19);
            componentNameLabel.TabIndex = 14;
            componentNameLabel.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Silver;
            label2.Location = new System.Drawing.Point(13, 177);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 19);
            label2.TabIndex = 16;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.Silver;
            label3.Location = new System.Drawing.Point(13, 287);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(240, 19);
            label3.TabIndex = 19;
            label3.Text = "Thermal Conductivity ( λ-value )";
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorlabel.ForeColor = System.Drawing.Color.Silver;
            this.errorlabel.Location = new System.Drawing.Point(13, 408);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(0, 18);
            this.errorlabel.TabIndex = 23;
            // 
            // TopControlPanel
            // 
            this.TopControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.TopControlPanel.Controls.Add(this.closeButton);
            this.TopControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopControlPanel.Location = new System.Drawing.Point(0, 0);
            this.TopControlPanel.Name = "TopControlPanel";
            this.TopControlPanel.Size = new System.Drawing.Size(284, 30);
            this.TopControlPanel.TabIndex = 0;
            this.TopControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopControlPanel.MouseHover += new System.EventHandler(this.TopControlPanel_MouseHover);
            this.TopControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopControlPanel_MouseMove);
            this.TopControlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopControlPanel_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::UCalc.Properties.Resources.icons8_delete_50;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(256, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 30);
            this.closeButton.TabIndex = 24;
            this.closeButton.TabStop = false;
            this.closeButton.UseMnemonic = false;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MaterialsLabel
            // 
            this.MaterialsLabel.AutoSize = true;
            this.MaterialsLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight", 18F);
            this.MaterialsLabel.ForeColor = System.Drawing.Color.Silver;
            this.MaterialsLabel.Location = new System.Drawing.Point(12, 45);
            this.MaterialsLabel.Name = "MaterialsLabel";
            this.MaterialsLabel.Size = new System.Drawing.Size(159, 29);
            this.MaterialsLabel.TabIndex = 13;
            this.MaterialsLabel.Text = "New material";
            // 
            // materialName
            // 
            this.materialName.Location = new System.Drawing.Point(17, 135);
            this.materialName.Name = "materialName";
            this.materialName.Size = new System.Drawing.Size(165, 20);
            this.materialName.TabIndex = 15;
            // 
            // wallButton
            // 
            this.wallButton.AutoSize = true;
            this.wallButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.wallButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.wallButton.Location = new System.Drawing.Point(17, 213);
            this.wallButton.Name = "wallButton";
            this.wallButton.Size = new System.Drawing.Size(53, 21);
            this.wallButton.TabIndex = 17;
            this.wallButton.TabStop = true;
            this.wallButton.Text = "Wall";
            this.wallButton.UseVisualStyleBackColor = true;
            // 
            // floorButton
            // 
            this.floorButton.AutoSize = true;
            this.floorButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.floorButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.floorButton.Location = new System.Drawing.Point(17, 250);
            this.floorButton.Name = "floorButton";
            this.floorButton.Size = new System.Drawing.Size(60, 21);
            this.floorButton.TabIndex = 18;
            this.floorButton.TabStop = true;
            this.floorButton.Text = "Floor";
            this.floorButton.UseVisualStyleBackColor = true;
            // 
            // thermalConductivityInput
            // 
            this.thermalConductivityInput.DecimalPlaces = 4;
            this.thermalConductivityInput.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.thermalConductivityInput.Location = new System.Drawing.Point(17, 321);
            this.thermalConductivityInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.thermalConductivityInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.thermalConductivityInput.Name = "thermalConductivityInput";
            this.thermalConductivityInput.Size = new System.Drawing.Size(70, 25);
            this.thermalConductivityInput.TabIndex = 20;
            this.thermalConductivityInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(93, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "W / (K * m)";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.createButton.ForeColor = System.Drawing.Color.Black;
            this.createButton.Location = new System.Drawing.Point(194, 408);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(78, 30);
            this.createButton.TabIndex = 22;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaterialCreatePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(284, 450);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.thermalConductivityInput);
            this.Controls.Add(label3);
            this.Controls.Add(this.floorButton);
            this.Controls.Add(this.wallButton);
            this.Controls.Add(label2);
            this.Controls.Add(this.materialName);
            this.Controls.Add(componentNameLabel);
            this.Controls.Add(this.MaterialsLabel);
            this.Controls.Add(this.TopControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaterialCreatePopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaterialCreatePopup";
            this.TopControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thermalConductivityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopControlPanel;
        private System.Windows.Forms.Label MaterialsLabel;
        private System.Windows.Forms.TextBox materialName;
        private System.Windows.Forms.RadioButton wallButton;
        private System.Windows.Forms.RadioButton floorButton;
        private System.Windows.Forms.NumericUpDown thermalConductivityInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.Button closeButton;
    }
}