using System.Data.Entity.Migrations;

namespace EF6Alpha2.MovieWorld.Migrations
{
	public partial class Initial : DbMigration
	{
		public override void Up()
		{
			CreateTable(
				"dbo.Movies",
				c => new
					     {
						     MovieId = c.Guid(nullable: false),
						     Title = c.String(),
						     WorldPremiere = c.DateTime(nullable: false, storeType: "datetime2"),
						     Director_DirectorId = c.Guid(),
					     })
				.PrimaryKey(t => t.MovieId)
				.ForeignKey("dbo.Directors", t => t.Director_DirectorId)
				.Index(t => t.Director_DirectorId);

			CreateTable(
				"dbo.Directors",
				c => new
					     {
						     DirectorId = c.Guid(nullable: false),
						     Name = c.String(),
					     })
				.PrimaryKey(t => t.DirectorId);

			CreateTable(
				"dbo.Actors",
				c => new
					     {
						     ActorId = c.Guid(nullable: false),
						     Name = c.String(),
					     })
				.PrimaryKey(t => t.ActorId);

			CreateTable(
				"dbo.ActorMovies",
				c => new
					     {
						     Actor_ActorId = c.Guid(nullable: false),
						     Movie_MovieId = c.Guid(nullable: false),
					     })
				.PrimaryKey(t => new {t.Actor_ActorId, t.Movie_MovieId})
				.ForeignKey("dbo.Actors", t => t.Actor_ActorId, cascadeDelete: true)
				.ForeignKey("dbo.Movies", t => t.Movie_MovieId, cascadeDelete: true)
				.Index(t => t.Actor_ActorId)
				.Index(t => t.Movie_MovieId);
		}

		public override void Down()
		{
			DropForeignKey("dbo.ActorMovies", "Movie_MovieId", "dbo.Movies");
			DropForeignKey("dbo.ActorMovies", "Actor_ActorId", "dbo.Actors");
			DropForeignKey("dbo.Movies", "Director_DirectorId", "dbo.Directors");
			DropIndex("dbo.ActorMovies", new[] {"Movie_MovieId"});
			DropIndex("dbo.ActorMovies", new[] {"Actor_ActorId"});
			DropIndex("dbo.Movies", new[] {"Director_DirectorId"});
			DropTable("dbo.ActorMovies");
			DropTable("dbo.Actors");
			DropTable("dbo.Directors");
			DropTable("dbo.Movies");
		}
	}
}