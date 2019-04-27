using IMS_New.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IMS_New.Controllers
{
    public class SlotsController : ApiController
    {
        InterviewController interview = new InterviewController();

        public ApplicationDbContext dbContext;
        public SlotsController()
        {
            dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        [Route("api/slots/PostSlots")]
        public object PostSlots(GetSlots getSlots)
        {
            var oldSlot=dbContext.Slots.Where(c=>c.panelId==getSlots.panelId 
                        && c.)
           
            var slot = new Slots() {

                dayOfWeek=getSlots.start.DayOfWeek.ToString(),
                endDate=getSlots.end.Date,
                endTime=getSlots.end.AddSeconds(-getSlots.end.TimeOfDay.Seconds),
                recurringType=getSlots.recurringType,
                panelId=getSlots.panelId,
                startDate=getSlots.start.Date,
                startTime=getSlots.start.AddSeconds(-getSlots.start.TimeOfDay.Seconds).TimeOfDay
               
            };
            slot.isRecurring = getSlots.recurringType != null;
            dbContext.Slots.Add(slot);
            dbContext.SaveChanges();
            return "";
        }
    }
}
