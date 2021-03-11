namespace Movies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBirthDateColumnNam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MyProperty", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
