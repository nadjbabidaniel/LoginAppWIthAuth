namespace MvcPWy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CurrentNumberPrizes", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "MaxNumberPrizes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "MaxNumberPrizes");
            DropColumn("dbo.AspNetUsers", "CurrentNumberPrizes");
        }
    }
}
