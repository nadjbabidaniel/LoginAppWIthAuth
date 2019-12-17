using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MvcPWy.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        //Extended Properties
        public override string PhoneNumber { get; set; }        
        public string FirstName { get; set; }        
        public string LastName { get; set; }
        public Gender Gender{ get; set; }
        public string SocialMedia { get; set; }
        public string CompanyName { get; set; }
        public int CompanySize { get; set; }
        public string JobTitle { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public Ethnicity Ethnicity { get; set; }
        public int CurrentNumberPrizes{ get; set; }
        public int MaxNumberPrizes { get; set; } = 4;
    }

    public enum Gender {
        None,
        Male,
        Female
    }
    public enum Ethnicity
    {
        Other,
        White,
        Black,
        Asian,
        Native_American,
        Hispano
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}