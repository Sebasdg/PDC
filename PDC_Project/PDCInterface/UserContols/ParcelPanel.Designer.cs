namespace PDCInterface {
	partial class ParcelPanel {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.ContainerNumberLabel = new System.Windows.Forms.Label();
			this.ParcelTitleLabel = new System.Windows.Forms.Label();
			this.DateLabel = new System.Windows.Forms.Label();
			this.ValueLabel = new System.Windows.Forms.Label();
			this.WeightLabel = new System.Windows.Forms.Label();
			this.ButtonInsuranceSignOff = new System.Windows.Forms.Button();
			this.ReceipientPanel = new PDCInterface.LegalEntityPanel();
			this.SenderPanel = new PDCInterface.LegalEntityPanel();
			this.SuspendLayout();
			// 
			// ContainerNumberLabel
			// 
			this.ContainerNumberLabel.AutoSize = true;
			this.ContainerNumberLabel.Location = new System.Drawing.Point(17, 65);
			this.ContainerNumberLabel.Name = "ContainerNumberLabel";
			this.ContainerNumberLabel.Size = new System.Drawing.Size(114, 13);
			this.ContainerNumberLabel.TabIndex = 15;
			this.ContainerNumberLabel.Text = "Container: ########";
			// 
			// ParcelTitleLabel
			// 
			this.ParcelTitleLabel.AutoSize = true;
			this.ParcelTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ParcelTitleLabel.Location = new System.Drawing.Point(17, 16);
			this.ParcelTitleLabel.Name = "ParcelTitleLabel";
			this.ParcelTitleLabel.Size = new System.Drawing.Size(54, 17);
			this.ParcelTitleLabel.TabIndex = 14;
			this.ParcelTitleLabel.Text = "Parcel";
			// 
			// DateLabel
			// 
			this.DateLabel.AutoSize = true;
			this.DateLabel.Location = new System.Drawing.Point(17, 78);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(132, 13);
			this.DateLabel.TabIndex = 16;
			this.DateLabel.Text = "Date: ####-##-## ##:##";
			// 
			// ValueLabel
			// 
			this.ValueLabel.AutoSize = true;
			this.ValueLabel.Location = new System.Drawing.Point(17, 52);
			this.ValueLabel.Name = "ValueLabel";
			this.ValueLabel.Size = new System.Drawing.Size(44, 13);
			this.ValueLabel.TabIndex = 19;
			this.ValueLabel.Text = "#### €";
			// 
			// WeightLabel
			// 
			this.WeightLabel.AutoSize = true;
			this.WeightLabel.Location = new System.Drawing.Point(17, 39);
			this.WeightLabel.Name = "WeightLabel";
			this.WeightLabel.Size = new System.Drawing.Size(50, 13);
			this.WeightLabel.TabIndex = 18;
			this.WeightLabel.Text = "#### kg";
			// 
			// ButtonInsuranceSignOff
			// 
			this.ButtonInsuranceSignOff.Location = new System.Drawing.Point(558, 3);
			this.ButtonInsuranceSignOff.Name = "ButtonInsuranceSignOff";
			this.ButtonInsuranceSignOff.Size = new System.Drawing.Size(89, 104);
			this.ButtonInsuranceSignOff.TabIndex = 20;
			this.ButtonInsuranceSignOff.Text = "Sign off insurance";
			this.ButtonInsuranceSignOff.UseVisualStyleBackColor = true;
			this.ButtonInsuranceSignOff.Visible = false;
			// 
			// ReceipientPanel
			// 
			this.ReceipientPanel.Location = new System.Drawing.Point(377, 0);
			this.ReceipientPanel.MinimumSize = new System.Drawing.Size(175, 110);
			this.ReceipientPanel.Name = "ReceipientPanel";
			this.ReceipientPanel.Size = new System.Drawing.Size(175, 110);
			this.ReceipientPanel.TabIndex = 17;
			this.ReceipientPanel.Load += new System.EventHandler(this.ReceipientPanel_Load);
			// 
			// SenderPanel
			// 
			this.SenderPanel.Location = new System.Drawing.Point(196, 0);
			this.SenderPanel.MinimumSize = new System.Drawing.Size(175, 110);
			this.SenderPanel.Name = "SenderPanel";
			this.SenderPanel.Size = new System.Drawing.Size(175, 110);
			this.SenderPanel.TabIndex = 0;
			this.SenderPanel.Load += new System.EventHandler(this.SenderPanel_Load);
			// 
			// ParcelPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.ButtonInsuranceSignOff);
			this.Controls.Add(this.ValueLabel);
			this.Controls.Add(this.WeightLabel);
			this.Controls.Add(this.ReceipientPanel);
			this.Controls.Add(this.DateLabel);
			this.Controls.Add(this.ContainerNumberLabel);
			this.Controls.Add(this.ParcelTitleLabel);
			this.Controls.Add(this.SenderPanel);
			this.MaximumSize = new System.Drawing.Size(2000, 110);
			this.MinimumSize = new System.Drawing.Size(540, 110);
			this.Name = "ParcelPanel";
			this.Size = new System.Drawing.Size(650, 110);
			this.Load += new System.EventHandler(this.ParcelPanel_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private LegalEntityPanel SenderPanel;
		private LegalEntityPanel ReceipientPanel;
		private System.Windows.Forms.Label ContainerNumberLabel;
		private System.Windows.Forms.Label ParcelTitleLabel;
		private System.Windows.Forms.Label DateLabel;
		private System.Windows.Forms.Label ValueLabel;
		private System.Windows.Forms.Label WeightLabel;
		private System.Windows.Forms.Button ButtonInsuranceSignOff;
	}
}
