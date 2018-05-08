using System;
using System.ComponentModel.DataAnnotations;


namespace BEE.Models
{
    public class RegisteredUserViewModel : BaseEntity
    {

        [Required(ErrorMessage = "☝🏻 Your registered email is required.")]
        [EmailAddress]
        public string email { get; set; }

        [Required(ErrorMessage = "☝🏻 Your password is required.")]
        [DataType(DataType.Password)]
        public string password { get; set; }



    }
}