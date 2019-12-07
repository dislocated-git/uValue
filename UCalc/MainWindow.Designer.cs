namespace UCalc
{
    partial class MainWindow
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
            this.TopControlPanel = new System.Windows.Forms.Panel();
            this.UCalc_TopNameLabel = new System.Windows.Forms.Label();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.TopControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopControlPanel
            // 
            this.TopControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TopControlPanel.Controls.Add(this.closeButton);
            this.TopControlPanel.Controls.Add(this.UCalc_TopNameLabel);
            this.TopControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopControlPanel.Location = new System.Drawing.Point(0, 0);
            this.TopControlPanel.Name = "TopControlPanel";
            this.TopControlPanel.Size = new System.Drawing.Size(1184, 30);
            this.TopControlPanel.TabIndex = 0;
            this.TopControlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopControlPanel_Paint);
            this.TopControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopControlPanel_MouseMove);
            this.TopControlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopControlPanel_MouseUp);
            // 
            // UCalc_TopNameLabel
            // 
            this.UCalc_TopNameLabel.AutoSize = true;
            this.UCalc_TopNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCalc_TopNameLabel.ForeColor = System.Drawing.Color.Gray;
            this.UCalc_TopNameLabel.Location = new System.Drawing.Point(4, 6);
            this.UCalc_TopNameLabel.Name = "UCalc_TopNameLabel";
            this.UCalc_TopNameLabel.Size = new System.Drawing.Size(51, 19);
            this.UCalc_TopNameLabel.TabIndex = 0;
            this.UCalc_TopNameLabel.Text = "UCalc";
            this.UCalc_TopNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 30);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(80, 731);
            this.MainMenuPanel.TabIndex = 0;
            this.MainMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenuPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(80, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 731);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::UCalc.Properties.Resources.icons8_delete_50;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(1156, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.UseMnemonic = false;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.TopControlPanel);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.TopControlPanel.ResumeLayout(false);
            this.TopControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopControlPanel;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Label UCalc_TopNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
    }
}

