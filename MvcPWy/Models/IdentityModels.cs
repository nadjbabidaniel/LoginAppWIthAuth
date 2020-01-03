using System.ComponentModel.DataAnnotations;
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
        public Gender Gender { get; set; }
        public string SocialMedia { get; set; }
        public string CompanyName { get; set; }
        public int CompanySize { get; set; } = 0;
        public string JobTitle { get; set; }
        public Country Country{ get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public Ethnicity Ethnicity { get; set; }
        public string HouseHoldIncome { get; set; }
        public int CurrentNumberPrizes { get; set; }
        public int MaxNumberPrizes { get; set; } = 4;
    }

    public enum Gender
    {
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
        [Display(Name = "Native American")]
        Native_American,
        Hispano
    }

    public enum Country
    {
        [Display(Name = "United States of America")]
        United_States_of_America,       
        Afghanistan,
        Albania,
        Algeria,
        Andorra,
        Angola,
        Argentina,
        Armenia,
        Australia,
        Austria,
        Azerbaijan,
        Bahamas,
        Bahrain,
        Bangladesh,
        Barbados,
        Belarus,
        Belgium,
        Belize,
        Benin,
        Bhutan,
        Bolivia,
        [Display(Name = "Bosnia and Herzegovina")]
        Bosnia_and_Herzegovina,
        Botswana,
        Brazil,
        Brunei,
        Bulgaria,        
        Burundi,     
        Cambodia,
        Cameroon,
        Canada,
        [Display(Name = "Central African Republic")]
        Central_African_Republic,
        Chad,
        Chile,
        China,
        Colombia,
        Comoros,
        Congo,
        Costa_Rica,
        Croatia,
        Cuba,
        Cyprus,
        Czech_Republic,
        [Display(Name = "Democratic Republic of the Congo")]
        Democratic_Republic_of_the_Congo,
        Denmark,
        Djibouti,
        Dominica,
        Dominican_Republic,
        Ecuador,
        Egypt,
        El_Salvador,
        Equatorial_Guinea,
        Eritrea,
        Estonia,
        Eswatini,
        Ethiopia,
        Fiji,
        Finland,
        France,
        Gabon,
        Gambia,
        Georgia,
        Germany,
        Ghana,
        Greece,
        Grenada,
        Guatemala,
        Guinea,
        Guyana,
        Haiti,
        Holy_See,
        Honduras,
        Hungary,
        Iceland,
        India,
        Indonesia,
        Iran,
        Iraq,
        Ireland,
        Israel,
        Italy,
        Jamaica,
        Japan,
        Jordan,
        Kazakhstan,
        Kenya,
        Kiribati,
        Kuwait,
        Kyrgyzstan,
        Laos,
        Latvia,
        Lebanon,
        Lesotho,
        Liberia,
        Libya,
        Liechtenstein,
        Lithuania,
        Luxembourg,
        Madagascar,
        Malawi,
        Malaysia,
        Maldives,
        Mali,
        Malta,
        Marshall_Islands,
        Mauritania,
        Mauritius,
        Mexico,
        Micronesia,
        Moldova,
        Monaco,
        Mongolia,
        Montenegro,
        Morocco,
        Mozambique,
        Myanmar,
        Namibia,
        Nauru,
        Nepal,
        Netherlands,
        New_Zealand,
        Nicaragua,
        Niger,
        Nigeria,
        [Display(Name = "North Korea")]
        North_Korea,
        Norway,
        Oman,
        Pakistan,
        Palau,
        Palestine_State,
        Panama,
        Papua_New_Guinea,
        Paraguay,
        Peru,
        Philippines,
        Poland,
        Portugal,
        Qatar,
        Romania,
        Russia,
        Rwanda,       
        San_Marino,
        Saudi_Arabia,
        Senegal,
        Serbia,
        Seychelles,
        Singapore,
        Slovakia,
        Slovenia,
        Solomon_Islands,
        Somalia,
        South_Africa,
        [Display(Name = "South Korea")]
        South_Korea,
        South_Sudan,
        Spain,
        Sri_Lanka,
        Sudan,
        Suriname,
        Sweden,
        Switzerland,
        Syria,
        Tajikistan,
        Tanzania,
        Thailand,
        Timor_Leste,
        Togo,
        Tonga,
        Trinidad_and_Tobago,
        Tunisia,
        Turkey,
        Turkmenistan,
        Tuvalu,
        Uganda,
        Ukraine,
        [Display(Name = "United Arab Emirates")]
        United_Arab_Emirates,
        [Display(Name = "United Kindgdom")]
        United_Kingdom,
        Uruguay,
        Uzbekistan,
        Vanuatu,
        Venezuela,
        Vietnam,
        Yemen,
        Zambia,
        Zimbabwe
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