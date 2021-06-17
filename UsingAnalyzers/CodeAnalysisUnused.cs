using System;

namespace UsingAnalyzers
{
	// You should see a number of "IDE" issues, like
	// "Remove unused private member" - https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0051
	public sealed class CodeAnalysisUnused
	{
		private Guid used;
		private int x;

		public void Go(Guid used, string x) =>
			this.used = used;
	}
}