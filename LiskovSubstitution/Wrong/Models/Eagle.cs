namespace LiskovSubstitution.Wrong.Models {
	public class Eagle {
		public string BirdID { get; set; }
		public string Name { get; set; }
		public double Weight { get; set; }
		// ...

		public void Fly() { 
			// Flying logic here.
		}
	}
}
