namespace MvcPWy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Gender", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "SocialMedia", c => c.String());
            AddColumn("dbo.AspNetUsers", "CompanySize", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "JobTitle", c => c.String());
            AddColumn("dbo.AspNetUsers", "CountryName", c => c.String());
            AddColumn("dbo.AspNetUsers", "StateName", c => c.String());
            AddColumn("dbo.AspNetUsers", "CityName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Ethnicity", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "Job");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Job", c => c.String());
            DropColumn("dbo.AspNetUsers", "Ethnicity");
            DropColumn("dbo.AspNetUsers", "CityName");
            DropColumn("dbo.AspNetUsers", "StateName");
            DropColumn("dbo.AspNetUsers", "CountryName");
            DropColumn("dbo.AspNetUsers", "JobTitle");
            DropColumn("dbo.AspNetUsers", "CompanySize");
            DropColumn("dbo.AspNetUsers", "SocialMedia");
            DropColumn("dbo.AspNetUsers", "Gender");
        }
    }
}
