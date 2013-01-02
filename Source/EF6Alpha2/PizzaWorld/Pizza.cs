using System;
using System.Collections.Generic;

namespace EF6Alpha2.PizzaWorld
{
	public class Pizza
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public virtual ICollection<Ingridient> Ingredients { get; set; }
	}
}