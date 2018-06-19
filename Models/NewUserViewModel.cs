using System;
using System.ComponentModel.DataAnnotations;


namespace BEE.Models
{
    public class NewUserViewModel : BaseEntity
    {
        [Required(ErrorMessage = "☝🏻 First name is required")]
        [MinLength(2, ErrorMessage = "☝🏻 First name field requires at least 2 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "☝🏻 Letters only in the Name field")]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "☝🏻 Last name is required.")]
        [MinLength(2, ErrorMessage = "☝🏻 Last name field requires at least 2 characters")]
        [RegularExpression(@"^[a-zA-Z]+$")]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Street Address")]
        [MinLength(1, ErrorMessage = "☝🏻 Street Address field requires at least 1 character")]
        public string stAddress { get; set; }

        [Display(Name = "City")]
        [MinLength(1, ErrorMessage = "☝🏻 City field requires at least 1 character")]
        [RegularExpression(@"^[\p{L} \.'\-]+$", ErrorMessage = "Letters only in City field")]
        public string city { get; set; }

        [Display(Name = "State")]
        [MinLength(1, ErrorMessage = "☝🏻 State field requires at least 1 character")]
        [RegularExpression(@"^[\p{L} \.'\-]+$", ErrorMessage = "Letters only in the State field")]
        public string state { get; set; }

        [Display(Name = "Zip code")]
        [RegularExpression(@"^(\d{5})|(\d{5}-\d{4})$", ErrorMessage = "Please use a US ZIP or US ZIP +4 format")]
        public int zip { get; set; }

        [Required(ErrorMessage = "☝🏻 A valid email address is required.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string email { get; set; }

        // [Required(ErrorMessage = "☝🏻 Password is required.")]
        // [MinLength(8, ErrorMessage = "☝🏻 Password must be at least 8 characters")]
        // [DataType(DataType.Password)]
        // [Display(Name = "Password")]

        [Required(ErrorMessage = "☝🏻 Password is required.")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [Display(Name = "Password")]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
        // public string Password { get; set; }
        public string password { get; set; }

        [Compare("password", ErrorMessage = "☝🏻 Password and confirmation must match.")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string cpassword { get; set; }

        [Display(Name = "User Type")]
        public string userType { get; set; }

    }
}