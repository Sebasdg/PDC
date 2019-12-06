using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDCObjects;

namespace PDCInterface {
	public static class ObjectInstances {
		public static Container[] containers;
		public static Department[] departments;

		public static void CreateBaseDepartments() {
			List<Department> newDepartments = new List<Department>();
			newDepartments.Add(new ProcessingDepartment("Mail", 1, false));
			newDepartments.Add(new ProcessingDepartment("Regular", 10, false));
			newDepartments.Add(new ProcessingDepartment("Heavy", 10, true));
			newDepartments.Add(new InsuranceDepartment("Insurance", 1000f));

			departments = newDepartments.ToArray();
		}
	}
}
