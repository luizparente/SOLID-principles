namespace LiskovSubstitution.Wrong.Models {
	public class Ostrich : Eagle {
		// ...

		public new void Fly() {
			throw new System.Exception("Ostriches don't fly.");
		}
	}
}
