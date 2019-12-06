using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDCObjects;

namespace PDCInterface {
	public partial class DepartmentPanel : UserControl {
		private int departmentInArray;
		private MainScreen mainScreen;

		public DepartmentPanel(int department, MainScreen screen) {
			this.departmentInArray = department;
			mainScreen = screen;
			InitializeComponent();
		}

		private void Departmentbutton_Click(object sender, EventArgs e) {
			mainScreen.UpdateListItems(ObjectInstances.departments[departmentInArray]);
		}
	}
}
