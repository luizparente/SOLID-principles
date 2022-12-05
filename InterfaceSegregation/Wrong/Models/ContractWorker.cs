namespace InterfaceSegregation.Wrong.Models {
	public class ContractWorker : IWorker {
		public double HourlyRate { get; set; }
		public double Salary { 
			get => throw new System.NotImplementedException(); 
			set => throw new System.NotImplementedException(); 
		}
	}
}
