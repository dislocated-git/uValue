namespace UCalc.Controls.UserControls
{
    partial class ComponentCreationDialog
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
            this.componentNameLabel = new System.Windows.Forms.Label();
            this.componentNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // componentNameLabel
            // 
            this.componentNameLabel.AutoSize = true;
            this.componentNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentNameLabel.ForeColor = System.Drawing.Color.Silver;
            this.componentNameLabel.Location = new System.Drawing.Point(32, 73);
            this.componentNameLabel.Name = "componentNameLabel";
            this.componentNameLabel.Size = new System.Drawing.Size(52, 19);
            this.componentNameLabel.TabIndex = 0;
            this.componentNameLabel.Text = "Name";
            // 
            // componentNameBox
            // 
            this.componentNameBox.Location = new System.Drawing.Point(36, 95);
            this.componentNameBox.Name = "componentNameBox";
            this.componentNameBox.Size = new System.Drawing.Size(194, 20);
            this.componentNameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "New component";
            // 
            // listBox1
            // 
            this.listBox1.Items.AddRange(new object[] {
            "YEs",
            "No",
            "big yes",
            "big no"});
            this.listBox1.Location = new System.Drawing.Point(38, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(34, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // ComponentCreationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.componentNameBox);
            this.Controls.Add(this.componentNameLabel);
            this.Name = "ComponentCreationDialog";
            this.Size = new System.Drawing.Size(850, 730);
            this.Load += new System.EventHandler(this.ComponentCreationDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label componentNameLabel;
        private System.Windows.Forms.TextBox componentNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
    }
}
