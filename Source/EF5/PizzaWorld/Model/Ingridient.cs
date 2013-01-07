using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF5.PizzaWorld.Model
{
    public class Ingridient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Pizza> Pizzas { get; set; }
    }
}
