namespace FilMoviesAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_password_length : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 64));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
