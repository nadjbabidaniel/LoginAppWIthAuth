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
        public int CompanySize { get; set; }
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
        Antigua_and_Barbuda,
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
        Bosnia_and_Herzegovina,
        Botswana,
        Brazil,
        Brunei,
        Bulgaria,
        Burkina_Faso,
        Burundi,
        Côte_dIvoire,
        Cabo_Verde,
        Cambodia,
        Cameroon,
        Canada,
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
        Guinea_Bissau,
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
        North_Korea,
        North_Macedonia,
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
        Saint_Kitts_and_Nevis,
        Saint_Lucia,
        Saint_Vincent_and_the_Grenadines,
        Samoa,
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
        United_Arab_Emirates,
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