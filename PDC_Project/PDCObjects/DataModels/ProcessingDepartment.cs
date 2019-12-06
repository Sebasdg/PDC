using System;
using System.Collections.Generic;
using System.Text;

namespace PDCObjects {
	public class ProcessingDepartment : Department {
		public int WeightClass { get; private set; }
		public bool SortsHigherWeights { get; private set; }

		public ProcessingDepartment(string name, int weight, bool highest) : base(name) {
			WeightClass = weight;
			SortsHigherWeights = highest;
		}

		public void SetWeight(int weight) {
			WeightClass = weight;
		}

		public void SetHighSort(bool highest) {
			SortsHigherWeights = highest;
		}
	}
}
