using System;
using System.ComponentModel.DataAnnotations;


namespace BEE.Models
{
    public class NewRegViewModel : BaseEntity
    {
        [Required(ErrorMessage = "☝🏻 First name is required.")]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "☝🏻 Letters only in the Name Field.")]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "☝🏻 Last name is required.")]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Street Address")]
        public string stAddress { get; set; }

        [Display(Name = "City")]
        public string city { get; set; }

        [Display(Name = "State")]
        public string state { get; set; }

        [Display(Name = "Zip code")]
        public int zip { get; set; }

        [Required(ErrorMessage = "☝🏻 A valid email address is required.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "☝🏻 Password is required.")]
        [MinLength(8, ErrorMessage = "☝🏻 Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Compare("password", ErrorMessage = "☝🏻 Password and confirmation must match.")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string cpassword { get; set; }

        [Display(Name = "User Type")]
        public string userType { get; set; }

    }
    
}