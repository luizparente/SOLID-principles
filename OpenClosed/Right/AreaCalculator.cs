using OpenClosed.Right.Models;

namespace OpenClosed.Right {
	public static class AreaCalculator {
		public static double CalculateArea(Shape shape) {
			return shape.GetArea();
		}
	}
}
