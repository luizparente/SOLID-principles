namespace InterfaceSegregation.Wrong.Models {
	public class PermanentWorker : IWorker {
		public double HourlyRate { 
			get => throw new System.NotImplementedException(); 
			set => throw new System.NotImplementedException(); 
		}
		public double Salary { get; set; }
	}
}
