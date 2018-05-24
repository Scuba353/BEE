using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace BEE.Models
{
    public class PermissionViewModel : BaseEntity
    {
        [Required( ErrorMessage = "An Amount of Land is required.")]
        [MinLength(2)]
        [Display(Prompt = "Amount of Land")]
        public string landAmt { get; set; }
  
        // [Required( ErrorMessage = "Do you have an Allergy to Bees?")]
        // [Display(Name = "Bee Allergy?: ")]
        // public bool allergies { get; set; }

        [Required( ErrorMessage = "Do you have an Allergy to Bees?")]
        [Display(Prompt = "Bee Allergy?: ")]
        public bool allergies { get; set; }

        [Required( ErrorMessage = "What kind of Access is there to the property?")]
        [MinLength(5)]
        [Display(Prompt = "Describe access for interested Bee Keepers")]
        public string accessInfo { get; set; }

        [Required( ErrorMessage = "What is the timeframe when your friendly, neighborhood Bee Keeper could have access?")]
        [MinLength(2)]
        [Display(Prompt = "Best timeframe for Bee Keeper access?")]
        public string accessTime { get; set; }

    }
}