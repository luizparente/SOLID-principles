namespace DependencyInversion.Right.Models {
	public class LedBulb : Switch.ILightBulb {
		public bool IsOn { get; set; }
	}
}
