using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace PDCObjects {
	public static class Transfer {

		public static void SortParcels(this Department[] departments, Parcel[] parcels) {
			List<Parcel> sortableParcels = parcels.ToList();

			bool InsurDepExists = departments.ContainsInsuranceDepartment();
			InsuranceDepartment inDep = null;
			if (InsurDepExists) {
				inDep = departments.GetInsuranceDepartment();
			}
			
			foreach (Parcel parcel in parcels) {
				Parcel sortedParcel = null;

				//Sort into insurance department
				if (InsurDepExists) {
					if (!parcel.IsSignedOff() && parcel.Value >= inDep.MinSigningPrice) {
						inDep.AddParcel(parcel);
						sortedParcel = parcel;
						sortableParcels.Remove(sortedParcel);
						continue;
					}
				}

				//Sort based on weight into correct departments
				for (int i = 0; i < departments.Length; i++) {
					if (departments[i] is ProcessingDepartment) {
						ProcessingDepartment pD = (ProcessingDepartment)departments[i];

						float weight = parcel.Weight;
						if (weight < pD.WeightClass) {
							pD.AddParcel(parcel);
							sortedParcel = parcel;
							sortableParcels.Remove(sortedParcel);
							break;
						}
					}
				}
			}

			ProcessingDepartment pDs = departments.GetProcessingDepartments().HighestWeightProcessingDepartment();
			pDs.AddParcels(sortableParcels.ToArray());
		}

		public static void TransferOut(this Department source, Parcel outGoingParcel, Department destination) {
			if (source.Parcels.Contains(outGoingParcel)) {
				source.Parcels.Remove(outGoingParcel);
				destination.Parcels.Add(outGoingParcel);
			}
			else {
				Debug.WriteLine("Parcel not found in source department");
			}
		}
	}
}
