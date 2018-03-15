namespace UsingAnalyzers
{
	public sealed class DisposableIssues
	{
		public void Go()
		{
			using (var item = new DisposableItem())
			{
				item.Execute();
			}
		}
	}
}
