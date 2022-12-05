namespace DependencyInversion {
	class Program {
		static void Main(string[] args) {
			/*
			 
			A. HIGH LEVEL MODULES SHOULD NOT DEPEND UPON LOW
			LEVEL MODULES. BOTH SHOULD DEPEND UPON ABSTRACTIONS.

			B. ABSTRACTIONS SHOULD NOT DEPEND UPON DETAILS. DETAILS
			SHOULD DEPEND UPON ABSTRACTIONS.

			The goal is to create a clear separation between core functionality
			and implementation details. As a positive side-effect, type coupling is
			minimized, while unit testing potential is maximized.

			For example, the business logic layer of a system should not have a
			dependency on the repository layer. In other words, the database nuances
			implemented at repository level should not impact how the business logic
			is defined. Instead, data persistence should be treated as a mere detail.


			Note:

			This example is purely illustrative, and is not a design pattern recommendation.

			It uses static classes to encapsulate related functionality. While functional, 
			this is not a design pattern that can be applied effectively in all cases. 
			
			The recommended approach is always with interfaces and Dependency Injection.
						 
			*/
		}
	}
}
