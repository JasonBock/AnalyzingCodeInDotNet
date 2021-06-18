using System;

namespace UsingAnalyzers
{
	public static class UseDisposableObject
	{
		public static string GetName(Guid id)
		{
			// You'd THINK this would raise CA2000 - "Dispose objects before losing scope"
			// https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2000
			//
			// But...it's not. It looks like CA2000 has been disabled, see:
			// https://github.com/dotnet/roslyn-analyzers/issues/4915
			// https://github.com/dotnet/roslyn-analyzers/pull/4862
			var service = new CustomerService();
			var customer = service.Get(id);
			return customer.Name;
		}
	}

	public sealed class CustomerService
		: IDisposable
	{
		public Customer Get(Guid id)
		{
			if(id == Guid.Empty)
			{
				throw new ArgumentException("Wrong", nameof(id));
			}

			return new(id, "Name");
		}

#pragma warning disable S1186 // Methods should not be empty
		public void Dispose() { }
#pragma warning restore S1186 // Methods should not be empty
	}

	public record Customer(Guid Id, string Name);
}