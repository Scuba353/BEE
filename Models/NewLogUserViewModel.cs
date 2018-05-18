using System;
using System.ComponentModel.DataAnnotations;


namespace BEE.Models
{
    public class NewLogUserViewModel : BaseEntity
    {

        [Required(ErrorMessage = "☝🏻 Your registered email is required.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "☝🏻 Your password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }



    }
}