using System.Data.Entity;
using System.Data.Entity.Config;
using EF6Alpha2.Common;

namespace EF6Alpha2.PizzaWorld
{
	[DbConfigurationType(typeof (HappyWorldConfiguration))]
	public class PizzaContext : DbContext
	{
		public PizzaContext() : base("HappyWorld")
		{
		}

		public IDbSet<Pizza> Pizzas { get; set; }
		public IDbSet<Ingridient> Ingridients { get; set; }
	}
}