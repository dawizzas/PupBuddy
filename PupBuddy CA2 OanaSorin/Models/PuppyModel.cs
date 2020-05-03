using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace PupBuddy_CA2_OanaSorin.Models
{
    public class PuppyModel
    {
        public int PuppyID{ get; set; }

        //pk
        public string OwnerID { get; set; }
        [Required(ErrorMessage ="Please provide the breed")]
        public string Breed { get; set; }
        public string PupName { get; set; }
        public string PupSize{ get; set; }
        public DateTime PupDateOfBirth { get; set; }

    }
}