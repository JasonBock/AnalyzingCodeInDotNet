using System.Collections.Generic;

namespace UsingAnalyzers
{
	public sealed class UsingArrayForProperty
	{
		public string[] Values { get; set; }

		public IEnumerable<string> GetData()
		{
			var data = new List<string>();
			data.Add("a");
			return data;
		}
	}
}