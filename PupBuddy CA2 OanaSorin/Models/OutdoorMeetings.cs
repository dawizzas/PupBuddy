using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PupBuddy_CA2_OanaSorin.Models
{
    public class OutdoorMeetings
    {
        [Key]
        public string OwnerPhoneNumber { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime OutForWalk { get; set; }

        public string Location  { get; set; }

    }
}