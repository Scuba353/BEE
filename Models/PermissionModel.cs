using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEE.Models
{
    public class permission: BaseEntity {
        
        [Key]
        public int permissionid { get; set; }
        
        public string landAmt { get; set; }
  
        public bool allergies { get; set; }

        public string accessInfo { get; set; }

        public string accessTime { get; set; }


        public int userid { get; set; }
       
        [ForeignKey ("userid")]
        public user users { get; set; }

    }
}