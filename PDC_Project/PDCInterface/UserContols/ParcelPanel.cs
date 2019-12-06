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
	public partial class ParcelPanel : UserControl {
		const string ContainerText = "Container:";
		const string DateText = "Date: ";
		const string DateUTCText = " UTC";
		const string WeightText = " kg";
		const string ValueText = " €";
		const string InsurenceSignedText = " Insurance signed off";

		private MainScreen mainScreen;

		public ParcelPanel(Parcel parcel, MainScreen mainScreen) {
			InitializeComponent();
			SetValues(parcel);
			SenderPanel.SetValues(true, parcel.Sender);
			ReceipientPanel.SetValues(false, parcel.Recipient);
			this.mainScreen = mainScreen;
		}

		public void SetContainerValues(int containerNumber, DateTimeOffset date) {
			ContainerNumberLabel.Text = ContainerText + containerNumber;
			DateLabel.Text = DateText + date.ShortenDate() + DateUTCText;
		}

		private void SetValues(Parcel parcel) {
			WeightLabel.Text = parcel.Weight + WeightText;
			ValueLabel.Text = parcel.Value + ValueText;
			InsuranceDepartment iDp = ObjectInstances.departments.GetInsuranceDepartment();
			if (parcel.Value > iDp.MinSigningPrice) {
				bool signButtonOn = !parcel.IsSignedOff();
				if (signButtonOn) {
					ButtonInsuranceSignOff.Visible = signButtonOn;
					ButtonInsuranceSignOff.Click +=
						delegate (object sender, EventArgs e) {
							parcel.SignOffInsurance();
							mainScreen.RefreshListItems();
						};
				}
				else {
					ValueLabel.Text += InsurenceSignedText;
				}
			}
		}

		private void ParcelPanel_Load(object sender, EventArgs e) {

		}

		private void ReceipientPanel_Load(object sender, EventArgs e) {

		}

		//private void ButtonInsuranceSignOff(Parcel parcel) {
			
		//	mainScreen.RefreshListItems();
		//}

		private void SenderPanel_Load(object sender, EventArgs e) {

		}
	}
}
