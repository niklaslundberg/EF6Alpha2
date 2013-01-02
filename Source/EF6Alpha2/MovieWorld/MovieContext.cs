using System.Data.Entity;
using System.Data.Entity.Config;
using EF6Alpha2.Common;

namespace EF6Alpha2.MovieWorld
{
	[DbConfigurationType(typeof (HappyWorldConfiguration))]
	public class MovieContext : DbContext
	{
		public MovieContext() : base("HappyWorld")
		{
		}

		public IDbSet<Movie> Movies { get; set; }
		public IDbSet<Actor> Actors { get; set; }
		public IDbSet<Director> Directors { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Add<DefaultDateTimeColumnTypeConvention>();
		}
	}
}