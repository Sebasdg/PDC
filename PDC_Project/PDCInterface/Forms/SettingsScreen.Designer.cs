namespace PDCInterface {
	partial class SettingsScreen {
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
			this.SaveButton = new System.Windows.Forms.Button();
			this.SettingsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.NewDepButton = new System.Windows.Forms.Button();
			this.flowLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveButton.Location = new System.Drawing.Point(263, 5);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(107, 60);
			this.SaveButton.TabIndex = 0;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// SettingsFlowLayoutPanel
			// 
			this.SettingsFlowLayoutPanel.AutoScroll = true;
			this.SettingsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SettingsFlowLayoutPanel.Location = new System.Drawing.Point(0, 107);
			this.SettingsFlowLayoutPanel.Name = "SettingsFlowLayoutPanel";
			this.SettingsFlowLayoutPanel.Size = new System.Drawing.Size(375, 263);
			this.SettingsFlowLayoutPanel.TabIndex = 1;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.flowLayoutPanel2.Controls.Add(this.label1);
			this.flowLayoutPanel2.Controls.Add(this.label2);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 71);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(367, 30);
			this.flowLayoutPanel2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Department name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(187, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 30);
			this.label2.TabIndex = 1;
			this.label2.Text = "Max weight";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NewDepButton
			// 
			this.NewDepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NewDepButton.Location = new System.Drawing.Point(3, 36);
			this.NewDepButton.Name = "NewDepButton";
			this.NewDepButton.Size = new System.Drawing.Size(248, 29);
			this.NewDepButton.TabIndex = 3;
			this.NewDepButton.Text = "New department";
			this.NewDepButton.UseVisualStyleBackColor = true;
			this.NewDepButton.Click += new System.EventHandler(this.NewDepButton_Click);
			// 
			// SettingsScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 370);
			this.Controls.Add(this.NewDepButton);
			this.Controls.Add(this.flowLayoutPanel2);
			this.Controls.Add(this.SettingsFlowLayoutPanel);
			this.Controls.Add(this.SaveButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "SettingsScreen";
			this.Text = "SettingsScreen";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseScreen);
			this.Load += new System.EventHandler(this.SettingsScreen_Load);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.FlowLayoutPanel SettingsFlowLayoutPanel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button NewDepButton;
	}
}