using System;
using System.Collections.Generic;
using System.Text;

namespace PDCObjects {
	public class InsuranceDepartment : Department {
		public float MinSigningPrice { get; private set; }

		public InsuranceDepartment(string name , float minSigningPrice) : base(name) {
			MinSigningPrice = minSigningPrice;
		}

		public void setSigningPrice(float minSigningPrice) {
			MinSigningPrice = minSigningPrice;
		}
	}
}
