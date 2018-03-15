using System;

namespace UsingAnalyzers
{
	public sealed class DisposableItem : IDisposable
	{
		public void Dispose() { }
		public void Execute() { }
	}
}
