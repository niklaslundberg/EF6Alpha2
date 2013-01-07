using System.Data.Entity;
using EF5.PizzaWorld;
using EF5.PizzaWorld.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF5.Tests
{
    [TestFixture]
    public class IntegrationTests
    {

        [Test]
        public void Should_add_pizza()
        {

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PizzaContext, Migrations.Configuration>());

            int count;
            using (var ctx = new PizzaContext())
            {
                count = ctx.Pizzas.Count();
                ctx.Pizzas.Add(new Pizza() { Name = "Test" });
                ctx.SaveChanges();
            }

            using (var ctx = new PizzaContext())
            {
                Assert.AreEqual(ctx.Pizzas.Count(), count + 1);
            }
        }
    }
}
