using System;

namespace OpenClosed.Right.Models {
	public class Circle : Shape {
		public double Radius { get; set; }
		// ...

		public override double GetArea() {
			return Math.PI * Math.Pow(this.Radius, 2);
		}
	}
}
