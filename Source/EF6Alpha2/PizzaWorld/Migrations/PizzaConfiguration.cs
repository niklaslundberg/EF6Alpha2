using System.Data.Entity.Migrations;

namespace EF6Alpha2.PizzaWorld.Migrations
{
	internal sealed class PizzaConfiguration : DbMigrationsConfiguration<PizzaContext>
	{
		public PizzaConfiguration()
		{
			AutomaticMigrationsEnabled = true;
			MigrationsDirectory = @"PizzaWorld\Migrations";
		}

		protected override void Seed(PizzaContext context)
		{
		}
	}
}