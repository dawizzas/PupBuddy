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
        [Key]
        public int PuppyID{ get; set; }

        //sk
        public string OwnerID { get; set; }
       // [Required(ErrorMessage ="Please provide the breed")]
        public string Breed { get; set; }
        public string PupName { get; set; }
        public string PupSize{ get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]

        public DateTime PupDateOfBirth { get; set; }


    }
}