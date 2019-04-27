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
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public TimeSpan startTime { get; set; }
        public TimeSpan endTime { get; set; }
        public Slots slots { get; set; }
        [ForeignKey("slots")]
        public int slotId { get; set; }
        public string panelId { get; set; }
        public string panelType { get; set; }

    }
    public class setInterview {

        public string panelid { get; set; }
        public DateTime stime { get; set; }
        public DateTime etime { get; set; }
        public int slotId { get; set; }
        public string panelType { get; set; }
    }
    public class SendException {


        public DateTime stime { get; set; }
        public DateTime etime { get; set; }
        public int slotId { get; set; }
        public string status { get; set; }
     
    }
}