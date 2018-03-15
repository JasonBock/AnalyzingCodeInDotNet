using System;

namespace UsingAnalyzers
{
	public sealed class Unused
	{
		private Guid notUsed;
		private Guid used;

		public void Go(Guid used, string neverUsed)
		{
			var x = 2;
			this.used = used;
		}
	}
}
