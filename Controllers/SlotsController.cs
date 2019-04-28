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
        [Route("api/slots/PublishSlots")]
        public object PublishSlots(Slots getSlots)
        {
            try
            {
                var slot = dbContext.Slots.Where(s => s.panelId == getSlots.panelId &&
                                ((getSlots.start <= s.start && getSlots.end >= s.start) ||
                                    (getSlots.start <= s.end && getSlots.end >= s.end) ||
                                        (getSlots.start >= s.start && getSlots.end <= s.end))).ToList();
                    if (slot.Count() > 0)
                    return "overlapping";
                getSlots.dayOfWeek = getSlots.start.Date.DayOfWeek.ToString();
                getSlots.isRecurring = getSlots.recurringType != null;
                dbContext.Slots.Add(getSlots);
                dbContext.SaveChanges();
                return "done";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
