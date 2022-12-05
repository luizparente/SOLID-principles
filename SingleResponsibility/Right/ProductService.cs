using SingleResponsibility.Models;
using System;

namespace SingleResponsibility.Right {
	public static class ProductService {
		public static void CreateProduct(Product product) {
			Logger.Log("Creating product.");

			try {
				ProductRepository.Create(product);
			}
			catch (Exception e) {
				Logger.Log(e.Message);
			}
		}
	}
}
