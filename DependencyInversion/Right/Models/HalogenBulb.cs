namespace DependencyInversion.Right.Models {
	public class HalogenBulb : Switch.ILightBulb {
		public bool IsOn { get; set; }
	}
}
