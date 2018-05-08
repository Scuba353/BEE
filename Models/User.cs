using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BEE.Models
{
    public class user : BaseEntity
    {
        [Key]
        public int userid { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string stAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }

        public string email { get; set; }
        public string password { get; set; }
        public string userType { get; set; }

<<<<<<< HEAD
        // public List<hive> hives { get; set; }
        // public List<permission> permissions { get; set; }
=======
        
        public List<hive> hives { get; set; }
        public List<permission> permissions { get; set; }
>>>>>>> fb7869f38d73aeb3faf578fb114d2ce928fb4899
        // The name Accounts above this line and below this line can be named anything but must be named the same
        // it is a representation of what is in our db table not our db table 
        public user()
        {
            hives = new List<hive>();
            permissions = new List<permission>();
        }

    }

}