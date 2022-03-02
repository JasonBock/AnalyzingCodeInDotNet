using System;

namespace UsingAnalyzers;

public static class CompilerWarningsUsingObsoleteType
{
	// This gives CS0618 - 'member' is obsolete: 'text
	// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0618
	// Note that the attribute sets `error` to `false`, but
	// with TreatWarningsAsErrors turned on, it will be an error.
	public static int UseStuff() => ObsoleteStuff.GetValue();
}

[Obsolete("Please don't use this.", false)]
public static class ObsoleteStuff
{
	public static int GetValue() => new Random().Next();
}