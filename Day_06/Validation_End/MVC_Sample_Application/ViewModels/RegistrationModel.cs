using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Sample_Application.ViewModels
{
    public class RegistrationModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        //public Country Country { get; set; }
        //public City City { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public bool TermsAccepted { get; set; }
    }

    public class Country
    {
        public int? ID { get; set; }
        public string Name { get; set; }
    }

    public class City
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public int? Country { get; set; }
    }



    //public class RegistrationMetaModel
    //{
    //    [Required(ErrorMessage = "Please Enter Email Address")]
    //    [Display(Name = "UserName (Email Address)")]
    //    [RegularExpression(".+@.+\\..+", ErrorMessage = "Please Enter Correct Email Address")]
    //    public string UserName { get; set; }

    //    [Required(ErrorMessage = "Please Enter Password")]
    //    [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
    //    [DataType(DataType.Password)]
    //    [Display(Name = "Password")]
    //    public string Password { get; set; }

    //    [Required(ErrorMessage = "Please Enter Confirm Password")]
    //    [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
    //    [DataType(DataType.Password)]
    //    [Display(Name = "Confirm password")]
    //    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    //    public string ConfirmPassword { get; set; }

    ////    [Display(Name = "Country")]
    ////    [ValidCountryAttribute(ErrorMessage = "Please Select Country")]
    ////    public Country Country { get; set; }

    ////    [Display(Name = "City")]
    ////    [ValidCityAttribute(ErrorMessage = "Please Select City")]
    ////    public City City { get; set; }

    //    [Required(ErrorMessage = "Please Enter Address")]
    //    [Display(Name = "Address")]
    //    [MaxLength(200)]
    //    public string Address { get; set; }

    //    [Required(ErrorMessage = "Please Enter Mobile No")]
    //    [Display(Name = "Mobile")]
    //    [StringLength(10, ErrorMessage = "The Mobile must contains 10 characters", MinimumLength = 10)]
    //    public string MobileNo { get; set; }

    //    [MustBeTrue(ErrorMessage = "Please Accept the Terms & Conditions")]
    //    public bool TermsAccepted { get; set; }
    //}

    //public class MustBeTrueAttribute : ValidationAttribute
    //{
    //    public override bool IsValid(object value)
    //    {
    //        return value is bool && (bool)value;
    //    }
    //}
    //public class ValidCountryAttribute : ValidationAttribute
    //{
    //    public override bool IsValid(object value)
    //    {
    //        if (((Country)value).ID == null || ((Country)value).ID == 0)
    //            return false;
    //        else
    //            return true;
    //    }
    //}
    //public class ValidCityAttribute : ValidationAttribute
    //{
    //    public override bool IsValid(object value)
    //    {
    //        if (((City)value).ID == null || ((City)value).ID == 0)
    //            return false;
    //        else
    //            return true;
    //    }
    //}
}
