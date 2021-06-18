using System;

namespace UsingAnalyzers
{
	// You should see a number of "IDE" issues, like
	// IDE0055 - "Remove unused private member"
	// https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0051
	public sealed class CodeAnalysisUnused
	{
		private Guid used;
		private int x;

		public void Go(Guid used, string y) =>
			this.used = used;
	}
}