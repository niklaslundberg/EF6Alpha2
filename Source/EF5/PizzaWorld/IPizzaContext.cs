using System.Data.Entity;
using EF5.PizzaWorld.Model;

namespace EF5.PizzaWorld
{
    public interface IPizzaContext
    {
        IDbSet<Pizza> Pizzas { get; set; }
        IDbSet<Ingridient> Ingridients { get; set; }
        int SaveChanges();
    }
}