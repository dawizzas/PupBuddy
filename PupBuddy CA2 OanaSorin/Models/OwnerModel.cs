﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PupBuddy_CA2_OanaSorin.Models
{
    public class OwnerModel
    {
        [Required]
        public int Id { get; set; }
        public string OwnerName { get; set; }
        //pk 
        [Key]
        public string OwnerPhoneNumber { get; set; }
    }
}