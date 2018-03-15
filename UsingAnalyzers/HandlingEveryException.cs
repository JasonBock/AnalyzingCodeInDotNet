using System;

namespace UsingAnalyzers
{
	public sealed class HandlingEveryException
	{
		public void Go(string id)
		{
			try
			{
				var value = Guid.Parse(id);
			}
			catch { }
		}
	}
}
