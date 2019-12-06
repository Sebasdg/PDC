namespace PDCInterface {
	partial class DepartmentPanel {
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
			this.Departmentbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Departmentbutton
			// 
			this.Departmentbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Departmentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.Departmentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Departmentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Departmentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Departmentbutton.ForeColor = System.Drawing.SystemColors.Control;
			this.Departmentbutton.Location = new System.Drawing.Point(0, 0);
			this.Departmentbutton.Name = "Departmentbutton";
			this.Departmentbutton.Size = new System.Drawing.Size(150, 30);
			this.Departmentbutton.TabIndex = 0;
			this.Departmentbutton.Text = "DepartmentName";
			this.Departmentbutton.UseVisualStyleBackColor = false;
			this.Departmentbutton.Click += new System.EventHandler(this.Departmentbutton_Click);
			// 
			// DepartmentPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Departmentbutton);
			this.Name = "DepartmentPanel";
			this.Size = new System.Drawing.Size(150, 30);
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Button Departmentbutton;
	}
}
