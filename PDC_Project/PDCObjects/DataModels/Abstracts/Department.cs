using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDCObjects {
	public abstract class Department {
		public string Name { get; private set; }
		public List<Parcel> Parcels { get; private set; } = new List<Parcel>();

		public Department(string name) {
			Name = name;
		}

		public void SetParcels(List<Parcel> parcels) {
			Parcels = parcels;
		}

		public void AddParcel(Parcel parcel) {
			Parcels.Add(parcel);
		}

		public void AddParcels(Parcel[] parcels) {
			Parcels.AddRange(parcels);
		}

		public void ClearParcels() {
			Parcels.Clear();
		}

		public void ChangeName(string name) {
			Name = name;
		}

	}
}
