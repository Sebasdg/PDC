namespace PDCInterface {
	partial class DepartmentSettingPanel {
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
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.WeightNumericBox = new System.Windows.Forms.NumericUpDown();
			this.MaxWeighttextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.WeightNumericBox)).BeginInit();
			this.SuspendLayout();
			// 
			// NameTextBox
			// 
			this.NameTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameTextBox.ForeColor = System.Drawing.SystemColors.Window;
			this.NameTextBox.Location = new System.Drawing.Point(7, 3);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(174, 30);
			this.NameTextBox.TabIndex = 1;
			this.NameTextBox.Text = "DepartmentName";
			this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
			// 
			// RemoveButton
			// 
			this.RemoveButton.Location = new System.Drawing.Point(287, 5);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(60, 27);
			this.RemoveButton.TabIndex = 3;
			this.RemoveButton.Text = "Remove";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// WeightNumericBox
			// 
			this.WeightNumericBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.WeightNumericBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.WeightNumericBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WeightNumericBox.ForeColor = System.Drawing.SystemColors.Window;
			this.WeightNumericBox.Location = new System.Drawing.Point(202, 5);
			this.WeightNumericBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.WeightNumericBox.Name = "WeightNumericBox";
			this.WeightNumericBox.Size = new System.Drawing.Size(72, 26);
			this.WeightNumericBox.TabIndex = 4;
			this.WeightNumericBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.WeightNumericBox.ValueChanged += new System.EventHandler(this.WeightNumericBox_ValueChanged);
			// 
			// MaxWeighttextBox
			// 
			this.MaxWeighttextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.MaxWeighttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MaxWeighttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaxWeighttextBox.ForeColor = System.Drawing.SystemColors.Window;
			this.MaxWeighttextBox.Location = new System.Drawing.Point(202, 4);
			this.MaxWeighttextBox.Name = "MaxWeighttextBox";
			this.MaxWeighttextBox.Size = new System.Drawing.Size(72, 30);
			this.MaxWeighttextBox.TabIndex = 5;
			this.MaxWeighttextBox.Text = "10>";
			// 
			// DepartmentSettingPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Controls.Add(this.MaxWeighttextBox);
			this.Controls.Add(this.WeightNumericBox);
			this.Controls.Add(this.RemoveButton);
			this.Controls.Add(this.NameTextBox);
			this.Name = "DepartmentSettingPanel";
			this.Size = new System.Drawing.Size(350, 35);
			this.Load += new System.EventHandler(this.DepartmentSetting_Load);
			((System.ComponentModel.ISupportInitialize)(this.WeightNumericBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.NumericUpDown WeightNumericBox;
		private System.Windows.Forms.TextBox MaxWeighttextBox;
	}
}
