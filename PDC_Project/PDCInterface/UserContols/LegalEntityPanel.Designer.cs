namespace PDCInterface {
	partial class LegalEntityPanel {
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
			this.CcNumberLabel = new System.Windows.Forms.Label();
			this.PostalCodeLabel = new System.Windows.Forms.Label();
			this.StreetLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.EntityTypeLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CcNumberLabel
			// 
			this.CcNumberLabel.AutoSize = true;
			this.CcNumberLabel.Location = new System.Drawing.Point(14, 74);
			this.CcNumberLabel.Name = "CcNumberLabel";
			this.CcNumberLabel.Size = new System.Drawing.Size(58, 13);
			this.CcNumberLabel.TabIndex = 17;
			this.CcNumberLabel.Text = "Cc number";
			// 
			// PostalCodeLabel
			// 
			this.PostalCodeLabel.AutoSize = true;
			this.PostalCodeLabel.Location = new System.Drawing.Point(31, 61);
			this.PostalCodeLabel.Name = "PostalCodeLabel";
			this.PostalCodeLabel.Size = new System.Drawing.Size(109, 13);
			this.PostalCodeLabel.TabIndex = 15;
			this.PostalCodeLabel.Text = "Postalcode City name";
			// 
			// StreetLabel
			// 
			this.StreetLabel.AutoSize = true;
			this.StreetLabel.Location = new System.Drawing.Point(31, 48);
			this.StreetLabel.Name = "StreetLabel";
			this.StreetLabel.Size = new System.Drawing.Size(64, 13);
			this.StreetLabel.TabIndex = 14;
			this.StreetLabel.Text = "Street name";
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(14, 35);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(35, 13);
			this.NameLabel.TabIndex = 13;
			this.NameLabel.Text = "Name";
			// 
			// EntityTypeLabel
			// 
			this.EntityTypeLabel.AutoSize = true;
			this.EntityTypeLabel.Location = new System.Drawing.Point(14, 13);
			this.EntityTypeLabel.Name = "EntityTypeLabel";
			this.EntityTypeLabel.Size = new System.Drawing.Size(57, 13);
			this.EntityTypeLabel.TabIndex = 12;
			this.EntityTypeLabel.Text = "EntityType";
			// 
			// LegalEntityPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.CcNumberLabel);
			this.Controls.Add(this.PostalCodeLabel);
			this.Controls.Add(this.StreetLabel);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.EntityTypeLabel);
			this.MinimumSize = new System.Drawing.Size(175, 110);
			this.Name = "LegalEntityPanel";
			this.Size = new System.Drawing.Size(175, 110);
			this.Load += new System.EventHandler(this.LegalEntityPanel_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label CcNumberLabel;
		public System.Windows.Forms.Label PostalCodeLabel;
		public System.Windows.Forms.Label NameLabel;
		public System.Windows.Forms.Label EntityTypeLabel;
		private System.Windows.Forms.Label StreetLabel;
	}
}
