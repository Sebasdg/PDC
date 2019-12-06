using System;
using System.Collections.Generic;

namespace PDCObjects {
	public abstract class LegalEntity {
		public string Name { get; private set; }
		public Address Address { get; private set; }

		public void SetValues(string name) {
			Name = name;
		}

		public void SetAddress(Address address) {
			Address = address;
		}
	}
}
