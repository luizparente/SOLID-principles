using System;

namespace OpenClosed.Right.Models {
	public class Square : Shape {
		public double Side { get; set; }
		// ...

		public override double GetArea() {
			return Math.Pow(this.Side, 2);
		}
	}
}
