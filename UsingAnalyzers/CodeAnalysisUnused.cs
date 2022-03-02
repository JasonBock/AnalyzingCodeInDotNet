using System;

namespace UsingAnalyzers;

// You should see a number of "IDE" issues, like
// IDE0051 - "Private member 'CodeAnalysisUnused.x' is unused"
// https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0051
// IDE0052 - "Private member 'CodeAnalysisUnused.used' can be removed as the value assigned to it is never read"
// https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0051
//
// But this is also "duplicated" with 
// CS0619 - "The field 'CodeAnalysisUnused.x' is never used"
// https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0169
public sealed class CodeAnalysisUnused
{
	private Guid used;
	private int x;

	public CodeAnalysisUnused(Guid used, string y) =>
		this.used = used;
}