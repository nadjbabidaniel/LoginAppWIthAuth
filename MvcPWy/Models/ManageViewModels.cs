using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace MvcPWy.Models
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string SocialMedia { get; set; }
        public string CompanyName { get; set; }
        public int CompanySize { get; set; }
        public string JobTitle { get; set; }

        [Display(Name = "Country")]
        public Country Country { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public Ethnicity Ethnicity { get; set; }
        public int CurrentNumberPrizes { get; set; }
        public int MaxNumberPrizes { get; set; } = 4;
        public bool TwoFactor { get; set; } = false;
        public bool BrowserRemembered { get; set; }
    }

    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    public class FactorViewModel
    {
        public string Purpose { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }

    public class ChangeFirstLastNameJobTitleViewModel
    {
        [Display(Name = "Please insert your first name")]
        public string FirstName { get; set; }

        [Display(Name = "Please insert your last name")]
        public string LastName { get; set; }

        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }
    }

    public class ChangeGenderEthnicityViewModel
    {
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }

        [Display(Name = "Ethnicity")]
        public Ethnicity Ethnicity { get; set; }
    }
    
    public class ChangeCountryStateCity
    {
        [Display(Name = "Country")]
        public Country Country { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }
    }

    public class ChangeSocialMediaViewModel
    {
        [Display(Name = "SocialMedia")]
        public string SocialMedia { get; set; }
    }

    public class ChangeCompanyNameAndSize
    {
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Company Size")]
        public int CompanySize { get; set; }
    }

    public class VerifyPhoneNumberViewModel
    {
        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }

    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }
}