namespace UsingAnalyzers;

public static class SonarAnalysisGenericMethods
{
	// This gives:
	// S1186 - "Methods should not be empty" - https://rules.sonarsource.com/csharp/RSPEC-1186
	// S2326 - "Unused type parameters should not be used" - https://rules.sonarsource.com/csharp/RSPEC-2326
	public static void MyMethod<T>() { }
}