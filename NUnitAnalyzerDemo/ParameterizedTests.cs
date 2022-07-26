using NUnit.Framework;

namespace NUnitAnalyzerDemo;

public static class ParameterizedTests
{
	[TestCase(3, 4, 7)]
	public static void Add(int x, int y, int expectedResult) => 
		Assert.That(x + y, Is.EqualTo(expectedResult));
}