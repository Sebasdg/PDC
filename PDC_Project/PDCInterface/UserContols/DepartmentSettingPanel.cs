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
	public partial class DepartmentSettingPanel : UserControl {
		private const string ButtonOnText = "Remove";
		private const string ButtonLocked = "Locked";
		private const string WeightHighSepText = " >";
		private const string ValueText = " €";

		public Department dep { get; private set; }
		public enum SettingPanelType {
			ProcessingDp,
			highestProcessingDp,
			InsuranceDp
		}

		private SettingsScreen settingsScreen;
		private SettingPanelType panelType;
		private float depWeightClass = 0;
		private float depPriceInsuranceClass = 0;

		public DepartmentSettingPanel(Department dep, SettingsScreen settingsScreen, SettingPanelType type) {
			InitializeComponent();
			this.dep = dep;
			this.settingsScreen = settingsScreen;
			panelType = type;

			NameTextBox.Text = dep.Name;
			if (dep is ProcessingDepartment) {
				ProcessingDepartment pD = (ProcessingDepartment)dep;
				depWeightClass = pD.WeightClass;
				WeightNumericBox.Value = (decimal)depWeightClass;
			}
			else if (dep is InsuranceDepartment) {
				InsuranceDepartment iD = (InsuranceDepartment)dep;
				depPriceInsuranceClass = iD.MinSigningPrice;
				WeightNumericBox.Value = (decimal)depPriceInsuranceClass;
			}
			SetTypeChanges();
		}

		private void DepartmentSetting_Load(object sender, EventArgs e) {

		}

		private void NameTextBox_TextChanged(object sender, EventArgs e) {
			dep.ChangeName(NameTextBox.Text);
		}

		private void WeightNumericBox_ValueChanged(object sender, EventArgs e) {
			if (dep is ProcessingDepartment) {
				ProcessingDepartment pD = (ProcessingDepartment)dep;
				pD.SetWeight((int)WeightNumericBox.Value);
				dep = pD;
			}
			else if (dep is InsuranceDepartment) {
				InsuranceDepartment iD = (InsuranceDepartment)dep;
				iD.setSigningPrice((float)WeightNumericBox.Value);
				dep = iD;
			}
		}

		private void RemoveButton_Click(object sender, EventArgs e) {
			settingsScreen.DSPanels.Remove(this);
			settingsScreen.temporaryDepartments.Remove(dep);
			this.Dispose();
		}

		private void SetTypeChanges() {
			switch (panelType) {
				case SettingPanelType.ProcessingDp:
					SetBoxValues(true);
					RemoveButton.Text = ButtonOnText;
					break;
				case SettingPanelType.highestProcessingDp:
					SetBoxValues(false);
					MaxWeighttextBox.Text = depWeightClass.ToString() + WeightHighSepText;
					RemoveButton.Text = ButtonLocked;
					break;
				case SettingPanelType.InsuranceDp:
					SetBoxValues(false);
					MaxWeighttextBox.Text = depPriceInsuranceClass + ValueText;
					RemoveButton.Text = ButtonLocked;
					break;
				default:
					break;
			}
		}

		private void SetBoxValues(bool isOn) {
			WeightNumericBox.Visible = isOn;
			MaxWeighttextBox.Visible = !isOn;
			RemoveButton.Enabled = isOn;
		}
	}
}
