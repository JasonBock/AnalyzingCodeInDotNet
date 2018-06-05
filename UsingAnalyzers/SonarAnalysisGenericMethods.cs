namespace UsingAnalyzers
{
	public static class SonarAnalysisGenericMethods
	{
		// Uncommenting this gives S4018
		public static void MyMethod<T>() { }
	}
}
