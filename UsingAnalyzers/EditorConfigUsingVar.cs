namespace UsingAnalyzers
{
	public static class EditorConfigUsingVar
	{
		public static int UseVar(int x)
		{
			var y = x * 2;
			return y;
		}

		public static int UseType(int x)
		{
			// IDE0007 - use 'var' instead of explicit type
			// https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0007-ide0008
			// 
			// This is set to an error in the .editorconfig
			int y = x * 2;
			return y;
		}
	}
}