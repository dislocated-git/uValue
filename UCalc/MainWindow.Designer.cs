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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TopControlPanel = new System.Windows.Forms.Panel();
            this.UCalc_TopNameLabel = new System.Windows.Forms.Label();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.componentListPanel = new System.Windows.Forms.Panel();
            this.ListLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.TopControlPanel.SuspendLayout();
            this.MainMenuPanel.SuspendLayout();
            this.componentListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.TopControlPanel.Size = new System.Drawing.Size(1180, 30);
            this.TopControlPanel.TabIndex = 0;
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
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.MainMenuPanel.Controls.Add(this.button1);
            this.MainMenuPanel.Controls.Add(this.optionsButton);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 30);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(74, 730);
            this.MainMenuPanel.TabIndex = 0;
            // 
            // componentListPanel
            // 
            this.componentListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.componentListPanel.Controls.Add(this.ListLayoutPanel);
            this.componentListPanel.Controls.Add(this.label2);
            this.componentListPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.componentListPanel.Location = new System.Drawing.Point(74, 30);
            this.componentListPanel.Name = "componentListPanel";
            this.componentListPanel.Size = new System.Drawing.Size(256, 730);
            this.componentListPanel.TabIndex = 0;
            // 
            // ListLayoutPanel
            // 
            this.ListLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ListLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ListLayoutPanel.Name = "ListLayoutPanel";
            this.ListLayoutPanel.Size = new System.Drawing.Size(256, 731);
            this.ListLayoutPanel.TabIndex = 0;
            this.ListLayoutPanel.Visible = false;
            this.ListLayoutPanel.WrapContents = false;
            this.ListLayoutPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.ListLayoutPanel_ControlAdded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(475, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "           You haven\'t selected any component.\r\nEither that or I have done someth" +
    "ing horribly wrong.";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(330, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 730);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(45, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "There appears to be \r\nno components in this\r\nproject. Create some!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UCalc.Properties.Resources.dog8;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(511, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 269);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::UCalc.Properties.Resources.icons8_plus_50;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(21, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 37);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // optionsButton
            // 
            this.optionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.optionsButton.BackgroundImage = global::UCalc.Properties.Resources.icons8_settings_50;
            this.optionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.optionsButton.FlatAppearance.BorderSize = 0;
            this.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsButton.ForeColor = System.Drawing.Color.Transparent;
            this.optionsButton.Location = new System.Drawing.Point(21, 681);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(34, 37);
            this.optionsButton.TabIndex = 2;
            this.optionsButton.TabStop = false;
            this.optionsButton.UseMnemonic = false;
            this.optionsButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::UCalc.Properties.Resources.icons8_delete_50;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(1152, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.UseMnemonic = false;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1180, 760);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.componentListPanel);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.TopControlPanel);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1180, 760);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.TopControlPanel.ResumeLayout(false);
            this.TopControlPanel.PerformLayout();
            this.MainMenuPanel.ResumeLayout(false);
            this.componentListPanel.ResumeLayout(false);
            this.componentListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopControlPanel;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Label UCalc_TopNameLabel;
        private System.Windows.Forms.Panel componentListPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.FlowLayoutPanel ListLayoutPanel;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

