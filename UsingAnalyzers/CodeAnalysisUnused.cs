using System;

namespace UsingAnalyzers
{
	public sealed class CodeAnalysisUnused
	{
		private Guid used;
		// Uncommenting this will give CA1823.
		//private int x;

		// Adding x will give CA1801
		public void Go(Guid used/*, string x */) =>
			this.used = used;
	}
}
