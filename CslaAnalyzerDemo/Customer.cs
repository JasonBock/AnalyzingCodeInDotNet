using Csla;
using System;

namespace CslaAnalyzerDemo
{
	// This class definition gives
	// CSLA0001 - "CSLA business objects must be serializable"
	// https://github.com/MarimerLLC/csla/blob/main/docs/analyzers/CSLA0001-IsBusinessObjectSerializableAnalyzer.md
	public sealed class Customer
		: BusinessBase<Customer>
	{
		public Customer(Guid id) => this.Id = id;

		public static readonly PropertyInfo<Guid> IdProperty =
			Customer.RegisterProperty<Guid>(_ => _.Id);
		public Guid Id
		{
			// This property definition gives
			// CSLA0007 - "Properties that use managed backing fields should only use Get/Set/Read/Load methods and nothing else"
			// https://github.com/MarimerLLC/csla/blob/main/docs/analyzers/CSLA0007-EvaluatePropertiesForSimplicityAnalyzer.md
			get
			{ 
				var x = this.ReadProperty(Customer.IdProperty); 
				return x; 
			}
			set => this.LoadProperty(Customer.IdProperty, value);
		}
	}
}