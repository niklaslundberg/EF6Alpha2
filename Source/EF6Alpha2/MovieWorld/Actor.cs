using System;
using System.Collections.Generic;

namespace EF6Alpha2.MovieWorld
{
	public class Actor
	{
		public Guid ActorId { get; set; }
		public string Name { get; set; }

		public virtual ICollection<Movie> Movies { get; set; }
	}
}