using System.Collections.Generic;
using System.Linq;

namespace UsingAnalyzers
{
	public static class UseLinqCount
	{
		// This is interesting.
		// CA1829 will fire - "Use Length/Count property instead of Enumerable.Count method"
		// https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1829
		// However, its default severity is "Suggestion".
		//
		// When you include SonarAnalyzer.CSharp, it'll show 
		// S2971 - https://rules.sonarsource.com/csharp/RSPEC-2971
		// https://rules.sonarsource.com/csharp/RSPEC-2971
		// 
		// But the code fix comes from CA1289!
		public static int GetNameCount => UseLinqCount.GetNames().Count();

		private static List<string> GetNames() => new() { "Joe", "Jane" };
	}
}