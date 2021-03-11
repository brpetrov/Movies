namespace Movies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropGenreColumnFrmMoviesTbl : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
