using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace BEE.Models
{
    public class hive : BaseEntity
    {
        [Key]
        public int hiveid { get; set; }
        public string hiveAddress { get; set; }
        public string hiveCity { get; set; }
        public string hiveState { get; set; }
        public int hiveZip { get; set; }
        public string age { get; set; }
        public string status { get; set; }
        public string notes { get; set; }
        
        

        
        [ForeignKey("userid")]
        public int userid { get; set; }
        public user user { get; set; }


    }
}