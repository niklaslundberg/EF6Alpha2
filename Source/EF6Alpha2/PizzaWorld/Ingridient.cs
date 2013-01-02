using System;
using System.Collections.Generic;

namespace EF6Alpha2.PizzaWorld
{
	public class Ingridient
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public virtual ICollection<Pizza> Pizzas { get; set; }
	}
}