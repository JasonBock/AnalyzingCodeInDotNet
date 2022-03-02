namespace UsingAnalyzers;

public static class BadExceptionHandling
{
	public static int Add(int a, int b)
	{
		try
		{
			return a + b;
		}
		catch { }
		return -1;
	}
}