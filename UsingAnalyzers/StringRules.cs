using System;

namespace UsingAnalyzers;

public static class StringRules
{
	public static bool IsTrue(string value) =>
		value?.ToLowerInvariant() == "TRUE";

	public static bool HasCharacter(string value) =>
		value?.Contains("I", StringComparison.OrdinalIgnoreCase) ?? false;
}