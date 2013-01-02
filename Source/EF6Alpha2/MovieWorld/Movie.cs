using System;
using System.Collections.Generic;

namespace EF6Alpha2.MovieWorld
{
	public class Movie
	{
		public Guid MovieId { get; set; }
		public string Title { get; set; }

		public Director Director { get; set; }

		public int Length { get; set; }

		public virtual ICollection<Actor> Actors { get; set; }

		public DateTime WorldPremiere { get; set; }
	}
}