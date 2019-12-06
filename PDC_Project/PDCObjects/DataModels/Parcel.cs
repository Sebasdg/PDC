using System;
using System.Collections.Generic;

namespace PDCObjects {
	public class Parcel {
		public Container Container { get; private set; }
		public LegalEntity Sender { get; private set; }
		public LegalEntity Recipient { get; private set; }
		public float Weight { get; private set; }
		public float Value { get; private set; }
		protected private bool InsuranceSignedOff = false;

		public Parcel(float weight, float value, Container container) {
			Container = container;
			Weight = weight;
			Value = value;
		}

		public Parcel() {
		}

		public void SetLegalEntities(LegalEntity sender, LegalEntity recipient) {
			Sender = sender;
			Recipient = recipient;
		}

		public void SetValues(float weight, float value, Container container) {
			Container = container;
			Weight = weight;
			Value = value;
		}

		public bool IsSignedOff() {
			return InsuranceSignedOff;
		}

		public void SignOffInsurance() {
			InsuranceSignedOff = true;
		}
	}
}
