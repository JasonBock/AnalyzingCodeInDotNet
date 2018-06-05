using Csla;
using System;

namespace CslaAnalyzerDemo
{
	[Serializable]
	public sealed class Customer
		: BusinessBase<Customer>
	{
		public static readonly PropertyInfo<Guid> IdProperty =
			Customer.RegisterProperty<Guid>(_ => _.Id);
		public Guid Id
		{
			//get => this.ReadProperty(Customer.IdProperty);
			get { var x = this.ReadProperty(Customer.IdProperty); return x; }
			set => this.LoadProperty(Customer.IdProperty, value);
		}
	}
}