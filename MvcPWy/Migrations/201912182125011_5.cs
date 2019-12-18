namespace MvcPWy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Country", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "CountryName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "CountryName", c => c.String());
            DropColumn("dbo.AspNetUsers", "Country");
        }
    }
}
