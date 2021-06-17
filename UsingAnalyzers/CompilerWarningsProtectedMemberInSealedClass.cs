namespace UsingAnalyzers
{
	public sealed class CompilerWarningsProtectedMemberInSealedClass
	{
		// This gives CS0628 - 'member' : new protected member declared in sealed class
		// https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0628
		// This is a warning, but if you have TreatWarningsAsErrors on, it'll show up 
		// as an error.
		protected int x;
	}
}