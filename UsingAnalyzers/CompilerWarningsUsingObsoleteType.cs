using System;

namespace UsingAnalyzers
{
	public static class CompilerWarningsUsingObsoleteType
	{
		public static void UseStuff() => 
			ObsoleteStuff.Go();
	}

	[Obsolete("Please don't use this.", false)]
	public static class ObsoleteStuff
	{
		public static void Go() { }
	}
}
