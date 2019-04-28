using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IMS_New.Models
{
    public class Interview
    {
        [Key]
        public int interviewID { get; set; }
        public Guid interviewGuid { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public Slots slots { get; set; }
        [ForeignKey("slots")]
        public int slotId { get; set; }
        public string panelId { get; set; }
        public bool isPrimaryPanel { get; set; }

    }
   
    
}