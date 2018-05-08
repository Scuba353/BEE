using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BEE.Models
{
    public class HiveViewModel : BaseEntity
    {
        [Required( ErrorMessage = "Hive Address is required.")]
        [MinLength(2)]
        [Display(Name = "Hive Address: ")]
        public string hiveAddress { get; set; }

        [Required( ErrorMessage = "Hive City is required.")]
        [MinLength(2)]
        [Display(Name = "Hive City: ")]
        public string hiveCity { get; set; }

        [Required( ErrorMessage = "Hive State is required.")]
        [MinLength(2)]
        [Display(Name = "Hive State: ")]
        public string hiveState { get; set; }

        [Required( ErrorMessage = "Hive Zip is required.")]
        [MinLength(2)]
        [Display(Name = "Hive Zip: ")]
        public int hiveZip { get; set; }

        [Required( ErrorMessage = "Hive Age is required.")]
        [MinLength(2)]
        [Display(Name = "Hive Age: ")]
        public string age { get; set; }

        [Required( ErrorMessage = "Hive Status is required.")]
        [MinLength(2)]
        [Display(Name = "Hive Status: ")]
        public string status { get; set; }

        [Required( ErrorMessage = "Hive Notes are required.")]
        [MinLength(2)]
        [Display(Name = "Hive Notes: ")]
        public string notes { get; set; }
        
        

    }
}