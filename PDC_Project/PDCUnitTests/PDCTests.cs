using System;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PDCObjects;

namespace PDCUnitTests {
	[TestClass]
	public class PDCTests {
		[TestMethod]
		public void SortParcelsTest() {
			// Arrange
			Container container = new Container();
			Parcel parcelLight = new Parcel(1f, 10f, container);
			Parcel parcelMedium = new Parcel(2.5f, 9000f, container);
			Parcel parcelHeavy = new Parcel(4f, 10000f, container);
			Parcel[] parcels = { parcelLight, parcelMedium, parcelHeavy };

			Department[] departments = {
				new ProcessingDepartment("",2, false),
				new ProcessingDepartment("",3, false),
				new ProcessingDepartment("",3, true),
				new InsuranceDepartment("", 5000f)};

			// Act
			departments.SortParcels(parcels);

			// Assert
			Assert.AreEqual(parcelLight, departments[0].Parcels[0], "First parcel not sorted correctly");
			Assert.AreEqual(parcelMedium, departments[3].Parcels[0], "Second parcel not sorted correctly");
			Assert.AreEqual(parcelHeavy, departments[3].Parcels[1], "Third parcel not sorted correctly");
		}

		[TestMethod]
		public void CheckOutInsuranceTest() {
			// Arrange
			Container container = new Container();
			Parcel parcelLight = new Parcel(1f, 10f, container);
			Parcel parcelMedium = new Parcel(2.5f, 9000f, container);
			Parcel parcelHeavy = new Parcel(4f, 10000f, container);
			Parcel[] parcels = { parcelLight, parcelMedium, parcelHeavy };

			Department[] departments = {
				new ProcessingDepartment("",2, false),
				new ProcessingDepartment("",3, false),
				new ProcessingDepartment("",3, true),
				new InsuranceDepartment("", 5000f)};

			// Act
			departments.SortParcels(parcels);

			try {
				departments[3].Parcels[0].SignOffInsurance();
				departments[3].Parcels[1].SignOffInsurance();
				departments.SortParcels(parcels);
			}
			catch (Exception i) {
				// Assert
				StringAssert.Contains(i.Message, "Sorting went wrong");
				return;
			}
			
			// Assert
			Assert.AreEqual(parcelLight, departments[0].Parcels[0], "First parcel not sorted correctly");
			Assert.AreEqual(parcelMedium, departments[1].Parcels[0], "Second parcel not sorted correctly");
			Assert.AreEqual(parcelHeavy, departments[2].Parcels[0], "Third parcel not sorted correctly");
		}

		[TestMethod]
		public void TransferParcelToAnotherDepartment() {
			// Arrange
			Parcel parcelLight = new Parcel();
			ProcessingDepartment dep1 = new ProcessingDepartment("", 2, false);
			ProcessingDepartment dep2 = new ProcessingDepartment("", 2, false);

			// Act
			dep1.AddParcel(parcelLight);
			
			dep2.TransferOut(parcelLight, dep1); //Should not transfer anything
			dep1.TransferOut(parcelLight, dep2);

			// Assert
			Assert.AreEqual(0, dep1.Parcels.Count, "Transfer to Dep1 went wrong");
			Assert.AreEqual(1, dep2.Parcels.Count, "Transfer to Dep2 went wrong");
		}

		[TestMethod]
		public void ResortAfterDepartmentRemoval() {
			// Arrange
			Container container = new Container();
			Parcel parcelLight = new Parcel(1f, 10f, container);
			Parcel parcelMedium = new Parcel(2.5f, 10f, container);
			Parcel parcelHeavy = new Parcel(4f, 10f, container);
			Parcel[] parcels = { parcelLight, parcelMedium, parcelHeavy };

			Department[] departments = {
				new ProcessingDepartment("",2, false),
				new ProcessingDepartment("",3, false),
				new ProcessingDepartment("",3, true),
				new InsuranceDepartment("", 500f) };

			// Act
			departments.SortParcels(parcels);
			Department[] newDeps = departments.RemoveProcessingDepartmentAndResort(1);

			// Assert
			Assert.AreEqual(1, newDeps[0].Parcels.Count, "No parcels in Dep1");
			Assert.AreEqual(2, newDeps[1].Parcels.Count, "Transfer to Dep2 went wrong");
		}

		[TestMethod]
		public void SortProcessingDepartmentsByAcending() {
			ProcessingDepartment[] departments = {
				new ProcessingDepartment("",8, false),
				new ProcessingDepartment("",1, false),
				new ProcessingDepartment("",5, false),
				new ProcessingDepartment("",20, false),
				new ProcessingDepartment("",18, false),
				new ProcessingDepartment("",20, true) };

			// Act
			ProcessingDepartment[] newPDp =  departments.SortProcessingDepartmentsAscending();

			// Assert
			Assert.AreEqual(1, newPDp[0].WeightClass, "Sort went wrong on row 1");
			Assert.AreEqual(5, newPDp[1].WeightClass, "Sort went wrong on row 2");
			Assert.AreEqual(8, newPDp[2].WeightClass, "Sort went wrong on row 3");
			Assert.AreEqual(18, newPDp[3].WeightClass, "Sort went wrong on row 4");
			Assert.AreEqual(20, newPDp[4].WeightClass, "Sort went wrong on row 5");
			Assert.AreEqual(true, newPDp[5].SortsHigherWeights, "Sort went wrong on row 6");
		}
	}
}
