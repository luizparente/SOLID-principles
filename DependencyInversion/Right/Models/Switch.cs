namespace DependencyInversion.Right.Models {
	public class Switch {
		private ILightBulb _light;

		public Switch(ILightBulb lamp) {
			this._light = lamp;
		}

		public void Flip() {
			this._light.IsOn = !this._light.IsOn;
		}

		public interface ILightBulb {
			public bool IsOn { get; set; }
		}
	}
}
