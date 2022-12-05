using OpenClosed.Wrong.Models;
using System;

namespace OpenClosed.Wrong {
	public static class AreaCalculator {
		public static double CalculateArea(object shape) {
			double area;

			if (shape is Circle)
				area = Math.PI * Math.Pow(((Circle)shape).Radius, 2);
			else if (shape is Square)
				area = Math.Pow(((Square)shape).Side, 2);
			else
				throw new Exception("Unknown shape.");

			return area;
		}
	}
}
