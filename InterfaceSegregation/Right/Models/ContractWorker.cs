namespace InterfaceSegregation.Right.Models {
	public class ContractWorker : Worker, IContractWorker {
		public double HourlyRate { get; set; }
	}
}
