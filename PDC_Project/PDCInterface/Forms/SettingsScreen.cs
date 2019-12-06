using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDCObjects;

namespace PDCInterface {
	public partial class SettingsScreen : Form {
		public List<DepartmentSettingPanel> DSPanels = new List<DepartmentSettingPanel>();
		public List<Department> temporaryDepartments = new List<Department>();

		public SettingsScreen() {
			InitializeComponent();
		}

		private void SettingsScreen_Load(object sender, EventArgs e) {
			temporaryDepartments = ObjectInstances.departments.ToList();
			RefreshList();
		}

		private void CloseScreen(object sender, FormClosedEventArgs e) {
			MainScreen.Singleton.SettingsButton.Enabled = true;
			this.Dispose();
		}

		private void SaveButton_Click(object sender, EventArgs e) {
			ReOrderList();
			RefreshList();
			ObjectInstances.departments = temporaryDepartments.ToArray();

			MainScreen.Singleton.UpdateDepartmentButtons();
		}

		private void RefreshList() {
			ClearList();
			GenerateNewPanels();

			SettingsFlowLayoutPanel.Controls.AddRange(DSPanels.ToArray());
		}

		private void GenerateNewPanels() {
			for (int i = 0; i < temporaryDepartments.Count; i++) {
				DepartmentSettingPanel panel = null;
				if (temporaryDepartments[i] is ProcessingDepartment) {
					ProcessingDepartment pDp = (ProcessingDepartment)temporaryDepartments[i];

					//Keep the higher sorter set the same
					if (pDp.SortsHigherWeights) {
						panel = new DepartmentSettingPanel(
										pDp, this, DepartmentSettingPanel.SettingPanelType.highestProcessingDp);
					}
					else {
						panel = new DepartmentSettingPanel(
										pDp, this, DepartmentSettingPanel.SettingPanelType.ProcessingDp);
					}
				}

				//Set the insurance panel
				if (temporaryDepartments[i] is InsuranceDepartment) {
					InsuranceDepartment iDp = (InsuranceDepartment)temporaryDepartments[i];
					panel = new DepartmentSettingPanel(
									iDp, this, DepartmentSettingPanel.SettingPanelType.InsuranceDp);
				}
				DSPanels.Add(panel);
			}
		}

		private void ReOrderList() {
			List<ProcessingDepartment> newProcDeps = new List<ProcessingDepartment>();
			List<InsuranceDepartment> newInsurDeps = new List<InsuranceDepartment>();

			for (int i = 0; i < temporaryDepartments.Count; i++) {
				if (temporaryDepartments[i] is ProcessingDepartment) {
					newProcDeps.Add((ProcessingDepartment)temporaryDepartments[i]);
				}
				else {
					newInsurDeps.Add((InsuranceDepartment)temporaryDepartments[i]);
				}
			}

			List<Department> newDeps = new List<Department>();
			newDeps.AddRange(newProcDeps.ToArray().SortProcessingDepartmentsAscending());
			newDeps.AddRange(newInsurDeps);
			temporaryDepartments = newDeps;
		}

		private void ClearList() {
			for (int i = 0; i < DSPanels.Count; i++) {
				DSPanels[i].Dispose();
			}
			DSPanels.Clear();
		}

		private void NewDepButton_Click(object sender, EventArgs e) {
			List<Department> deps = new List<Department>();
			deps.AddRange(temporaryDepartments);

			ProcessingDepartment pDp = new ProcessingDepartment("New department", 1, false);
			deps.Add(pDp);

			temporaryDepartments = deps;

			ReOrderList();
			RefreshList();
		}
	}
}
