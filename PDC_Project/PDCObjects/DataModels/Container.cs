using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDCObjects {
	public class Container {

		public int Id { get; private set; }
		public DateTimeOffset ShippingDate { get; private set; }
		public Parcel[] Parcels { get; private set; }

		public void SetContainerInfo(int id, DateTimeOffset shippingDate) {
			Id = id;
			ShippingDate = shippingDate;
		}

		public void SetParcels(Parcel[] parcels) {
			Parcels = parcels;
		}
	}
}
