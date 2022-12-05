namespace InterfaceSegregation.Right.Models {
	class PermanentWorker : Worker, IPermanentWorker {
		public double Salary { get; set; }
	}
}
