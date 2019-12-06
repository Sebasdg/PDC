using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDCObjects {
	public class Address {
		public string Street { get; private set; }
		public int HouseNumber { get; private set; }
		public string HouseNumberExtension { get; private set; }
		public string PostalCode { get; private set; }
		public string City { get; private set; }

		public void SetValues(string street, int houseNumber, string houseNumberExtension, string postalCode, string city) {
			Street = street;
			HouseNumber = houseNumber;
			HouseNumberExtension = houseNumberExtension;
			PostalCode = postalCode;
			City = city;
		}

		public void SetValues(string street, int houseNumber, string postalCode, string city) {
			Street = street;
			HouseNumber = houseNumber;
			HouseNumberExtension = string.Empty;
			PostalCode = postalCode;
			City = city;
		}
	}
}
