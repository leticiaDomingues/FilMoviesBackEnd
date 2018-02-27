namespace FilMoviesEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Text;

    public partial class create_sp_calculate_rate : DbMigration
    {
        public override void Up()
        {
            StringBuilder storedProcedureCode = new StringBuilder();

            storedProcedureCode.Append("CREATE PROCEDURE dbo.calculateRate" + Environment.NewLine);
            storedProcedureCode.Append("@movieId int," + Environment.NewLine);
            storedProcedureCode.Append("@rate float OUTPUT" + Environment.NewLine);
            storedProcedureCode.Append("AS" + Environment.NewLine);
            storedProcedureCode.Append("BEGIN" + Environment.NewLine);
            storedProcedureCode.Append(@"SELECT @rate = AVG(mw.Rate)
	                                    FROM Movies m
	                                    INNER JOIN MoviesWatched mw
		                                    ON mw.MovieID = m.MovieID AND m.MovieID=@movieId
	                                    GROUP BY m.MovieID" + Environment.NewLine);
            storedProcedureCode.Append("END" + Environment.NewLine);

            this.Sql(storedProcedureCode.ToString());

        }

        public override void Down()
        {
            this.Sql("DROP PROCEDURE dbo.calculateRate");
        }
    }
}
