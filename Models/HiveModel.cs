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
        
<<<<<<< HEAD:Models/Hive.cs

=======
        
>>>>>>> fb7869f38d73aeb3faf578fb114d2ce928fb4899:Models/HiveModel.cs

        
        [ForeignKey("userid")]
        public int userid { get; set; }



        public user users { get; set; }


    }
}