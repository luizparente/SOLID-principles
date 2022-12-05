namespace DependencyInversion.Right.Models {
	public class IncandescentBulb : Switch.ILightBulb {
		public bool IsOn { get; set; }
	}
}
