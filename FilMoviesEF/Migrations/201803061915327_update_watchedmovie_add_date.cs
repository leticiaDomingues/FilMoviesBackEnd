namespace FilMoviesAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_watchedmovie_add_date : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MoviesWatched", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MoviesWatched", "Date");
        }
    }
}
