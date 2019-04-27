using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IMS_New.Models
{
    public class Slots
    {
        [Key]
        public int slotId { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        
        public bool isRecurring { get; set; }
        public string recurringType { get; set; }
        public string dayOfWeek { get; set; }
        public string panelId { get; set; }
    }

    public class SlotException
    {
        [Key]
        public int slotExceptionId { get; set; }
        public Slots slots { get; set; }
        [ForeignKey("slots")]
        public int slotId { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    
        public string status { get; set; }
    }

 
}