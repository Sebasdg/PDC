namespace PDCInterface {
	partial class MainScreen {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.AddContainerXML = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.FileLocationLabel = new System.Windows.Forms.Label();
			this.ParcelLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.DepartmentLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.SettingsButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AddContainerXML
			// 
			this.AddContainerXML.Location = new System.Drawing.Point(12, 12);
			this.AddContainerXML.Name = "AddContainerXML";
			this.AddContainerXML.Size = new System.Drawing.Size(130, 30);
			this.AddContainerXML.TabIndex = 0;
			this.AddContainerXML.Text = "Add container XML";
			this.AddContainerXML.UseVisualStyleBackColor = true;
			this.AddContainerXML.Click += new System.EventHandler(this.AddContainerXML_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// FileLocationLabel
			// 
			this.FileLocationLabel.AutoSize = true;
			this.FileLocationLabel.Location = new System.Drawing.Point(148, 12);
			this.FileLocationLabel.Name = "FileLocationLabel";
			this.FileLocationLabel.Size = new System.Drawing.Size(66, 13);
			this.FileLocationLabel.TabIndex = 1;
			this.FileLocationLabel.Text = "File location:";
			// 
			// ParcelLayoutPanel
			// 
			this.ParcelLayoutPanel.AutoScroll = true;
			this.ParcelLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ParcelLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ParcelLayoutPanel.Location = new System.Drawing.Point(0, 146);
			this.ParcelLayoutPanel.Name = "ParcelLayoutPanel";
			this.ParcelLayoutPanel.Size = new System.Drawing.Size(675, 363);
			this.ParcelLayoutPanel.TabIndex = 2;
			// 
			// DepartmentLayoutPanel
			// 
			this.DepartmentLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DepartmentLayoutPanel.AutoScroll = true;
			this.DepartmentLayoutPanel.Location = new System.Drawing.Point(0, 84);
			this.DepartmentLayoutPanel.Name = "DepartmentLayoutPanel";
			this.DepartmentLayoutPanel.Size = new System.Drawing.Size(675, 56);
			this.DepartmentLayoutPanel.TabIndex = 3;
			this.DepartmentLayoutPanel.WrapContents = false;
			// 
			// SettingsButton
			// 
			this.SettingsButton.Location = new System.Drawing.Point(12, 48);
			this.SettingsButton.Name = "SettingsButton";
			this.SettingsButton.Size = new System.Drawing.Size(130, 30);
			this.SettingsButton.TabIndex = 4;
			this.SettingsButton.Text = "Settings";
			this.SettingsButton.UseVisualStyleBackColor = true;
			this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 509);
			this.Controls.Add(this.SettingsButton);
			this.Controls.Add(this.DepartmentLayoutPanel);
			this.Controls.Add(this.ParcelLayoutPanel);
			this.Controls.Add(this.FileLocationLabel);
			this.Controls.Add(this.AddContainerXML);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainScreen";
			this.Text = "MainScreen";
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddContainerXML;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		public System.Windows.Forms.Label FileLocationLabel;
		private System.Windows.Forms.FlowLayoutPanel ParcelLayoutPanel;
		private System.Windows.Forms.FlowLayoutPanel DepartmentLayoutPanel;
		public System.Windows.Forms.Button SettingsButton;
	}
}