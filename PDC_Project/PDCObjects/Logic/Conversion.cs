using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;

namespace PDCObjects {
	public static class Conversion {
		const string Ss = " ";
		const string Ds = "-";
		const string Ts = ":";

		public static string ShortenDate(this DateTimeOffset date) {
			string shortDate = date.ToUniversalTime().Year + Ds +
			date.ToUniversalTime().Month.ToString("D2") + Ds +
			date.ToUniversalTime().Day.ToString("D2") + Ss +
			date.ToUniversalTime().Hour.ToString("D2") + Ts +
			date.ToUniversalTime().Minute.ToString("D2");

			return shortDate;
		}

		public static bool ContainsInsuranceDepartment(this Department[] departments) {
			for (int i = 0; i < departments.Length; i++) {
				if (departments[i] is InsuranceDepartment) {
					return true;
				}
			}
			return false;
		}

		public static InsuranceDepartment GetInsuranceDepartment(this Department[] departments) {
			bool InsurDepExists = departments.ContainsInsuranceDepartment();

			for (int i = 0; i < departments.Length; i++) {
				if (InsurDepExists && departments[i] is InsuranceDepartment) {
					return (InsuranceDepartment)departments[i];
				}
			}

			return null;
		}

		public static ProcessingDepartment HighestWeightProcessingDepartment(this Department[] departments) {
			ProcessingDepartment[] foundDeps = departments.GetProcessingDepartments();
			return foundDeps.HighestWeightProcessingDepartment();
		}

		public static ProcessingDepartment HighestWeightProcessingDepartment(this ProcessingDepartment[] departments) {
			ProcessingDepartment foundDep = null;
			for (int i = 0; i < departments.Length; i++) {
				if (departments[i].SortsHigherWeights) {
					foundDep = departments[i];
				}
			}
			return foundDep;
		}

		public static ProcessingDepartment[] GetProcessingDepartments(this Department[] departments) {
			List<ProcessingDepartment> foundDeps = new List<ProcessingDepartment>();
			for (int i = 0; i < departments.Length; i++) {
				if (departments[i] is ProcessingDepartment) {
					foundDeps.Add((ProcessingDepartment)departments[i]);
				}
			}

			return foundDeps.ToArray();
		}

		public static ProcessingDepartment[] SortProcessingDepartmentsAscending(this ProcessingDepartment[] departments) {
			List<ProcessingDepartment> newProcDeps = new List<ProcessingDepartment>();

			for (int i = 0; i < departments.Length; i++) {
				newProcDeps.Add(departments[i]);
			}

			Dictionary<ProcessingDepartment, int> nameWeight = new Dictionary<ProcessingDepartment, int>();

			for (int i = 0; i < newProcDeps.Count; i++) {
				nameWeight.Add(newProcDeps[i], newProcDeps[i].WeightClass);
			}

			//remove highest department sorter from list temporarily
			ProcessingDepartment maxDep = newProcDeps.ToArray().HighestWeightProcessingDepartment();
			newProcDeps.Remove(maxDep);

			//reorder
			newProcDeps = newProcDeps.OrderBy(x => nameWeight[x]).ToList();

			//add highest department sorter to the list again and set new highest weight
			if (newProcDeps.Count != 0) {
				maxDep.SetWeight(newProcDeps[newProcDeps.Count - 1].WeightClass);
			}
			else {
				maxDep.SetWeight(0);
			}

			newProcDeps.Add(maxDep);

			return newProcDeps.ToArray();
		}

		public static Department[] RemoveProcessingDepartmentAndResort(this Department[] departments, int arrayRowNr) {
			if (departments[arrayRowNr] == null) {
				Debug.WriteLine("Department not found");
				return null;
			}

			if (departments[arrayRowNr] is InsuranceDepartment) {
				Debug.WriteLine("Can't remove insurance department");
				return null;
			}

			if (departments[arrayRowNr] is ProcessingDepartment) {
				ProcessingDepartment pDp = (ProcessingDepartment)departments[arrayRowNr];
				if (pDp.SortsHigherWeights) {
					Debug.WriteLine("Can't remove max processing department");
					return null;
				}

				List<Department> deps = departments.ToList();
				Parcel[] ResortParcels = departments[arrayRowNr].Parcels.ToArray();
				int removedWeightClass = pDp.WeightClass;

				deps.RemoveAt(arrayRowNr);

				bool updateMaxWeights = false;

				if (arrayRowNr < deps.Count - 1) {
					if (deps[arrayRowNr] is ProcessingDepartment) {
						ProcessingDepartment NewPDp = (ProcessingDepartment)deps[arrayRowNr];
						if (NewPDp.SortsHigherWeights) {
							updateMaxWeights = true;
						}
					}
					else if(deps[arrayRowNr + 1] is ProcessingDepartment) {
						ProcessingDepartment NewPDp = (ProcessingDepartment)deps[arrayRowNr + 1];
						if (NewPDp.SortsHigherWeights) {
							updateMaxWeights = true;
						}
					}
				}


				if (updateMaxWeights) {
					ProcessingDepartment NewPDp = deps.ToArray().HighestWeightProcessingDepartment();
					InsuranceDepartment NewIDp = deps.ToArray().GetInsuranceDepartment();

					if (arrayRowNr > 0) {
						ProcessingDepartment lowerPDp = (ProcessingDepartment)deps[arrayRowNr - 1];
						NewPDp.SetWeight(lowerPDp.WeightClass);
					}
					else {
						NewPDp.SetWeight(0);
					}

					deps.Remove(NewPDp);
					deps.Remove(NewIDp);

					deps.Add(NewPDp);
					deps.Add(NewIDp);
				}

				deps.ToArray().SortParcels(ResortParcels);
				return deps.ToArray();
			}
			else {
				Debug.WriteLine("Something went wrong?");
				return null;
			}
		}
	}
}
