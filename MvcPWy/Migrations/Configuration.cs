namespace MvcPWy.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcPWy.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcPWy.Models.ApplicationDbContext";
        }

        protected override void Seed(MvcPWy.Models.ApplicationDbContext context)
        {
            string roleName = "Administrator";
            string userName = "admin@gmail.com";
            string password = "Password2015";
            string email = "admin@gmail.com";


            context.Users.AddOrUpdate(
                  new Models.ApplicationUser { 
                            Email = email, 
                            EmailConfirmed=true,
                            Id = "11",
                            UserName = userName,
                            PasswordHash = "AIBC/ix/ueunE2DrcP50RAaTGJJXnYbmFpGwln7EmDW7yD8jcGY/2RjSu7opFzNS8Q==",
                            SecurityStamp = "1b57454b-3e84-4e45-9768-d26f95ba6006",
                  }
                );



            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
