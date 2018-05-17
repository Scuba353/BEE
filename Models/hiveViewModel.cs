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
        [Required( ErrorMessage = "A Hive Address is required.  This is a simple way to identify each of your hives.")]
        [MinLength(2)]
        [Display(Prompt = "Hive Address")]
        //[Display(Name = "Hive Address: ")]
        public string hiveAddress { get; set; }

        [Required( ErrorMessage = "A Hive City is required.  You may decide to spread your hives to the far corners of the county someday!")]
        [MinLength(2)]
        [Display(Prompt = "Hive City ")]
        public string hiveCity { get; set; }

        [Required( ErrorMessage = "A Hive State is required.  You may decide to spread your hives to the far corners of the nation someday!")]
        [MinLength(2)]
        [Display(Prompt = "Hive State ")]
        public string hiveState { get; set; }

        [Required( ErrorMessage = "Hive Zip is required.  You may decide to sell your wonderful honey, and you may need your hive's zip for tax purposes.")]
        // [MinLength(5)]
        [Display(Prompt = "Hive Zip ")]
        public int hiveZip { get; set; }

        [Required( ErrorMessage = "Hive Age is required.  Is this hive young, newly established, mature, difficult teenager, etc.?")]
        [MinLength(2)]
        [Display(Prompt = "Hive Age ")]
        public string age { get; set; }

        [Required( ErrorMessage = "Hive Status is required.  Is this Hive Healthy? What's the Swarm Potential? Any Mites or Infections?")]
        [MinLength(2)]
        [Display(Prompt = "Hive Status ")]
        public string status { get; set; }

        [Required( ErrorMessage = "Hive Notes are required.  Do not mention the Queen's mother!")]
        [MinLength(2)]
        [Display(Prompt = "Hive Notes ")]
        public string notes { get; set; }
        
        

    }
}