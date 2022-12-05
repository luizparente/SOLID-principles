using SingleResponsibility.Models;
using System;
using System.Data.SqlClient;
using System.IO;

namespace SingleResponsibility.Wrong {
	public static class ProductService {
		public static void CreateProduct(Product product) {
			string logFile = "path/to/log.txt";

			File.AppendAllText(logFile, "Creating new product entry.");
			File.AppendAllText(logFile, "Opening connection with database.");

			try {
				using (SqlConnection connection = new SqlConnection()) {
					connection.ConnectionString = "...";

					File.AppendAllText(logFile, "Running insert query.");

					SqlCommand command = new SqlCommand("INSERT INTO...", connection);
				}
			}
			catch (Exception e) {
				File.AppendAllText(logFile, e.Message);
			}

			File.AppendAllText(logFile, "Success.");

			// ...
		}
	}
}
