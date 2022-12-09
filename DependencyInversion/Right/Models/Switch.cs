namespace DependencyInversion.Right.Models {
	public class Switch {
		private ILightBulb _light;

		public Switch(ILightBulb lamp) {
			this._light = lamp;
		}

		public void Flip() {
			this._light.IsOn = !this._light.IsOn;
		}

		// A custom type should always be declared in its own file.
		// In this case, ILightBulb is declared here on purpose,
		// to convey the idea that the Switch owns the responsibility
		// of defining the specs of the things on which it has a dependency.
		// For example, if a service has a dependency on a respository, then
		// the service must define that repository's specs, usually, via an interface. 
		public interface ILightBulb {
			public bool IsOn { get; set; }
		}
	}
}
