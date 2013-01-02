using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using EF6Alpha2.MovieWorld;
using Machine.Specifications;

namespace EF6Alpha2.Common
{
	[Subject(typeof (MovieContext))]
	public class when_listing_movies
	{
		static Task<List<Movie>> movies;
		static MovieContext ctx;

		Establish context = () => { ctx = new MovieContext(); };

		Because of = () => { movies = ctx.Movies.ToListAsync(); };

		It should_be_at_least_one_movie = () =>
			{
				movies.Wait();
				movies.Result.Count.ShouldBeGreaterThanOrEqualTo(1);
			};

		Cleanup the_context = () =>
			{
				using (ctx)
				{
				}
			};
	}
}