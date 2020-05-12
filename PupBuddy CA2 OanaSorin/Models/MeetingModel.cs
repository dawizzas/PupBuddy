using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PupBuddy_CA2_OanaSorin.Models
{
    public class MeetingModel
    {
        [Key]
        public string MeetingID { get; set; }
        public string OrganiserPuppyID { get; set; }
        public string AttendeePuppyID { get; set; }
        public string PuppyID { get; set; }
        public string OwnerID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime OutForWalk { get; set; }

        public string Location  { get; set; }

        [NotMapped]
        public List<PuppyModel> PuppyCollection { get; set; }

    }
}