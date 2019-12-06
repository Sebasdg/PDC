using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDCObjects;
using System.Xml;

 
namespace PDCInterface {
	public partial class MainScreen : Form {
		public static MainScreen Singleton;

		private const string FileText = "File location: ";
		private const string WeightLowSepText = " <";
		private const string WeightHighSepText = " >";
		private const string WeightText = " kg";
		public Department SelectedDp { get; private set; }

		public MainScreen() {
			InitializeComponent();
			Singleton = this;
		}

		private void MainScreen_Load(object sender, EventArgs e) {
			UpdateDepartmentButtons();
		}

		private void AddContainerXML_Click(object sender, EventArgs e) {

			BrowseForXmlFile(out XmlDocument xmlDoc);

			if (xmlDoc == null) {
				return;
			}

			ObjectInstances.containers = XMLParser.XMLToContainers(xmlDoc);

			for (int i = 0; i < ObjectInstances.containers.Length; i++) {
				ObjectInstances.departments.SortParcels(ObjectInstances.containers[i].Parcels);
			}

			RefreshListItems();
		}

		private void SettingsButton_Click(object sender, EventArgs e) {
			SettingsButton.Enabled = false;
			new SettingsScreen().ShowDialog();
		}

		public void UpdateDepartmentButtons() {
			DisposeDepartmentButtons();
			GenerateDepartmentButtons();
			RefreshListItems();
		}

		private void BrowseForXmlFile(out XmlDocument foundDoc) {
			openFileDialog1.ShowDialog();
			string filename = openFileDialog1.FileName;
			FileLocationLabel.Text = FileText + filename;
			try {
				XMLParser.LoadXML(filename, out foundDoc);
			}
			catch {
				FileLocationLabel.Text = FileText;
				foundDoc = null;
			}
		}

		private void GenerateDepartmentButtons() {
			List<DepartmentPanel> parcelPanels = new List<DepartmentPanel>();

			for (int i = 0; i < ObjectInstances.departments.Length; i++) {
				DepartmentPanel parcelPanel = new DepartmentPanel(i, this);
				string text = ObjectInstances.departments[i].Name;

				if (ObjectInstances.departments[i] is ProcessingDepartment) {
					ProcessingDepartment PD = (ProcessingDepartment)ObjectInstances.departments[i];
					if (PD.SortsHigherWeights) {
						text += WeightHighSepText + PD.WeightClass + WeightText;
					}
					else {
						text += WeightLowSepText + PD.WeightClass + WeightText;
					}
				}

				parcelPanel.Departmentbutton.Text = text;

				parcelPanels.Add(parcelPanel);
			}
			DepartmentLayoutPanel.Controls.AddRange(parcelPanels.ToArray());
		}

		private void DisposeDepartmentButtons() {
			if (DepartmentLayoutPanel.Controls.Count != 0) {
				List<Control> controls = new List<Control>();
				foreach (Control c in DepartmentLayoutPanel.Controls) {
					controls.Add(c);
				}
				DepartmentLayoutPanel.Controls.Clear();
				foreach (Control c in controls) {
					c.Dispose();
				}
			}
		}

		public void UpdateListItems(Department dep) {
			SelectedDp = dep;
			DisposeOfParcelControls();

			List<ParcelPanel> parcelPanels = new List<ParcelPanel>();

			if (dep != null && dep.Parcels != null) {
				for (int i = 0; i < dep.Parcels.Count; i++) {
					ParcelPanel panel = new ParcelPanel(dep.Parcels[i], this);
					panel.SetContainerValues(
						dep.Parcels[i].Container.Id,
						dep.Parcels[i].Container.ShippingDate);
					parcelPanels.Add(panel);
				}
			}

			ParcelLayoutPanel.Controls.AddRange(parcelPanels.ToArray());
		}

		private void DisposeOfParcelControls() {
			if (ParcelLayoutPanel.Controls.Count != 0) {
				List<Control> controls = new List<Control>();
				foreach (Control c in ParcelLayoutPanel.Controls) {
					controls.Add(c);
				}
				ParcelLayoutPanel.Controls.Clear();
				foreach (Control c in controls) {
					c.Dispose();
				}
			}
		}

		public void RefreshListItems() {
			for (int i = 0; i < ObjectInstances.departments.Length; i++) {
				ObjectInstances.departments[i].ClearParcels();
			}

			if (ObjectInstances.containers != null) {
				for (int i = 0; i < ObjectInstances.containers.Length; i++) {
					ObjectInstances.departments.SortParcels(ObjectInstances.containers[i].Parcels);
				}
			}

			if(SelectedDp != null)
				UpdateListItems(SelectedDp);
			else
				UpdateListItems(ObjectInstances.departments[0]);
		}
	}
}