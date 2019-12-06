using System;
using System.Collections.Generic;

namespace PDCObjects {
	public class Company : LegalEntity {
		public int CcNumber { get; private set; }

		public void SetValues(string name, int ccNumber) {
			base.SetValues(name);
			CcNumber = ccNumber;
		}
	}
}
