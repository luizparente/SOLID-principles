namespace DependencyInversion.Wrong.Models {
	public class Switch {
		private LightBulb _light;

		public Switch() {
			this._light = new LightBulb();
		}

		public void Flip() {
			this._light.IsOn = !this._light.IsOn;
		}
	}
}
