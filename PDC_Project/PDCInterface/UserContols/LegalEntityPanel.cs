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
	public partial class LegalEntityPanel : UserControl {

		const string SenderText = "Sender";
		const string ReceipientText = "Receipient";

		const string CcText = "Cc: ";
		const string St = " ";

		public LegalEntityPanel() {
			InitializeComponent();
		}

		private void LegalEntityPanel_Load(object sender, EventArgs e) {

		}

		public void SetValues(bool isSender, LegalEntity legalEntity) {

			if (isSender) {
				EntityTypeLabel.Text = SenderText;
			}
			else {
				EntityTypeLabel.Text = ReceipientText;
			}

			Address Address = legalEntity.Address;

			NameLabel.Text = legalEntity.Name;
			StreetLabel.Text =
				Address.Street + St +
				Address.HouseNumber + St + 
				Address.HouseNumberExtension;
			PostalCodeLabel.Text = Address.PostalCode + St + Address.City;

			if (legalEntity is Company) {
				Company newLegalEntity = (Company)legalEntity;
				if (newLegalEntity.CcNumber != 0) {
					CcNumberLabel.Text = CcText + newLegalEntity.CcNumber;
				}
				else {
					CcNumberLabel.Text = string.Empty;
				}
			}
			else {
				CcNumberLabel.Text = string.Empty;
			}
		}
	}
}
