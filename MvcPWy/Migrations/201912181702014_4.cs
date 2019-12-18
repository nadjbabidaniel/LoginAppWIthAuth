namespace MvcPWy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "HouseHoldIncome", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "HouseHoldIncome");
        }
    }
}
