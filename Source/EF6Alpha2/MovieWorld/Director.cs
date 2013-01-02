using System;
using System.Collections.Generic;

namespace EF6Alpha2.MovieWorld
{
	public class Director
	{
		public ICollection<Movie> Movies { get; set; }

		public Guid DirectorId { get; set; }

		public string Name { get; set; }
	}
}