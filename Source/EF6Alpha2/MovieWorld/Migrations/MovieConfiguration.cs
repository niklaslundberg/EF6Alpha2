using System;
using System.Data.Entity.Migrations;

namespace EF6Alpha2.MovieWorld.Migrations
{
	internal sealed class MovieConfiguration : DbMigrationsConfiguration<MovieContext>
	{
		public MovieConfiguration()
		{
			AutomaticMigrationsEnabled = true;
			MigrationsDirectory = @"MovieWorld\Migrations";
		}

		protected override void Seed(MovieContext context)
		{
			Director director = new Director
				                    {
					                    Name = "Peter Jackson",
					                    DirectorId = new Guid("8C0ED5ED-3DFA-46F8-A282-99E6B6B6F358")
				                    };
			var movie = new Movie
				            {
					            MovieId = new Guid("8C0ED5ED-3DFA-46F8-A282-99E6B6B6F359"),
					            Title = "Bilbo",
					            Director = director,
					            WorldPremiere = new DateTime(11, 12, 13)
				            };

			context.Movies.AddOrUpdate(movie);
			context.SaveChanges();
		}
	}
}