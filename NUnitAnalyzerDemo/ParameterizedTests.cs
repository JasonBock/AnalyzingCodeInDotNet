using NUnit.Framework;

namespace NUnitAnalyzerDemo;

internal static class ParameterizedTests
{
	[TestCase(3, 4, 7)]
	public static void Add(int x, int y, int expectedResult) => 
		Assert.That(x + y, Is.EqualTo(expectedResult));
}