using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF5.PizzaWorld.Model;

namespace EF5.PizzaWorld
{
    public class PizzaContext : DbContext, IPizzaContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Ingridient>().Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
        
        public IDbSet<Pizza> Pizzas { get; set; }
        public IDbSet<Ingridient> Ingridients { get; set; }


    }
}
