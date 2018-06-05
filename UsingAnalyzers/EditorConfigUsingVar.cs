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
			int y = x * 2;
			return y;
		}
	}
}
