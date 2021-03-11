namespace Movies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateColumnToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MyProperty", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "MyProperty");
        }
    }
}
