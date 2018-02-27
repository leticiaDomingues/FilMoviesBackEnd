namespace FilMoviesEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ActorID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 30),
                        Duration = c.Int(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        Description = c.String(nullable: false),
                        ImageUrl = c.String(nullable: false, maxLength: 500),
                        Rate = c.Single(),
                    })
                .PrimaryKey(t => t.MovieID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        DirectorID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.DirectorID);
            
            CreateTable(
                "dbo.MoviesWatched",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 30),
                        MovieID = c.Int(nullable: false),
                        Favorite = c.Boolean(),
                        Rate = c.Single(),
                    })
                .PrimaryKey(t => new { t.Username, t.MovieID })
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Username, cascadeDelete: true)
                .Index(t => t.Username)
                .Index(t => t.MovieID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 30),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Username = c.String(nullable: false, maxLength: 30),
                        MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Users", t => t.Username, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .Index(t => t.Username)
                .Index(t => t.MovieID);
            
            CreateTable(
                "dbo.MovieActor",
                c => new
                    {
                        MovieID = c.Int(nullable: false),
                        ActorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MovieID, t.ActorID })
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .ForeignKey("dbo.Actors", t => t.ActorID, cascadeDelete: true)
                .Index(t => t.MovieID)
                .Index(t => t.ActorID);
            
            CreateTable(
                "dbo.MovieCategory",
                c => new
                    {
                        MovieID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MovieID, t.CategoryID })
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.MovieID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.MovieDirector",
                c => new
                    {
                        MovieID = c.Int(nullable: false),
                        DirectorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MovieID, t.DirectorID })
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .ForeignKey("dbo.Directors", t => t.DirectorID, cascadeDelete: true)
                .Index(t => t.MovieID)
                .Index(t => t.DirectorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.Reviews", "Username", "dbo.Users");
            DropForeignKey("dbo.MoviesWatched", "Username", "dbo.Users");
            DropForeignKey("dbo.MoviesWatched", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.MovieDirector", "DirectorID", "dbo.Directors");
            DropForeignKey("dbo.MovieDirector", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.MovieCategory", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.MovieCategory", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.MovieActor", "ActorID", "dbo.Actors");
            DropForeignKey("dbo.MovieActor", "MovieID", "dbo.Movies");
            DropIndex("dbo.MovieDirector", new[] { "DirectorID" });
            DropIndex("dbo.MovieDirector", new[] { "MovieID" });
            DropIndex("dbo.MovieCategory", new[] { "CategoryID" });
            DropIndex("dbo.MovieCategory", new[] { "MovieID" });
            DropIndex("dbo.MovieActor", new[] { "ActorID" });
            DropIndex("dbo.MovieActor", new[] { "MovieID" });
            DropIndex("dbo.Reviews", new[] { "MovieID" });
            DropIndex("dbo.Reviews", new[] { "Username" });
            DropIndex("dbo.MoviesWatched", new[] { "MovieID" });
            DropIndex("dbo.MoviesWatched", new[] { "Username" });
            DropTable("dbo.MovieDirector");
            DropTable("dbo.MovieCategory");
            DropTable("dbo.MovieActor");
            DropTable("dbo.Reviews");
            DropTable("dbo.Users");
            DropTable("dbo.MoviesWatched");
            DropTable("dbo.Directors");
            DropTable("dbo.Categories");
            DropTable("dbo.Movies");
            DropTable("dbo.Actors");
        }
    }
}
